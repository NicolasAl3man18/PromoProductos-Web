using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Imagen
    {
        public int Id_Imangen { get; set; }
        public int IdArticulo_Imagen { get; set; }
        public string Url_Imagen { get; set; }


        public override string ToString()
        {
            return Url_Imagen;
        }


    }
}
