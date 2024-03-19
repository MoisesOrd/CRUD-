using DAL;
using ComputerModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerDAL
{
    public class ComputerDal
    {
        public DataTable ListarComputerDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarComputerDAL(Computer computer)

        {
            string consulta = "insert into cliente values("+ "'" + computer.Nombre + "'," + computer.Descripcion + "'," + computer.Precio + "'," + computer.FechadeCreacion + ")";
            conexion.Ejecutar(consulta);
        }
    }
}
