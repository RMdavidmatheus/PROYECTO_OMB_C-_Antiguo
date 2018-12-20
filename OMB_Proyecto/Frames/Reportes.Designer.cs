namespace OMB_Proyecto.Frames
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.PolVig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsuLog = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MesTim = new System.Windows.Forms.Label();
            this.Mostrar_Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PolVig
            // 
            this.PolVig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PolVig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PolVig.FlatAppearance.BorderSize = 0;
            this.PolVig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PolVig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.PolVig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolVig.Font = new System.Drawing.Font("Decker", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolVig.Image = ((System.Drawing.Image)(resources.GetObject("PolVig.Image")));
            this.PolVig.Location = new System.Drawing.Point(13, 12);
            this.PolVig.Name = "PolVig";
            this.PolVig.Size = new System.Drawing.Size(330, 491);
            this.PolVig.TabIndex = 0;
            this.PolVig.Text = "Vigencia Polizas";
            this.PolVig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PolVig.UseVisualStyleBackColor = true;
            this.PolVig.Click += new System.EventHandler(this.PolVig_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Decker", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(469, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 491);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vigencia SOATS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Decker", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(939, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 491);
            this.button2.TabIndex = 2;
            this.button2.Text = "Polizas Inactivas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PolVig);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 602);
            this.panel1.TabIndex = 3;
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
            this.panel2.Location = new System.Drawing.Point(-7, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 101);
            this.panel2.TabIndex = 9;
            // 
            // UsuLog
            // 
            this.UsuLog.AutoSize = true;
            this.UsuLog.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuLog.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UsuLog.Location = new System.Drawing.Point(100, 23);
            this.UsuLog.Name = "UsuLog";
            this.UsuLog.Size = new System.Drawing.Size(316, 58);
            this.UsuLog.TabIndex = 8;
            this.UsuLog.Text = "Administrador/Vendedor";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 12);
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
            this.MesTim.Location = new System.Drawing.Point(1047, 59);
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
            this.Mostrar_Hora.Location = new System.Drawing.Point(1043, 20);
            this.Mostrar_Hora.Name = "Mostrar_Hora";
            this.Mostrar_Hora.Size = new System.Drawing.Size(106, 39);
            this.Mostrar_Hora.TabIndex = 5;
            this.Mostrar_Hora.Text = "label1";
            this.Mostrar_Hora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1280, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PolVig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UsuLog;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label MesTim;
        private System.Windows.Forms.Label Mostrar_Hora;
        private System.Windows.Forms.Timer timer1;
    }
}