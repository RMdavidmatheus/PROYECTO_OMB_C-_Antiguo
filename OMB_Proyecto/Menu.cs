using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OMB_Proyecto
{
    public partial class Menu : Form
    {
        Metodos.Metodos_Diseño mt = new Metodos.Metodos_Diseño();

        public Menu(string Usuario)
        {
            InitializeComponent();
            TomarUsu = Usuario;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        int LX, LY;

        private string TomarUsu;

        private void Boton_Desplegar_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 253)
            {
                panel2.Width = 85;
            }
            else
                panel2.Width = 253;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;

            this.Size = new Size(1280, 600);
            this.Location = new Point(LX,LY);
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion","SALIR",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void Ingreso_Datos_Click(object sender, EventArgs e)
        {

            PanelSlide.Location = Ingreso_Datos.Location;
            PanelSlide.Height = Ingreso_Datos.Height;
            mt.Abrir_Formulario_En_Panel(PanelContenido, new Frames.Ingresar_Datos(TomarUsu));



        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            mt.Abrir_Formulario_En_Panel(PanelContenido,new Frames.InicioMenu(TomarUsu));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Mostrar_Hora.Text = DateTime.Now.ToLongTimeString();
            this.MesTim.Text = DateTime.Now.ToLongDateString();
        }

        private void Tomadores_Click(object sender, EventArgs e)
        {
            PanelSlide.Location = Tomadores.Location;
            PanelSlide.Height = Tomadores.Height;
            mt.Abrir_Formulario_En_Panel(PanelContenido, new Frames.Tomadores(TomarUsu));
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mt.Abrir_Formulario_En_Panel(PanelContenido, new Frames.InicioMenu(TomarUsu));
        }

        private void Beneficiarios_Click(object sender, EventArgs e)
        {

            PanelSlide.Location = Beneficiarios.Location;
            PanelSlide.Height = Beneficiarios.Height;
            mt.Abrir_Formulario_En_Panel(PanelContenido, new Frames.Beneficiarios(TomarUsu));
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            PanelSlide.Location = Reportes.Location;
            PanelSlide.Height = Reportes.Height;
            mt.Abrir_Formulario_En_Panel(PanelContenido, new Frames.Reportes(TomarUsu));
        }

        private void PanelContenido_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void CerrrarSesion_MouseHover(object sender, EventArgs e)
        {
            CerrrarSesion.Image = OMB_Proyecto.Properties.Resources._45___Shutdown_515;
        }

        private void CerrrarSesion_MouseLeave(object sender, EventArgs e)
        {
            CerrrarSesion.Image = OMB_Proyecto.Properties.Resources._45___Shutdown_516;
        }

        private void Help_MouseHover(object sender, EventArgs e)
        {
            Help.Image = OMB_Proyecto.Properties.Resources.maybe_12_513;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.Image = OMB_Proyecto.Properties.Resources.maybe_12_512;
        }

        private void WebLink_MouseHover(object sender, EventArgs e)
        {
            WebLink.Image = OMB_Proyecto.Properties.Resources.web2;
        }

        private void WebLink_MouseLeave(object sender, EventArgs e)
        {
            WebLink.Image = OMB_Proyecto.Properties.Resources.web1;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Interface grafica creada con el fin de brindar una solucion a la empresa OMB.", "ACERDA DE..", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CerrrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Frames.LogIn login2 = new Frames.LogIn();
            login2.Show();

        }

        private void WebLink_Click(object sender, EventArgs e)
        {
            var proceso = new ProcessStartInfo("iexplore.exe");
            proceso.Arguments = "https://www.provision.com.co/";
            Process.Start(proceso);
            
        }

        private void Maximizar2_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Restaurar.Visible = true;
            Maximizar.Visible = true;
        }

        private void Vehiculos_Click(object sender, EventArgs e)
        {
            PanelSlide.Location = Vehiculos.Location;
            PanelSlide.Height = Vehiculos.Height;
            mt.Abrir_Formulario_En_Panel(PanelContenido, new Frames.Vehiculos(TomarUsu));
        }

    }
}
