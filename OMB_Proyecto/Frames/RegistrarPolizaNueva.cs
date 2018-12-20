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
    public partial class RegistroPoliza : Form
    {
        Metodos.MetodosCRUD metodos = new Metodos.MetodosCRUD();
        Calendario calendarioTOM = new Calendario();
        Calendario calendarioBEN = new Calendario();
        Calendario calendarioPOL = new Calendario();

        public RegistroPoliza()
        {
            InitializeComponent();
           
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        string daton;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NacimientoBen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Documento","ERROR");
                
            }
            else if (TipoDocTom.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese un Tipo de documento","ERROR");
            }
            else if(NombresTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Nombre","ERROR");
            }
            else if(ApellidosTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Apellido");
            }
            else if(DireccionTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una Direccion","ERROR");

            }
            else if(TelefonoTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Telefono","ERROR");

            }
            else if(FechaNATOM.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una Fecha de nacimiento","ERROR");

            }
            else
            {

                //INSERTANDO DATOS TOM

                string DatosDocTP_Tom = TipoDocTom.SelectedItem.ToString();

                string query = "insert into tomador (tomDocumento,tomTipoDocumento,tomNombres,tomApellidos,tomDireccion,tomTelefono,tomEmail,tomFechaNacimiento) " +
                    "values ('"+DocTom.Text+"','"+DatosDocTP_Tom+"','"+NombresTom.Text+"','"+ApellidosTom.Text+"','"+DireccionTom.Text+"','"+TelefonoTom.Text+"','"+EmailTom.Text+"','"+FechaNATOM.Text+"')";
                if (metodos.Insertar_Datos_Poliza_General(query))
                {
                    MessageBox.Show("Agregado a Tomadores","EXITOSO");
                }
                else
                {
                    MessageBox.Show("Error al agregar tomador","ERROR");
                }




            }
            
        }

        private void FechaTom_Click(object sender, EventArgs e)
        {
            
            calendarioTOM.ShowDialog();
            calendarioTOM.MandarFechas(FechaNATOM);
            
        }

        private void FechaBen_Click(object sender, EventArgs e)
        {
            calendarioBEN.ShowDialog();
            calendarioBEN.MandarFechas(NacimientoBen); 
        }

        private void GurdarBen_Click(object sender, EventArgs e)
        {
            if (DocBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un documento", "ERROR");
            }
            else if(TipoDocBen.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese un Tipo de documento", "ERROR");
            }
            else if(NombresBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else if(ApellidosBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un apellido", "ERROR");
            }
            else if(DireccionBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una direccion", "ERROR");
            }
            else if(TelefonoBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un telefono", "ERROR");
            }
            else if(NacimientoBen.Text.Equals(""))
            {
                MessageBox.Show("eliga una fecha de nacimiento", "ERROR");
            }
            else
            {
                // INGRESANDO BENEFICIARIO

                string DatoTP_Docben = TipoDocBen.SelectedItem.ToString();

                string query = "insert into beneficiario(benDocumento,benTipoDoc,benNombres,benApellidos,benDireccion,benTelefono,benEmail,benFechaNacimiento)" +
                    "values ('"+DocBen.Text+"','"+DatoTP_Docben+"','"+NombresBen.Text+"','"+ApellidosBen.Text+"','"+DireccionBen.Text+"','"+TelefonoBen.Text+"','"+EmailBen.Text+"','"+NacimientoBen.Text+"')";
                if (metodos.Insertar_Datos_Poliza_General(query))
                {
                    MessageBox.Show("Agregado a beneficiario","EXITOSO");
                }
                else
                {
                    MessageBox.Show("Error al agregar beneficiario", "ERROR");
                }
            }
            
        }

        

        private void GuardarPoliza_Click(object sender, EventArgs e)
        {
            if (TipoPoliza.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese un Tipo de poliza", "ERROR");
            }
            else if (Aseguradora.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese una aseguradora", "ERROR");
            }
            
            else if (NumeroPoliza.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Numero de poliza", "ERROR");
            }
            else if (Estado.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese un Estado de poliza", "ERROR");
            }
            else if (txtVigencia.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una Fecha de vigencia", "ERROR");
            }
            else
            {
                // INGRESANDO POLIZA
                int ComboboxCorrectoTP = TipoPoliza.SelectedIndex + 1;
                string DatosTP = ComboboxCorrectoTP.ToString();

                int ComboboxCorrectoAse = Aseguradora.SelectedIndex + 1;
                string DatosAse = ComboboxCorrectoAse.ToString();

                string DatoEstado = Estado.SelectedItem.ToString();
                


                string query = "insert into poliza(pol_NumeroPoliza,tipo_poliza_tipIdRamo,aseguradora_aseId,tomador_tomDocumento,beneficiario_benDocumento,polEstado,polVigencia)" +
                    " values('"+NumeroPoliza.Text+"','"+DatosTP+"','"+DatosAse+"','"+DocTom.Text+"','"+DocBen.Text+"','"+DatoEstado+"','"+txtVigencia.Text+"')";
                if (metodos.Insertar_Datos_Poliza_General(query))
                {
                    MessageBox.Show("Poliza Agregada correctamente","EXITOSO");
                                                
                    
                    if (TipoPoliza.SelectedItem.Equals("AUTOS"))
                    {
                        
                        daton = NumeroPoliza.Text;
                        Ingreso_Datos_Veh veh = new Ingreso_Datos_Veh(daton);                       
                        veh.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        this.Dispose();
                    }
                   


                }
                else
                {
                    MessageBox.Show("Error al ingresar Poliza", "ERROR");
                }
            }
        }

        private void Poliza_Click(object sender, EventArgs e)
        {

        }

        private void VigenciaCalendar_Click(object sender, EventArgs e)
        {
            calendarioPOL.ShowDialog();
            calendarioPOL.MandarFechas(txtVigencia);
           
            
        }

        private void ActualizarTom_Click(object sender, EventArgs e)
        {
            if (DocTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Documento", "ERROR");

            }
            else if (TipoDocTom.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese un Tipo de documento", "ERROR");
            }
            else if (NombresTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Nombre", "ERROR");
            }
            else if (ApellidosTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Apellido");
            }
            else if (DireccionTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una Direccion", "ERROR");

            }
            else if (TelefonoTom.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Telefono", "ERROR");

            }
            else if (FechaNATOM.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una Fecha de nacimiento", "ERROR");

            }
            else
            {

                //  ACTUALIZANDO TOMADOR

                string DatosDocTP_Tom = TipoDocTom.SelectedItem.ToString();

                string query = "update tomador set tomTipoDocumento='"+DatosDocTP_Tom+ "', tomNombres='"+NombresTom.Text+ "', tomApellidos='"+ApellidosTom.Text+ "', tomDireccion='"+DireccionTom.Text+ "', tomTelefono='"+TelefonoTom.Text+ "', tomEmail='" + EmailTom.Text+"', tomFechaNacimiento='"+FechaNATOM.Text+ "' WHERE tomDocumento='"+DocTom.Text+"'";
                    
                if (metodos.Insertar_Datos_Poliza_General(query))
                {
                    MessageBox.Show("Tomador Actualizado correctamente", "EXITOSO");                    
                }
                else
                {
                    MessageBox.Show("Error al Actualizar Tomador", "ERROR");
                }




            }
        }

        private void ActualizarBen_Click(object sender, EventArgs e)
        {
            if (DocBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un documento", "ERROR");
            }
            else if (TipoDocBen.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese un Tipo de documento", "ERROR");
            }
            else if (NombresBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else if (ApellidosBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un apellido", "ERROR");
            }
            else if (DireccionBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una direccion", "ERROR");
            }
            else if (TelefonoBen.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un telefono", "ERROR");
            }
            else if (NacimientoBen.Text.Equals(""))
            {
                MessageBox.Show("eliga una fecha de nacimiento", "ERROR");
            }
            else
            {
                //  ACTUALIZANDO BENEFICIARIO

                string DatoTP_Docben = TipoDocBen.SelectedItem.ToString();
                string query = "update beneficiario set benTipoDoc='" + DatoTP_Docben + "', benNombres='" + NombresBen.Text + "', benApellidos='" + ApellidosBen.Text + "', benDireccion='" + DireccionBen.Text + "', benTelefono='" + TelefonoBen.Text + "', benEmail='" + EmailBen.Text+"', benFechaNacimiento='" + NacimientoBen.Text + "' WHERE benDocumento='"+DocBen.Text+"'";
                if (metodos.Insertar_Datos_Poliza_General(query))
                {
                    MessageBox.Show("Beneficiario Actualizado correctamente", "EXITOSO");
                }
                else
                {
                    MessageBox.Show("Error al actualizar beneficiario", "ERROR");
                }
            }
        }

        private void Actualizar_Pol_Click(object sender, EventArgs e)
        {
            if (TipoPoliza.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese un Tipo de poliza", "ERROR");
            }
            else if (Aseguradora.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese una aseguradora", "ERROR");
            }

            else if (NumeroPoliza.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Numero de poliza", "ERROR");
            }
            else if (Estado.Text.Equals("--SELECCIONE--"))
            {
                MessageBox.Show("Ingrese un Estado de poliza", "ERROR");
            }
            else if (txtVigencia.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una Fecha de vigencia", "ERROR");
            }
            else
            {
                //  ACTUALIZANDO POLIZA
                int ComboboxCorrectoTP = TipoPoliza.SelectedIndex + 1;
                string DatosTP = ComboboxCorrectoTP.ToString();

                int ComboboxCorrectoAse = Aseguradora.SelectedIndex + 1;
                string DatosAse = ComboboxCorrectoAse.ToString();

                string DatoEstado = Estado.SelectedItem.ToString();


                string query = "update poliza set polEstado='" + DatoEstado + "', polVigencia='" + txtVigencia.Text + "' WHERE pol_NumeroPoliza='" + NumeroPoliza.Text + "'";

                if (metodos.Insertar_Datos_Poliza_General(query))
                {
                    MessageBox.Show("Poliza Actualizada correctamente", "EXITOSO");
                    this.Dispose();
                }
                
                else
                {
                    MessageBox.Show("Error al Actualizar Poliza", "ERROR");
                }
            }
        }

        private void DocTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloNumeros(e);
        }

        private void NombresTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloLetras(e);
        }

        private void ApellidosTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloLetras(e);
        }

        private void DireccionTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.AlphaNumerico(e);
        }

        private void TelefonoTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloNumeros(e);
        }

        private void DocBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloNumeros(e);
        }

        private void NombresBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloLetras(e);
        }

        private void ApellidosBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloLetras(e);
        }

        private void DireccionBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.AlphaNumerico(e);
        }

        private void TelefonoBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloNumeros(e);
        }

        private void NumeroPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloNumeros(e);
        }

        private void EmailBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.Email(e);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
