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
    public partial class Login : Form
    {
        String _Usuario = "DCeren";
        String _Clave = "Hola123";
        Boolean _Validacion = false;

        public bool Validacion 
        { 
            get => _Validacion; 
        }

        private void Validar()
        {
            try
            {
                if(txbUsuario.Text.Equals(_Usuario) && txbClave.Text.Equals(_Clave))
                {
                    _Validacion = true;
                    Close();
                }
                else
                {
                    lblMensaje.Text = "CREDENCIALES INCORRECTAS, VUELVA A INTENTARLO"; 
                }
            }
            catch
            {
                _Validacion = false;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
