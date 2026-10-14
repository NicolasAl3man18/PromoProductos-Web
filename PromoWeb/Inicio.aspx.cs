using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PromoWeb
{
    public partial class Inicio : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                TxtVaucher.Text = "Ingrese Por Favor Su Voucher";
            }

        }

        protected void btnVaucher_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = "";
            string unificar=TxtVaucher.Text.Trim();

            if (string.IsNullOrEmpty(unificar)) {

                lbMensaje.ForeColor = System.Drawing.Color.Red;
                lbMensaje.Text = "No se ingresó ningún voucher.";


            }
            bool aux = validarVoucher(unificar);


            if (aux)
            {
                
                lbMensaje.ForeColor = System.Drawing.Color.Green; 
                lbMensaje.Text = "Voucher correcto.";

           
                Session["VoucherValido"] = unificar;
               
            }
            else
            {
               
                lbMensaje.ForeColor = System.Drawing.Color.Red;
                lbMensaje.Text = "El voucher ya fue canjeado o no existe.";
            }









        }

        private bool validarVoucher(string vou) {

            VoucherNegocio vc = new VoucherNegocio();
            bool aux = false;

           List<Voucher> ListaVoucher=vc.Listar();

            foreach (Voucher v in ListaVoucher) {
                

                if (v.CodigoVoucher_V == vou) {

                    if (v.idCliente_V == null && v.IdArticulo_V==null) {
                        
                            aux = true;
                            break;
                        

                    }

                }


            }



            return aux;

        }

    }
}