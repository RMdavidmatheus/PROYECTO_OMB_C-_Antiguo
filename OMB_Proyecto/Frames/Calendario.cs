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
    public partial class Calendario : Form

    {
        

        public Calendario()
        {
            InitializeComponent();
            Calendar.Format = DateTimePickerFormat.Custom;
            Calendar.CustomFormat = "dd/mm/yyyy";
        }
        
        private void GuardarFormato_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Se guardo la fecha correctamente");
            this.Close();            
            
            
        }
        public void MandarFechas(TextBox receptor)
        {
            receptor.Clear();
            receptor.AppendText(Calendar.Text);
        }
        private void Receptor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
