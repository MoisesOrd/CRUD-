using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerDAL;
using ComputerModelos;
namespace ComputerBss
{
    public class ComputerBss
    {
        ComputerDal dal = new ComputerDal();
        public DataTable ListarComputerBss()
        {
            return dal.ListarComputerDal();
        }

        public void InsertarComputerBss(Computer computer)
        {
            dal.InsertarComputerDAL(computer);
        }
    }
}
