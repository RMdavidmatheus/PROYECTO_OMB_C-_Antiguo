using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_Proyecto.Metodos
{
    class Metodos_Diseño
    {
        public void Abrir_Formulario_En_Panel(Panel Panel_Receptor ,object Formulario_Hijo)
        {
            
            
            if (Panel_Receptor.Controls.Count > 0)
            {
                Panel_Receptor.Controls.RemoveAt(0);
                Form fh = Formulario_Hijo as Form;

                if (fh.Visible==true)
                {
                    fh.BringToFront();
                }
                else
                {
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    Panel_Receptor.Controls.Add(fh);
                    Panel_Receptor.Tag = fh;
                    fh.Show();
                }
                
            }
        }

        public void colorFila(DataGridView datagrid)
        {
            foreach (DataGridViewRow row in datagrid.Rows)
            {
                if (Convert.ToString(datagrid.Rows[row.Index].Cells[14].Value)=="INACTIVO")
                {
                    MessageBox.Show(datagrid.Rows[row.Index].Cells[14].Value.ToString());

                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }

                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
                }
            }
        }
    }
}
