namespace OMB_Proyecto.Frames
{
    partial class VigenciaSOATS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VigenciaSOATS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Mostrar_Hora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MesTim = new System.Windows.Forms.Label();
            this.TablaVigSOAT = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Descargar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Seleccion = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVigSOAT)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Minimizar);
            this.panel3.Controls.Add(this.Maximizar);
            this.panel3.Controls.Add(this.Cerrar);
            this.panel3.Controls.Add(this.Restaurar);
            this.panel3.Location = new System.Drawing.Point(6, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1380, 57);
            this.panel3.TabIndex = 14;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Decker", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(556, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vigencias SOATS por mes";
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1273, 22);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(28, 27);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 12;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1307, 22);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(28, 27);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximizar.TabIndex = 11;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(1341, 22);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(28, 27);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 10;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1307, 22);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(28, 27);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 13;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Mostrar_Hora
            // 
            this.Mostrar_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mostrar_Hora.AutoSize = true;
            this.Mostrar_Hora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mostrar_Hora.Font = new System.Drawing.Font("Decker", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar_Hora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Mostrar_Hora.Location = new System.Drawing.Point(1092, 17);
            this.Mostrar_Hora.Name = "Mostrar_Hora";
            this.Mostrar_Hora.Size = new System.Drawing.Size(202, 39);
            this.Mostrar_Hora.TabIndex = 5;
            this.Mostrar_Hora.Text = "Mostrar_Hora";
            this.Mostrar_Hora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.MesTim);
            this.panel2.Controls.Add(this.Mostrar_Hora);
            this.panel2.Location = new System.Drawing.Point(6, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 90);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(270, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // MesTim
            // 
            this.MesTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MesTim.AutoSize = true;
            this.MesTim.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesTim.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MesTim.Location = new System.Drawing.Point(1096, 56);
            this.MesTim.Name = "MesTim";
            this.MesTim.Size = new System.Drawing.Size(49, 18);
            this.MesTim.TabIndex = 6;
            this.MesTim.Text = "label1";
            // 
            // TablaVigSOAT
            // 
            this.TablaVigSOAT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaVigSOAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaVigSOAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaVigSOAT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Decker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaVigSOAT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaVigSOAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Decker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaVigSOAT.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaVigSOAT.EnableHeadersVisualStyles = false;
            this.TablaVigSOAT.Location = new System.Drawing.Point(6, 147);
            this.TablaVigSOAT.Name = "TablaVigSOAT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaVigSOAT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaVigSOAT.Size = new System.Drawing.Size(1380, 419);
            this.TablaVigSOAT.TabIndex = 7;
            this.TablaVigSOAT.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TablaVigSOAT_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Descargar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.Seleccion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TablaVigSOAT);
            this.panel1.Location = new System.Drawing.Point(-16, -34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 662);
            this.panel1.TabIndex = 10;
            // 
            // Descargar
            // 
            this.Descargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Descargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Descargar.FlatAppearance.BorderSize = 0;
            this.Descargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Descargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Descargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Descargar.Font = new System.Drawing.Font("Decker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descargar.Image = ((System.Drawing.Image)(resources.GetObject("Descargar.Image")));
            this.Descargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Descargar.Location = new System.Drawing.Point(1099, 83);
            this.Descargar.Name = "Descargar";
            this.Descargar.Size = new System.Drawing.Size(272, 59);
            this.Descargar.TabIndex = 17;
            this.Descargar.Text = "Descargar";
            this.Descargar.UseVisualStyleBackColor = true;
            this.Descargar.Click += new System.EventHandler(this.Descargar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(581, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Font = new System.Drawing.Font("Decker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.DimGray;
            this.Buscar.Location = new System.Drawing.Point(625, 90);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(468, 40);
            this.Buscar.TabIndex = 15;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.Enter += new System.EventHandler(this.Buscar_Enter);
            this.Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyUp);
            this.Buscar.Leave += new System.EventHandler(this.Buscar_Leave);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Decker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.Location = new System.Drawing.Point(340, 89);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(217, 40);
            this.Search.TabIndex = 10;
            this.Search.Text = "Buscar por mes";
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Seleccion
            // 
            this.Seleccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Seleccion.Font = new System.Drawing.Font("Decker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seleccion.FormattingEnabled = true;
            this.Seleccion.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.Seleccion.Location = new System.Drawing.Point(20, 89);
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Size = new System.Drawing.Size(314, 40);
            this.Seleccion.TabIndex = 9;
            this.Seleccion.Text = "--SELECCIONE UN MES--";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VigenciaSOATS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1367, 627);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VigenciaSOATS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VigenciaSOATS";
            this.Load += new System.EventHandler(this.VigenciaSOATS_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVigSOAT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.Label Mostrar_Hora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label MesTim;
        public System.Windows.Forms.DataGridView TablaVigSOAT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox Seleccion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Button Descargar;
    }
}