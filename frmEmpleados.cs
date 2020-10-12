using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerecicio2
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            lstEmpleados.Items.Add("Juan");
            lstEmpleados.Items.Add("Maria");
            lstSueldos.Items.Add(30000);
            lstSueldos.Items.Add(40000);

        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<lstEmpleados.Items.Count;i++)
            {
                lstNeto.Items.Add( Convert.ToDouble(lstSueldos.Items[i]) * 1.25);
            }
        }
    }
}
