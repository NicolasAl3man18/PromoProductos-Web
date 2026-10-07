using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    internal class Cliente
    {

        public Cliente() { }

        public int IdCliente_cli { get; }
        public string Documento_cli { get; set; }
        public string Nombre_cli { get; set; }
        public string Apellido_cli { get; set; }
        public string Email_cli { get; set; }
        public string Direccion_cli { get; set; }
        public string Ciudad_cli { get; set; }
        public int Cp_cli { get; set; }



    }
}
