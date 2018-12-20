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
    public partial class Vehiculos : Form
    {
        Metodos.MetodosCRUD db = new Metodos.MetodosCRUD();
        public Vehiculos(string Usuario)
        {
            InitializeComponent();
            TablaPol_Veh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TomarUsu = Usuario;
            UsuLog.Text = TomarUsu;
        }

        private string TomarUsu;

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            db.LlenarTabla_Vehiculos(TablaPol_Veh);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Mostrar_Hora.Text = DateTime.Now.ToLongTimeString();
            this.MesTim.Text = DateTime.Now.ToLongDateString();
        }

        private void BuscarTomador_Enter(object sender, EventArgs e)
        {
            if (BuscarTomador.Text == "BUSCAR")
            {
                BuscarTomador.Text = "";
                BuscarTomador.ForeColor = Color.DimGray;
            }
        }

        private void BuscarTomador_Leave(object sender, EventArgs e)
        {
            if (BuscarTomador.Text != "BUSCAR")
            {
                BuscarTomador.Text = "BUSCAR";
                BuscarTomador.ForeColor = Color.DimGray;
            }
        }

        private void BuscarTomador_KeyUp(object sender, KeyEventArgs e)
        {
            db.Buscar_Vehiculo(TablaPol_Veh, BuscarTomador.Text);
        }
    }
}
