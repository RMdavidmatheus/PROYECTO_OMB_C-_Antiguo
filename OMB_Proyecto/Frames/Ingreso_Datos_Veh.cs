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
    public partial class Ingreso_Datos_Veh : Form
    {
        Calendario CalendarioVEH = new Calendario();
        Metodos.MetodosCRUD Metodos = new Metodos.MetodosCRUD();
        
       

        public Ingreso_Datos_Veh(string DatoNP)
        {
            InitializeComponent();
            Modelo.Format = DateTimePickerFormat.Custom;
            Modelo.CustomFormat = "yyyy";
            Modelo.ShowUpDown = true;
            DatoNumeroPoliza = DatoNP;
        }

       string DatoNumeroPoliza;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        private void FechaVeh_Click(object sender, EventArgs e)
        {
            CalendarioVEH.ShowDialog();
            CalendarioVEH.MandarFechas(SOAT_Vigencia);
        }

        private void GuardarVeh_Click(object sender, EventArgs e)
        {
            if (Placa.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una Placa","ERROR");
            }
            else if (Modelo.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Modelo de auto","ERROR");
            }
            else if (Fasecolda.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Fasecolda","ERROR");
            }
            else if (Servicio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Servicio del auto","ERROR");
            }
            else if (Clase.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la Clase del auto","ERROR");
            }
            else if (Marca.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una Marca","ERROR");
            }
            else if (SOAT_Vigencia.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una Vigencia del SOAT","ERROR");
            }
            else
            {
                //INGRESANDO DATOS DEL VEHICULO

               
                string query = "insert into vehiculo (vehPlaca,vehModelo,vehFasecolda,vehServicio,vehClase,vehMarca,vehVigenciaSOAT)" +
                    " values('"+Placa.Text+"','"+Modelo.Text+"','"+Fasecolda.Text+"','"+Servicio.Text+"','"+Clase.Text+"','"+Marca.Text+"','"+SOAT_Vigencia.Text+"')";
                if (Metodos.Insertar_Datos_Poliza_General(query))
                {
                    
                    MessageBox.Show("Vehiculo guardado correctamente","EXITOSO");

                    string query2 = "insert into pol_veh(poliza_pol_NumeroPoliza,vehiculo_vehPlaca) values('"+DatoNumeroPoliza+"','"+Placa.Text+"')";

                    Metodos.Insertar_Datos_Poliza_General(query2);

                    MessageBox.Show("Relacion con Poliza satisfactoria", "EXITOSO");
                    this.Dispose();
                    
                }
                else
                {
                    MessageBox.Show("Error al guardar datos del vehiculo","ERROR");
                }                
                
                
            }
        }

        private void Ingreso_Datos_Veh_Load(object sender, EventArgs e)
        {
            
        }

        private void Placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.AlphaNumerico(e);
        }

        private void Fasecolda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void Servicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void Clase_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void Marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Fasecolda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
