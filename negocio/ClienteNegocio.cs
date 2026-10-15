using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class ClienteNegocio
    {
        public void Agregar(Cliente nuevo) { 
        
        
        AccesoDatos dato=new AccesoDatos();
            try
            {
                dato.storedProcedure("stAgregarCliente");
                dato.setearParametros("@id", nuevo.IdCliente_cli);
                dato.setearParametros("@documento", nuevo.Documento_cli);
                dato.setearParametros("@nombre", nuevo.Nombre_cli);
                dato.setearParametros("@apellido", nuevo.Apellido_cli);
                dato.setearParametros("@email", nuevo.Email_cli);
                dato.setearParametros("@ciudad", nuevo.Ciudad_cli);
                dato.setearParametros("@direccion", nuevo.Direccion_cli);
                dato.setearParametros("@cp", nuevo.Cp_cli);
                dato.ejecutarAccion();

            }
            catch (Exception ex )
            {

                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            
            }
                
        
        
        
        }

        public List<Cliente> listar() { 
        
        List<Cliente> listaClientes=new List<Cliente>();

            AccesoDatos dato=new AccesoDatos();

            try
            {
                dato.storedProcedure("stListarCliente");
                dato.ejecutarLetura();

                while (dato.Lector.Read())
                {
                    Cliente aux = new Cliente();

                    aux.IdCliente_cli = (int)dato.Lector["id"];
                    aux.Documento_cli = (string)dato.Lector["documento"];
                    aux.Nombre_cli = (string)dato.Lector["nombre"];
                    aux.Apellido_cli = (string)dato.Lector["apellido"];
                    aux.Email_cli = (string)dato.Lector["email"];
                    aux.Direccion_cli = (string)dato.Lector["direccion"];
                    aux.Ciudad_cli = (string)dato.Lector["ciudad"];
                    aux.Cp_cli = (int)dato.Lector["id"];

                    listaClientes.Add(aux);


                }

                return listaClientes;


            }
            catch (Exception)
            {

                throw;
            }
            finally { 
            
            dato.cerrarConexion();
            }

        
        }







    }
}
