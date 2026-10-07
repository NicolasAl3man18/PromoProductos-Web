using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace dominio
{
    public class Articulo
    {
        public Articulo() { }
        
        public int Id_Articulo { get; set; }
        public string Codigo_Articulo { get; set; }
        public string Nombre_Articulo {  get; set; }
        public string Descripcion_Articulo {  get; set; }
        public Marca Marca_Articulo { get; set; }
        public Categoria Categoria_Articulo { get; set; }
        public decimal Precio_Articulo { get; set; }
        public override string ToString()
        {
            return $"Codigo: {Codigo_Articulo}, Nombre: {Nombre_Articulo}";
        }



    }

}
