using ComputerDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBss
{
    public  class ComputadoraBss
    {
        ComputerDal dal = new ComputerDal();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputerDal();
        }
    }
}
