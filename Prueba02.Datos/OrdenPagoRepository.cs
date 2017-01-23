using System.Collections.Generic;
using System.Data.SqlClient;
using Prueba02.Entidades.Models;

namespace Prueba02.Datos
{
    public class OrdenPagoRepository : IRepository<OrdenPago>
    {
        public void Add(OrdenPago entidad)
        {
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO OrdenPago (IdSucursal, Monto, Moneda, Estado, FechaPago) VALUES (@IdSucursal, @Monto, @Moneda, @Estado, @FechaPago)";
                    DoInsertUpdate(entidad, cmd);
                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void DoInsertUpdate(OrdenPago entidad, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Id", entidad.Id);
            cmd.Parameters.AddWithValue("@IdSucursal", entidad.IdSucursal);
            cmd.Parameters.AddWithValue("@Monto", entidad.Monto);
            cmd.Parameters.AddWithValue("@Moneda", entidad.Moneda);
            cmd.Parameters.AddWithValue("@Estado", entidad.Estado);
            cmd.Parameters.AddWithValue("@FechaPago", entidad.FechaPago);
        }

        public void Update(OrdenPago entidad)
        {
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE OrdenPago SET IdSucursal = @IdSucursal, Monto = @Monto, Moneda = @Moneda, Estado = @Estado, FechaPago = @FechaPago WHERE IdOrdenPago = @Id";
                    DoInsertUpdate(entidad, cmd);
                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public OrdenPago GetById(int id)
        {
            var entidad = new OrdenPago();
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IdOrdenPago, IdSucursal, Monto, Moneda, Estado, FechaPago FROM OrdenPago WHERE IdOrdenPago = @Id";
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

        private static OrdenPago GetEntity(SqlDataReader dr)
        {
            var entidad = new OrdenPago
            {
                Id = dr.GetInt32(0),
                IdSucursal = dr.GetInt32(1),
                Monto = dr.GetDecimal(2),
                Moneda = dr.GetString(3),
                Estado = dr.GetString(4),
                FechaPago = dr.GetDateTime(5)
            };
            return entidad;
        }

        public void Delete(int id)
        {
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM OrdenPago WHERE IdOrdenPago = @Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<OrdenPago> ListarTodos()
        {
            var lista = new List<OrdenPago>();
            using (var cn = new SqlConnection(Conexion.BaseDatos))
            {
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT IdOrdenPago, IdSucursal, Monto, Moneda, Estado, FechaPago FROM OrdenPago";
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
    }
}