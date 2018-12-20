using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OMB_Proyecto.Frames
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Metodos.MetodosCRUD db = new Metodos.MetodosCRUD();
        
        private string usutxtBox;
        private string contxtBox;
        private string UsuarioBD;
        private string ContraseñaBD;
        public string TomarUsu;

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion", "SALIR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text=="USUARIO")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.LightGray;
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "USUARIO";
                Usuario.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "CONTRASEÑA")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = Color.LightGray;
                Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = "CONTRASEÑA";
                Contraseña.ForeColor = Color.DimGray;
                Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void Panel_Usu_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            usutxtBox = Usuario.Text;
            contxtBox = Contraseña.Text;

            if (Usuario.Text!="" || Contraseña.Text!="")
            {
                DataTable ValidarDato = db.Validar_Ingreso(usutxtBox,contxtBox);

                if (ValidarDato.Rows.Count > 0)
                {
                    DataRow row = ValidarDato.Rows[0];
                    UsuarioBD = Convert.ToString(row["Usuario"]);
                    ContraseñaBD = Convert.ToString(row["Contrasena"]);
                    
                }

                if (Usuario.Text.Equals(UsuarioBD) || Contraseña.Text.Equals(ContraseñaBD) )
                {
                    MessageBox.Show("Ingreso Extitoso","EXITOSO");

                    TomarUsu = UsuarioBD;
                    ContraseñaBD = "";
                    this.Hide();
                    Menu menu = new Menu(TomarUsu);
                    menu.Show();
                    UsuarioBD = "";
                    ContraseñaBD = "";
                }

                else if (Usuario.Text!=UsuarioBD || Contraseña.Text!=ContraseñaBD)
                {
                    Usuario.Text = "";
                    ErrorUsu.Text = "Error usuario";
                    Contraseña.Text = "";
                    ErrorCon.Text = "Error Contraseña";
                    
                }

                TomarUsu = "";
            }
        }
    }
}
