using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_Proyecto.Frames
{
    public partial class InicioMenu : Form
    {
        public InicioMenu(string Usuario)
        {
            InitializeComponent();
            TomarUsu = Usuario;
            UsuLog.Text = TomarUsu;
        }

        private string TomarUsu;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Mostrar_Hora.Text = DateTime.Now.ToLongTimeString();
            this.MesTim.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InicioMenu_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
    }
}
