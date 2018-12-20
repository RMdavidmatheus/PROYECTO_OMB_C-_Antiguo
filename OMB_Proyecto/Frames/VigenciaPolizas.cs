using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_Proyecto.Frames
{
    public partial class VigenciaPolizas : Form
    {

        Metodos.MetodosCRUD db = new Metodos.MetodosCRUD();
        public VigenciaPolizas()
        {
            InitializeComponent();
            TablaVigPol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        int LX, LY;

        private void VigenciaPolizas_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void Seleccion_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Seleccion_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Seleccion.SelectedIndex >= 0)
            {
                int selec = Seleccion.SelectedIndex + 1;
                db.LlenarTabla_VigPol(TablaVigPol, selec);
                selec = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Mostrar_Hora.Text = DateTime.Now.ToLongTimeString();
            this.MesTim.Text = DateTime.Now.ToLongDateString();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion", "SALIR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buscar_Enter(object sender, EventArgs e)
        {
            if (Buscar.Text == "BUSCAR")
            {
                Buscar.Text = "";
                Buscar.ForeColor = Color.DimGray;
            }
        }

        private void Buscar_Leave(object sender, EventArgs e)
        {
            if (Buscar.Text != "BUSCAR")
            {
                Buscar.Text = "BUSCAR";
                Buscar.ForeColor = Color.DimGray;
            }
        }

        private void Buscar_KeyUp(object sender, KeyEventArgs e)
        {
            db.Reporte_Vigencia_Poliza_Buscar(TablaVigPol,Buscar.Text);
        }

        private void TablaVigPol_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.TablaVigPol.Columns[e.ColumnIndex].Name == "Estado")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {


                        if (e.Value.ToString().Equals("ACTIVO"))
                        {
                            e.CellStyle.BackColor = Color.LightGreen;

                        }
                        else if (e.Value.ToString().Equals("INACTIVO"))
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

        private void Descargar_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(TablaVigPol.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in TablaVigPol.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in TablaVigPol.Rows)
            {
                try
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null)
                        {
                            pdfTable.AddCell(cell.Value.ToString());

                        }

                    }
                }
                catch (Exception)
                {


                }

            }

            //Exporting to PDF

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Reporte Vigencias Polizas";
            save.Filter = "PDF (*.pdf)|*.pdf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(save.FileName, FileMode.Create);

                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.AddTitle("REPORTE VIGENCIA POLIZAS ACTIVAS");
                pdfDoc.Add(new Paragraph("REPORTE VIGENCIAS DE POLIZAS ACTIVAS POR MES", FontFactory.GetFont("ARIAL", 30, iTextSharp.text.Font.BOLD)));
                pdfDoc.Add(new Paragraph("                          "));
                pdfDoc.Add(new Paragraph("" + Seleccion.SelectedItem.ToString() + "", FontFactory.GetFont("ARIAL", 18, iTextSharp.text.Font.UNDERLINE)));
                pdfDoc.Add(new Paragraph("                          "));
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(new Paragraph("FECHA REPORTE: ", FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.UNDERLINE)));
                pdfDoc.Add(new Paragraph("" + System.DateTime.Now + "", FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.NORMAL)));
                pdfDoc.Close();
                stream.Close();
            }

        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1367, 627);
            this.Location = new Point(LX, LY);
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }
    }
}
