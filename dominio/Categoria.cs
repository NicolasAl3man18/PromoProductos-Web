using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        public int Id_Categoria { get; set; }
        public string Descripcion_Categoria { get; set; }

        public override string ToString()
        {
            return Descripcion_Categoria;
        }
    }
}
