using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.GUI
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataManager.GUI.Registros f = new DataManager.GUI.Registros();
            f.Show();
        }
    }
}
