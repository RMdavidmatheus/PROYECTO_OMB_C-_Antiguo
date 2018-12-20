using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace OMB_Proyecto.Metodos
{
    class MetodosCRUD
    {
        ConexionSQL bd = new ConexionSQL();

        public void LlenarTabla(DataGridView Llenar)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT* from vista_interface", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);                 
            }
            bd.DesconectarBase();
        }

        public void LlenarTabla_Tomadores(DataGridView Llenar)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM tom", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void LlenarTabla_Beneficiarios(DataGridView Llenar)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM ben", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void LlenarTabla_Vehiculos(DataGridView Llenar)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM polizasveh", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void LlenarTabla_VigPol(DataGridView Llenar,int SelectIndexMes)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM vigencia_polizas_activas vpa WHERE MONTH(vpa.`Fecha vencimiento Poliza`)="+SelectIndexMes+" AND vpa.Estado='ACTIVO'",bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void LlenarTabla_VigSOAT(DataGridView Llenar, int SelectIndexMes)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM vigencia_soat_mes vsm WHERE MONTH(vsm.`Fecha Vencimiento SOAT`)='"+SelectIndexMes+"'",bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void LlenarTabla_PolCancel(DataGridView Llenar, int SelectIndexMes)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM vigencia_polizas_activas vpa WHERE MONTH(vpa.`Fecha vencimiento Poliza`)="+SelectIndexMes+" AND vpa.Estado='INACTIVO'",bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void Buscar_Poliza(DataGridView Llenar,string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("select * from vista_interface vi where vi.`N.Poliza` LIKE '"+TextoBusqueda+"%' or vi.`Doc Tomador` LIKE '"+TextoBusqueda+"%' or vi.`Doc Beneficiario`LIKE '"+TextoBusqueda+ "%' OR vi.`Nombres Tomador` LIKE '"+TextoBusqueda+"%' OR vi.`Nombres Beneficiario` LIKE '"+TextoBusqueda+"%'", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void Buscar_Vehiculo(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM polizasveh pv WHERE pv.`N.Poliza` LIKE '"+TextoBusqueda+"%' or pv.`Documento Tomador` LIKE '"+TextoBusqueda+"%' OR pv.`Nombres Tomador` LIKE '"+TextoBusqueda+"%' or pv.Placa LIKE '"+TextoBusqueda+"%'", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void Buscar_Ben(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM ben b WHERE b.Documento  LIKE '"+TextoBusqueda+"%' OR b.Nombres LIKE '"+TextoBusqueda+"%' OR b.Apellidos LIKE '"+TextoBusqueda+"%'  ", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void Reporte_SOAT_Buscar(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("select * from vigencia_soat_mes vs where vs.Placa LIKE '"+TextoBusqueda+"%' OR vs.`N.Poliza` LIKE '"+TextoBusqueda+"%' OR vs.`Documento Tomador`LIKE '"+TextoBusqueda+ "%' OR vs.`Nombres Tomador` LIKE '" + TextoBusqueda+"%' ", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void Reporte_Vigencia_Poliza_Buscar(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM vigencia_polizas_activas vpa WHERE vpa.`Nombres Tomador` LIKE '"+TextoBusqueda+"%' OR vpa.`N.Poliza` LIKE '"+ TextoBusqueda + "%' OR vpa.`Documento Tomador` LIKE '"+ TextoBusqueda + "%' AND vpa.Estado='ACTIVO'", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public void Buscar_Tom(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM tom t WHERE t.Documento LIKE '" + TextoBusqueda+"%' OR t.Nombres LIKE '"+TextoBusqueda+"%' OR t.Apellidos LIKE '"+TextoBusqueda+"%' ", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }

        public bool Insertar_Datos_Poliza_General(string query)
        {
            bool Insertado = false;
            try
            {
                bd.ObtenerConexion();                
                int registros = 0;
                MySqlCommand sentencia = new MySqlCommand(query, bd.GetConnection());
                registros = sentencia.ExecuteNonQuery();
                if (registros > 0)
                {
                    Insertado = true;
                }
                
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
            return Insertado;




        }

        public bool Eliminar_Datos(string query)
        {
            bool Eliminado = false;
            try
            {
                bd.ObtenerConexion();
                int registros = 0;
                MySqlCommand sentencia = new MySqlCommand(query, bd.GetConnection());
                registros = sentencia.ExecuteNonQuery();
                if (registros > 0)
                {
                    Eliminado = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();

            return Eliminado;
        }

        public  DataTable Extraer_Tom(string tom)
        {
            //TOMANDO DATOS CONCRETOS DE TOMADOR

            DataTable dt = new DataTable();

            MySqlCommand query = new MySqlCommand("select tom.tomNombres,tom.tomApellidos,tom.tomDireccion,tom.tomEmail,tom.tomFechaNacimiento from tomador tom where tom.tomDocumento = '" + tom+"' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);
            

            return dt;
        }

        public  DataTable Extraer_Ben(string ben)
        {
            // TOMANDO DATOS CONCRETOS DE BENEFICIARIO
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("select ben.benNombres,ben.benApellidos,ben.benDireccion,ben.benEmail,ben.benFechaNacimiento from beneficiario ben where ben.benDocumento = '" + ben+"' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);
            

            return dt;
        }

        public DataTable Extraer_Pol(string Num_pol)
        {
            // TOMANDO DATOS CONCRETOS DE BENEFICIARIO
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("select p.polVigencia from poliza p where p.pol_NumeroPoliza = '" + Num_pol + "' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);

            
            return dt;
        }

        public DataTable Extraer_Pol_Veh(string Numero_Poliza)
        {
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("SELECT pv.vehiculo_vehPlaca FROM pol_veh pv where pv.poliza_pol_NumeroPoliza= '"+Numero_Poliza+"' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);

            
            return dt;
        }

        public void SoloLetras(KeyPressEventArgs ev)
        {
            if (Char.IsLetter(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if(Char.IsSeparator(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsControl(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }

        public void SoloNumeros(KeyPressEventArgs ev)
        {
            if (Char.IsNumber(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsSeparator(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsControl(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }

        public void AlphaNumerico(KeyPressEventArgs ev)
        {
            if (Char.IsLetterOrDigit(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsSeparator(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsControl(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }

        public void Email(KeyPressEventArgs ev)
        {
            if (Char.IsLetterOrDigit(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsSymbol(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsPunctuation(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsSeparator(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsControl(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }

        public DataTable Validar_Ingreso(string Usuario,string Contraseña)
        {
            // TOMANDO DATOS CONCRETOS DE USUARIOS
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("SELECT usu.Usuario, usu.Contrasena FROM usuarios usu WHERE usu.Usuario = '"+Usuario+"' AND usu.Contrasena= '"+Contraseña+"' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }

    }
}
