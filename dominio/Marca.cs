using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {

        public int Id_Marca{ get; set; }

        public string Descripcion_Marca { get; set; }
        public override string ToString()
        {
            return Descripcion_Marca;
        }



    }
}
