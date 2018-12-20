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
    public partial class Ingresar_Datos : Form
    {
        Metodos.MetodosCRUD db = new Metodos.MetodosCRUD();
        Metodos.Metodos_Diseño pintar = new Metodos.Metodos_Diseño();

        public Ingresar_Datos(string Usuario)
        {
            InitializeComponent();
            TablaPoliza.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TomarUsu = Usuario;
            UsuLog.Text = TomarUsu;
        }

        string placa;
        string DocumentoBen;
        string DocumentoTom;
        private string TomarUsu;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            DocumentoBen = TablaPoliza.CurrentRow.Cells[9].Value.ToString();
            DocumentoTom = TablaPoliza.CurrentRow.Cells[5].Value.ToString();

            // SI ES POLIZA DE AUTOS
            if (TablaPoliza.CurrentRow.Cells[2].Value.ToString().Equals("AUTOS"))
            {
                
               DataTable dt5 = db.Extraer_Pol_Veh(TablaPoliza.CurrentRow.Cells[0].Value.ToString());
                if (dt5.Rows.Count >0)
                {
                    DataRow row = dt5.Rows[0];
                    placa = Convert.ToString(row["vehiculo_vehPlaca"]);
                    
                }
                
                //ELIMINANDO RELACION POL_VEH
                string query = "DELETE FROM pol_veh WHERE  poliza_pol_NumeroPoliza='" + TablaPoliza.CurrentRow.Cells[0].Value.ToString() + "' AND vehiculo_vehPlaca='" + placa + "' ";
                if (db.Eliminar_Datos(query))
                {
                    MessageBox.Show("Relacion Poliza-Vehiculo Eliminada Correctamente");
                    db.LlenarTabla(TablaPoliza);
                    
                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Relacion");
                    db.LlenarTabla(TablaPoliza);
                    
                }
                // ELIMINANDO VEHICULO
                string queryVeh = "DELETE FROM vehiculo WHERE vehPlaca='"+placa+"' ";
                if (db.Eliminar_Datos(queryVeh))
                {
                    MessageBox.Show("Vehiculo Eliminado Correctamente");
                    db.LlenarTabla(TablaPoliza);
                    
                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Vehiculo");
                    db.LlenarTabla(TablaPoliza);
                    
                }
                
                //ELIMINANDO POLIZA
                string querypol = "DELETE FROM poliza WHERE  pol_NumeroPoliza='" + TablaPoliza.CurrentRow.Cells[0].Value.ToString() + "' AND tipo_poliza_tipIdRamo='"+ TablaPoliza.CurrentRow.Cells[1].Value.ToString() + "' AND aseguradora_aseId='"+ TablaPoliza.CurrentRow.Cells[3].Value.ToString() + "' AND tomador_tomDocumento='"+ TablaPoliza.CurrentRow.Cells[5].Value.ToString() + "' AND beneficiario_benDocumento='"+ TablaPoliza.CurrentRow.Cells[9].Value.ToString() + "' ";
                if (db.Eliminar_Datos(querypol))
                {
                    MessageBox.Show("Poliza Eliminada Correctamente");
                    db.LlenarTabla(TablaPoliza);
                    

                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Poliza");
                    db.LlenarTabla(TablaPoliza);
                    
                }

                //ELIMINANDO TOMADOR
                string querytom = "DELETE FROM tomador WHERE  tomDocumento= '"+ DocumentoTom + "'    ";
                if (db.Eliminar_Datos(querytom))
                {
                    MessageBox.Show("Tomador Eliminado Correctamente");
                    db.LlenarTabla(TablaPoliza);
                    DocumentoTom = "";
                    
                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Tomador");
                    db.LlenarTabla(TablaPoliza);
                   
                }

                //ELIMINANDO BENEFICIARIO
                string queryben = "DELETE FROM beneficiario WHERE  benDocumento= '"+ DocumentoBen + "'   ";
                if (db.Eliminar_Datos(queryben))
                {
                    MessageBox.Show("Beneficiario Eliminado Correctamente");
                    db.LlenarTabla(TablaPoliza);
                    DocumentoBen = "";
                    
                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Beneficiario");
                    db.LlenarTabla(TablaPoliza);
                    
                }

            }
            else
            {
                    //ELIMINANDO POLIZA
                    string querypol = "DELETE FROM poliza WHERE  pol_NumeroPoliza='" + TablaPoliza.CurrentRow.Cells[0].Value.ToString() + "' AND tipo_poliza_tipIdRamo='" + TablaPoliza.CurrentRow.Cells[1].Value.ToString() + "' AND aseguradora_aseId='" + TablaPoliza.CurrentRow.Cells[3].Value.ToString() + "' AND tomador_tomDocumento='" + TablaPoliza.CurrentRow.Cells[5].Value.ToString() + "' AND beneficiario_benDocumento='" + TablaPoliza.CurrentRow.Cells[9].Value.ToString() + "' ";
                    if (db.Eliminar_Datos(querypol))
                    {
                        MessageBox.Show("Poliza Eliminada Correctamente");
                        db.LlenarTabla(TablaPoliza);
                    

                }
                    else
                    {
                        MessageBox.Show("ERROR al eliminar Poliza");
                        db.LlenarTabla(TablaPoliza);
                    
                }

                    //ELIMINANDO TOMADOR
                    string querytom = "DELETE FROM tomador WHERE  tomDocumento= '" + DocumentoTom + "'    ";
                    if (db.Eliminar_Datos(querytom))
                    {
                        MessageBox.Show("Tomador Eliminado Correctamente");
                        db.LlenarTabla(TablaPoliza);
                        DocumentoTom = "";
                         
                }
                    else
                    {
                        MessageBox.Show("ERROR al eliminar Tomador");
                        db.LlenarTabla(TablaPoliza);
                       
                }

                    //ELIMINANDO BENEFICIARIO
                    string queryben = "DELETE FROM beneficiario WHERE  benDocumento= '" + DocumentoBen + "'   ";
                    if (db.Eliminar_Datos(queryben))
                    {
                        MessageBox.Show("Beneficiario Eliminado Correctamente");
                        db.LlenarTabla(TablaPoliza);
                        
                        DocumentoBen = "";
                    }
                    else
                    {
                        MessageBox.Show("ERROR al eliminar Beneficiarip");
                        db.LlenarTabla(TablaPoliza);
                       
                }
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (TablaPoliza.SelectedRows.Count > 0) 
            {
                // OCULTANDO BOTON GUARDAR
                RegistroPoliza actualizar = new RegistroPoliza();
                actualizar.GuardarPoliza.Visible = false;
                actualizar.GuardarTom.Visible = false;
                actualizar.GuardarBen.Visible = false;
                actualizar.DocBen.Enabled = false;
                actualizar.DocTom.Enabled = false;
                actualizar.NumeroPoliza.Enabled = false;
                actualizar.TipoPoliza.Enabled = false;
                actualizar.Aseguradora.Enabled = false;

                // LLENANDO DATOS A ACTUALIZAR UNA VEZ SELECCIONAMOS REGISTRO

                actualizar.DocTom.Text = TablaPoliza.CurrentRow.Cells[5].Value.ToString();
                actualizar.TipoDocTom.Text = TablaPoliza.CurrentRow.Cells[6].Value.ToString();
                actualizar.TelefonoTom.Text = TablaPoliza.CurrentRow.Cells[8].Value.ToString();
                actualizar.DocBen.Text = TablaPoliza.CurrentRow.Cells[9].Value.ToString();
                actualizar.TipoDocBen.Text = TablaPoliza.CurrentRow.Cells[10].Value.ToString();
                actualizar.TelefonoBen.Text = TablaPoliza.CurrentRow.Cells[12].Value.ToString();
                actualizar.NumeroPoliza.Text = TablaPoliza.CurrentRow.Cells[0].Value.ToString();
                actualizar.TipoPoliza.Text = TablaPoliza.CurrentRow.Cells[2].Value.ToString();
                actualizar.Aseguradora.Text = TablaPoliza.CurrentRow.Cells[4].Value.ToString();
                actualizar.Estado.Text = TablaPoliza.CurrentRow.Cells[14].Value.ToString();

                

                //EXTRAYENDO DATOS DESDE SQL QUE NO ESTAN EN LA TABLA PARA MOSTRARLOS A LA HORA DE ACTUALIZAR

                DataTable dt2 = db.Extraer_Tom(actualizar.DocTom.Text);
                if (dt2.Rows.Count > 0)
                {
                    DataRow row = dt2.Rows[0];
                    actualizar.NombresTom.Text = Convert.ToString(row["tomNombres"]);
                    actualizar.ApellidosTom.Text = Convert.ToString(row["tomApellidos"]);
                    actualizar.DireccionTom.Text = Convert.ToString(row["tomDireccion"]);
                    actualizar.EmailTom.Text = Convert.ToString(row["tomEmail"]);
                    // CONVIRTIENDO A FORMATO DE FECHA CORRECTO
                    actualizar.FechaNATOM.Text = Convert.ToDateTime(row["tomFechaNacimiento"]).ToString("yyyy-MM-dd");
                }

                DataTable dt3 = db.Extraer_Ben(actualizar.DocBen.Text);
                if (dt3.Rows.Count > 0)
                {
                    DataRow row = dt3.Rows[0];
                    actualizar.NombresBen.Text = Convert.ToString(row["benNombres"]);
                    actualizar.ApellidosBen.Text = Convert.ToString(row["benApellidos"]);
                    actualizar.DireccionBen.Text = Convert.ToString(row["benDireccion"]);
                    actualizar.EmailBen.Text = Convert.ToString(row["benEmail"]);
                    // CONVIRTIENDO A FORMATO DE FECHA CORRECTO
                    actualizar.NacimientoBen.Text = Convert.ToDateTime(row["benFechaNacimiento"]).ToString("yyyy-MM-dd");
                }

                DataTable dt4 = db.Extraer_Pol(actualizar.NumeroPoliza.Text);
                if (dt4.Rows.Count > 0)
                {
                    DataRow row = dt4.Rows[0];
                    // CONVIRTIENDO A FORMATO DE FECHA CORRECTO
                    actualizar.txtVigencia.Text = Convert.ToDateTime(row["polVigencia"]).ToString("yyyy-MM-dd");
                }

                actualizar.ShowDialog();
                if (actualizar.IsDisposed == true)
                {
                    db.LlenarTabla(TablaPoliza);
                    
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UNA COLUMNA");
            }
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            // OCULTANDO BOTON ACTUALIZAR
            RegistroPoliza RegistrarPoliza = new RegistroPoliza();
            RegistrarPoliza.Actualizar_Pol.Visible = false;
            RegistrarPoliza.ActualizarBen.Visible = false;
            RegistrarPoliza.ActualizarTom.Visible = false;
            RegistrarPoliza.ShowDialog();
            if (RegistrarPoliza.IsDisposed == true)
            {
                db.LlenarTabla(TablaPoliza);
                

            }
        }

        private void Ingresar_Datos_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            db.LlenarTabla(TablaPoliza);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Mostrar_Hora.Text = DateTime.Now.ToLongTimeString();
            this.MesTim.Text = DateTime.Now.ToLongDateString();
        }

        private void BuscarPoliza_Enter(object sender, EventArgs e)
        {
            if (BuscarPoliza.Text == "BUSCAR")
            {
                BuscarPoliza.Text = "";
                BuscarPoliza.ForeColor = Color.DimGray;
            }

        }

        private void BuscarPoliza_Leave(object sender, EventArgs e)
        {
            if (BuscarPoliza.Text != "BUSCAR")
            {
                BuscarPoliza.Text = "BUSCAR";
                BuscarPoliza.ForeColor = Color.DimGray;
            }
        }

        private void BuscarPoliza_KeyUp(object sender, KeyEventArgs e)
        {
            db.Buscar_Poliza(TablaPoliza, BuscarPoliza.Text);
        }

        private void Eliminar_Poliza_Click(object sender, EventArgs e)
        {
             // SI ES POLIZA DE AUTOS
            if (TablaPoliza.CurrentRow.Cells[2].Value.ToString().Equals("AUTOS"))
            {
                
               DataTable dt5 = db.Extraer_Pol_Veh(TablaPoliza.CurrentRow.Cells[0].Value.ToString());
                if (dt5.Rows.Count >0)
                {
                    DataRow row = dt5.Rows[0];
                    placa = Convert.ToString(row["vehiculo_vehPlaca"]);
                    
                }
                
                //ELIMINANDO RELACION POL_VEH
                string query = "DELETE FROM pol_veh WHERE  poliza_pol_NumeroPoliza='" + TablaPoliza.CurrentRow.Cells[0].Value.ToString() + "' AND vehiculo_vehPlaca='" + placa + "' ";
                if (db.Eliminar_Datos(query))
                {
                    MessageBox.Show("Relacion Poliza-Vehiculo Eliminada Correctamente");
                    db.LlenarTabla(TablaPoliza);
                    
                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Relacion");
                    db.LlenarTabla(TablaPoliza);
                    
                }
                // ELIMINANDO VEHICULO
                string queryVeh = "DELETE FROM vehiculo WHERE vehPlaca='"+placa+"' ";
                if (db.Eliminar_Datos(queryVeh))
                {
                    MessageBox.Show("Vehiculo Eliminado Correctamente");
                    db.LlenarTabla(TablaPoliza);
                    
                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Vehiculo");
                    db.LlenarTabla(TablaPoliza);
                    
                }
                
                //ELIMINANDO POLIZA
                string querypol = "DELETE FROM poliza WHERE  pol_NumeroPoliza='" + TablaPoliza.CurrentRow.Cells[0].Value.ToString() + "' AND tipo_poliza_tipIdRamo='"+ TablaPoliza.CurrentRow.Cells[1].Value.ToString() + "' AND aseguradora_aseId='"+ TablaPoliza.CurrentRow.Cells[3].Value.ToString() + "' AND tomador_tomDocumento='"+ TablaPoliza.CurrentRow.Cells[5].Value.ToString() + "' AND beneficiario_benDocumento='"+ TablaPoliza.CurrentRow.Cells[9].Value.ToString() + "' ";
                if (db.Eliminar_Datos(querypol))
                {
                    MessageBox.Show("Poliza Eliminada Correctamente");
                    db.LlenarTabla(TablaPoliza);
                    

                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Poliza");
                    db.LlenarTabla(TablaPoliza);
                    
                }


            }

            else
            {
                    //ELIMINANDO POLIZA
                    string querypol = "DELETE FROM poliza WHERE  pol_NumeroPoliza='" + TablaPoliza.CurrentRow.Cells[0].Value.ToString() + "' AND tipo_poliza_tipIdRamo='" + TablaPoliza.CurrentRow.Cells[1].Value.ToString() + "' AND aseguradora_aseId='" + TablaPoliza.CurrentRow.Cells[3].Value.ToString() + "' AND tomador_tomDocumento='" + TablaPoliza.CurrentRow.Cells[5].Value.ToString() + "' AND beneficiario_benDocumento='" + TablaPoliza.CurrentRow.Cells[9].Value.ToString() + "' ";
                    if (db.Eliminar_Datos(querypol))
                    {
                        MessageBox.Show("Poliza Eliminada Correctamente");
                        db.LlenarTabla(TablaPoliza);
                    

                }
                    else
                    {
                        MessageBox.Show("ERROR al eliminar Poliza");
                        db.LlenarTabla(TablaPoliza);
                    
                }

            }
        
        }


        private void TablaPoliza_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.TablaPoliza.Columns[e.ColumnIndex].Name=="Estado")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {

                    
                    if (e.Value.ToString().Equals("ACTIVO"))
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                            
                    }

                    if (e.Value.ToString().Equals("INACTIVO"))
                    {
                        e.CellStyle.BackColor = Color.IndianRed;
                    }

                    }
                }
                catch (Exception)
                {
                  
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TablaPoliza.CurrentRow.Cells[2].Value.ToString().Equals("AUTOS"))
            {

                DataTable dt5 = db.Extraer_Pol_Veh(TablaPoliza.CurrentRow.Cells[0].Value.ToString());
                if (dt5.Rows.Count > 0)
                {
                    DataRow row = dt5.Rows[0];
                    placa = Convert.ToString(row["vehiculo_vehPlaca"]);

                }

                //ELIMINANDO RELACION POL_VEH
                string query = "DELETE FROM pol_veh WHERE  poliza_pol_NumeroPoliza='" + TablaPoliza.CurrentRow.Cells[0].Value.ToString() + "' AND vehiculo_vehPlaca='" + placa + "' ";
                if (db.Eliminar_Datos(query))
                {
                    MessageBox.Show("Relacion Poliza-Vehiculo Eliminada Correctamente");
                    db.LlenarTabla(TablaPoliza);

                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Relacion");
                    db.LlenarTabla(TablaPoliza);

                }
                // ELIMINANDO VEHICULO
                string queryVeh = "DELETE FROM vehiculo WHERE vehPlaca='" + placa + "' ";
                if (db.Eliminar_Datos(queryVeh))
                {
                    MessageBox.Show("Vehiculo Eliminado Correctamente");
                    db.LlenarTabla(TablaPoliza);

                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Vehiculo");
                    db.LlenarTabla(TablaPoliza);

                }

                //ELIMINANDO POLIZA
                string querypol = "DELETE FROM poliza WHERE  pol_NumeroPoliza='" + TablaPoliza.CurrentRow.Cells[0].Value.ToString() + "' AND tipo_poliza_tipIdRamo='" + TablaPoliza.CurrentRow.Cells[1].Value.ToString() + "' AND aseguradora_aseId='" + TablaPoliza.CurrentRow.Cells[3].Value.ToString() + "' AND tomador_tomDocumento='" + TablaPoliza.CurrentRow.Cells[5].Value.ToString() + "' AND beneficiario_benDocumento='" + TablaPoliza.CurrentRow.Cells[9].Value.ToString() + "' ";
                if (db.Eliminar_Datos(querypol))
                {
                    MessageBox.Show("Poliza Eliminada Correctamente");
                    db.LlenarTabla(TablaPoliza);


                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Poliza");
                    db.LlenarTabla(TablaPoliza);

                }
            }
            else
            {
                //ELIMINANDO POLIZA
                string querypol = "DELETE FROM poliza WHERE  pol_NumeroPoliza='" + TablaPoliza.CurrentRow.Cells[0].Value.ToString() + "' AND tipo_poliza_tipIdRamo='" + TablaPoliza.CurrentRow.Cells[1].Value.ToString() + "' AND aseguradora_aseId='" + TablaPoliza.CurrentRow.Cells[3].Value.ToString() + "' AND tomador_tomDocumento='" + TablaPoliza.CurrentRow.Cells[5].Value.ToString() + "' AND beneficiario_benDocumento='" + TablaPoliza.CurrentRow.Cells[9].Value.ToString() + "' ";
                if (db.Eliminar_Datos(querypol))
                {
                    MessageBox.Show("Poliza Eliminada Correctamente");
                    db.LlenarTabla(TablaPoliza);


                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Poliza");
                    db.LlenarTabla(TablaPoliza);

                }
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
