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
    public partial class Reportes : Form
    {
        public Reportes(string Usuario)
        {
            InitializeComponent();
            TomarUsu = Usuario;
            UsuLog.Text = TomarUsu;
        }

        private string TomarUsu;

        private void button2_Click(object sender, EventArgs e)
        {
            Cancelaciones c = new Cancelaciones();
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VigenciaSOATS vs = new VigenciaSOATS();
            vs.ShowDialog();
        }

        private void PolVig_Click(object sender, EventArgs e)
        {
            VigenciaPolizas vp = new VigenciaPolizas();
            vp.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Mostrar_Hora.Text = DateTime.Now.ToLongTimeString();
            this.MesTim.Text = DateTime.Now.ToLongDateString();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
    }
}
