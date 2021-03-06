﻿using System;
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
    public partial class Beneficiarios : Form
    {
        Metodos.MetodosCRUD db = new Metodos.MetodosCRUD();
        public Beneficiarios(string Usuario)
        {
            InitializeComponent();
            TablaBeneficiario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TomarUsu = Usuario;
            UsuLog.Text = TomarUsu;
        }

        private string TomarUsu;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Mostrar_Hora.Text = DateTime.Now.ToLongTimeString();
            this.MesTim.Text = DateTime.Now.ToLongDateString();
        }

        private void Beneficiarios_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            db.LlenarTabla_Beneficiarios(TablaBeneficiario);
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
            db.Buscar_Ben(TablaBeneficiario,BuscarTomador.Text);
        }
    }
}
