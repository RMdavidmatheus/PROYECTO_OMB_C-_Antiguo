namespace OMB_Proyecto.Frames
{
    partial class Tomadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tomadores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsuLog = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MesTim = new System.Windows.Forms.Label();
            this.Mostrar_Hora = new System.Windows.Forms.Label();
            this.BuscarTomador = new System.Windows.Forms.TextBox();
            this.TablaTomador = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTomador)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BuscarTomador);
            this.panel1.Controls.Add(this.TablaTomador);
            this.panel1.Location = new System.Drawing.Point(-9, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 666);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.UsuLog);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.MesTim);
            this.panel2.Controls.Add(this.Mostrar_Hora);
            this.panel2.Location = new System.Drawing.Point(6, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1383, 101);
            this.panel2.TabIndex = 8;
            // 
            // UsuLog
            // 
            this.UsuLog.AutoSize = true;
            this.UsuLog.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuLog.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UsuLog.Location = new System.Drawing.Point(94, 24);
            this.UsuLog.Name = "UsuLog";
            this.UsuLog.Size = new System.Drawing.Size(316, 58);
            this.UsuLog.TabIndex = 8;
            this.UsuLog.Text = "Administrador/Vendedor";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 76);
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
            this.MesTim.Location = new System.Drawing.Point(1133, 57);
            this.MesTim.Name = "MesTim";
            this.MesTim.Size = new System.Drawing.Size(49, 18);
            this.MesTim.TabIndex = 6;
            this.MesTim.Text = "label1";
            // 
            // Mostrar_Hora
            // 
            this.Mostrar_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mostrar_Hora.AutoSize = true;
            this.Mostrar_Hora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mostrar_Hora.Font = new System.Drawing.Font("Decker", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar_Hora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Mostrar_Hora.Location = new System.Drawing.Point(1129, 18);
            this.Mostrar_Hora.Name = "Mostrar_Hora";
            this.Mostrar_Hora.Size = new System.Drawing.Size(106, 39);
            this.Mostrar_Hora.TabIndex = 5;
            this.Mostrar_Hora.Text = "label1";
            this.Mostrar_Hora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BuscarTomador
            // 
            this.BuscarTomador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarTomador.Font = new System.Drawing.Font("Decker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarTomador.ForeColor = System.Drawing.Color.DimGray;
            this.BuscarTomador.Location = new System.Drawing.Point(81, 62);
            this.BuscarTomador.Name = "BuscarTomador";
            this.BuscarTomador.Size = new System.Drawing.Size(586, 33);
            this.BuscarTomador.TabIndex = 6;
            this.BuscarTomador.Text = "BUSCAR";
            this.BuscarTomador.Enter += new System.EventHandler(this.BuscarTomador_Enter);
            this.BuscarTomador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarTomador_KeyUp);
            this.BuscarTomador.Leave += new System.EventHandler(this.BuscarTomador_Leave);
            // 
            // TablaTomador
            // 
            this.TablaTomador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaTomador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaTomador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaTomador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Decker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaTomador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaTomador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Decker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaTomador.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaTomador.EnableHeadersVisualStyles = false;
            this.TablaTomador.Location = new System.Drawing.Point(6, 111);
            this.TablaTomador.Name = "TablaTomador";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaTomador.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaTomador.Size = new System.Drawing.Size(1377, 434);
            this.TablaTomador.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tomadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1373, 631);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tomadores";
            this.Text = "Tomadores";
            this.Load += new System.EventHandler(this.Tomadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTomador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UsuLog;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label MesTim;
        private System.Windows.Forms.Label Mostrar_Hora;
        public System.Windows.Forms.TextBox BuscarTomador;
        public System.Windows.Forms.DataGridView TablaTomador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}