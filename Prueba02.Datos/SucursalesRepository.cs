using System.Collections.Generic;
using System.Data.SqlClient;
using Prueba02.Entidades.Models;

namespace Prueba02.Datos
{
    public class SucursalesRepository : IRepository<Sucursal>
    {
        public void Add(Sucursal entidad)
        {
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Sucursal (IdBanco, Nombre, Direccion, FechaRegistro) VALUES (@IdBanco, @Nombre, @Direccion, @FechaRegistro)";
                    DoInsertUpdate(entidad, cmd);
                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Sucursal entidad)
        {
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Sucursal SET IdBanco = @IdBanco, Nombre = @Nombre, Direccion = @Direccion, FechaRegistro = @FechaRegistro WHERE IdSucursal = @Id";
                    DoInsertUpdate(entidad, cmd);
                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void DoInsertUpdate(Sucursal entidad, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Id", entidad.Id);
            cmd.Parameters.AddWithValue("@IdBanco", entidad.IdBanco);
            cmd.Parameters.AddWithValue("@Nombre", entidad.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", entidad.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", entidad.FechaRegistro);
        }

        public Sucursal GetById(int id)
        {
            var entidad = new Sucursal();
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IdSucursal, IdBanco, Nombre, Direccion, FechaRegistro FROM Sucursal WHERE IdSucursal = @Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            entidad = GetEntity(dr);
                        }
                    }
                }
            }
            return entidad;
        }

        public void Delete(int id)
        {
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Sucursal WHERE IdSucursal = @Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Sucursal> ListarTodos()
        {
            var lista = new List<Sucursal>();
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IdSucursal, IdBanco, Nombre, Direccion, FechaRegistro FROM Sucursal";
                    cn.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(GetEntity(dr));
                        }
                    }
                }
            }
            return lista;
        }

        private static Sucursal GetEntity(SqlDataReader dr)
        {
            return new Sucursal
            {
                Id = dr.GetInt32(0),
                IdBanco = dr.GetInt32(1),
                Nombre = dr.GetString(2),
                Direccion = dr.GetString(3),
                FechaRegistro = dr.GetDateTime(4)
            };
        }
    }
}