using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using Prueba02.Entidades.Models;

namespace Prueba02.Datos
{
    public class BancosRepository : IRepository<Banco>
    {

        public void Add(Banco banco)
        {
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Banco (Nombre, Direccion, FechaRegistro) VALUES (@Nombre, @Direccion, @FechaRegistro)";
                    DoInsertUpdate(banco, cmd);
                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Banco banco)
        {
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Banco SET Nombre = @Nombre, Direccion = @Direccion, FechaRegistro = @FechaRegistro WHERE IdBanco = @Id";
                    DoInsertUpdate(banco, cmd);
                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void DoInsertUpdate(Banco banco, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Id", banco.Id);
            cmd.Parameters.AddWithValue("@Nombre", banco.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", banco.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", banco.FechaRegistro);
        }

        public Banco GetById(int id)
        {
            var banco = new Banco();
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IdBanco, Nombre, Direccion, FechaRegistro FROM Banco WHERE IdBanco = @Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            banco = GetEntity(dr);
                        }
                    }
                }
            }
            return banco;
        }

        public void Delete(int id)
        {
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Banco WHERE IdBanco = @Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Banco> ListarTodos()
        {
            var lista = new List<Banco>();
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IdBanco, Nombre, Direccion, FechaRegistro FROM Banco";
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

        private static Banco GetEntity(SqlDataReader dr)
        {
            return new Banco
            {
                Id = dr.GetInt32(0),
                Nombre = dr.GetString(1),
                Direccion = dr.GetString(2),
                FechaRegistro = dr.GetDateTime(3)
            };
        }
    }
}