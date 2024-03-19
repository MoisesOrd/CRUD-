using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerModelos
{
    public class Computer
    {
        public int IdComputer { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public SqlMoney Precio { get; set; }
        public DateTime FechadeCreacion { get; set; }
    }
}
