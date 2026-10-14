using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class VoucherNegocio
    {

        public List<Voucher> Listar() {

            List<Voucher> ListVouchers = new List<Voucher>();
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.consultaSql("select vc.CodigoVoucher ,vc.IdArticulo,vc.IdCliente,vc.FechaCanje from Vouchers as vc");
                datos.ejecutarLetura();

                while (datos.Lector.Read())
                {

                    Voucher vouchers = new Voucher();

                    vouchers.CodigoVoucher_V = (string)datos.Lector["CodigoVoucher"];

                    if (!(datos.Lector["IdArticulo"] is DBNull))
                    {

                        vouchers.IdArticulo_V = (int)datos.Lector["IdArticulo"];

                    }


                    if (!(datos.Lector["IdCliente"] is DBNull))
                    {
                        vouchers.idCliente_V = (int)datos.Lector["IdCliente"];
                    }
                    if (!(datos.Lector["FechaCanje"] is DBNull))
                    {
                        vouchers.FechaCanje_V = (DateTime)datos.Lector["FechaCanje"];

                    }



                    ListVouchers.Add(vouchers);


                }

                return ListVouchers;
            }
            catch (SqlException ex)
            {
                throw new Exception("En este momento no pudimos conectar con el servidor. Por favor, intentá nuevamente en unos minutos.", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new Exception("Hubo un problema al procesar la información de los vouchers. Contacte al soporte técnico.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al cargar los datos. Estamos trabajando para solucionarlo.", ex);
            }

            finally
            {

                datos.cerrarConexion();

            }        
        



        }



        public void modificar(Voucher vou) { 
        
        AccesoDatos datos= new AccesoDatos();

            try
            {
                datos.consultaSql("UPDATE dbo.Vouchers SET IdArticulo=@IdArticulo ,IdCliente=@IdCliente ,FechaCanje=@FechaCanje WHERE CodigoVoucher=@CodigoVoucher ");
                datos.setearParametros("@IdArticulo", (object)vou.IdArticulo_V ?? DBNull.Value);
                datos.setearParametros("@IdCliente", (object)vou.idCliente_V ?? DBNull.Value);
                datos.setearParametros("@FechaCanje", (object)vou.FechaCanje_V ?? DBNull.Value);
                datos.setearParametros("@CodigoVoucher", vou.CodigoVoucher_V);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }




        }


    }
}
