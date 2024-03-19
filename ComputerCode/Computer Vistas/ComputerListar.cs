using ComputerBss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Vistas
{
    public partial class ComputerListar : Form
    {
        public ComputerListar()
        {
            InitializeComponent();
        }
        ComputerBss bss = new ComputerBss();
        private void ComputerListar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarComputerBss();
        }
    }
}
