using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotBA2GJv11
{
    public partial class frmRobot2GJv11 : Form
    {
        public frmRobot2GJv11()
        {
            InitializeComponent();
        }

        private void btoCargaMasivaEntidades_Click(object sender, EventArgs e)
        {
            OpcionesDeFormas.frmCargaDeEntidades objForm = new OpcionesDeFormas.frmCargaDeEntidades();
            objForm.Show();
        }
    }
}
