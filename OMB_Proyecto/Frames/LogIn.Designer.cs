namespace OMB_Proyecto.Frames
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel_Usu = new System.Windows.Forms.Panel();
            this.ErrorUsuCon = new System.Windows.Forms.Label();
            this.ErrorUsu = new System.Windows.Forms.Label();
            this.ErrorCon = new System.Windows.Forms.Label();
            this.Restablecer = new System.Windows.Forms.LinkLabel();
            this.Ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_Usu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelLogo.Controls.Add(this.pictureBox2);
            this.PanelLogo.Location = new System.Drawing.Point(-1, -6);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(273, 317);
            this.PanelLogo.TabIndex = 0;
            this.PanelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLogo_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Panel_Usu
            // 
            this.Panel_Usu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel_Usu.Controls.Add(this.ErrorUsuCon);
            this.Panel_Usu.Controls.Add(this.ErrorUsu);
            this.Panel_Usu.Controls.Add(this.ErrorCon);
            this.Panel_Usu.Controls.Add(this.Restablecer);
            this.Panel_Usu.Controls.Add(this.Ingresar);
            this.Panel_Usu.Controls.Add(this.label1);
            this.Panel_Usu.Controls.Add(this.Contraseña);
            this.Panel_Usu.Controls.Add(this.Usuario);
            this.Panel_Usu.Controls.Add(this.pictureBox1);
            this.Panel_Usu.Location = new System.Drawing.Point(275, 23);
            this.Panel_Usu.Name = "Panel_Usu";
            this.Panel_Usu.Size = new System.Drawing.Size(490, 288);
            this.Panel_Usu.TabIndex = 1;
            this.Panel_Usu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Usu_MouseDown);
            // 
            // ErrorUsuCon
            // 
            this.ErrorUsuCon.AutoSize = true;
            this.ErrorUsuCon.Font = new System.Drawing.Font("Decker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorUsuCon.ForeColor = System.Drawing.Color.Firebrick;
            this.ErrorUsuCon.Location = new System.Drawing.Point(87, 204);
            this.ErrorUsuCon.Name = "ErrorUsuCon";
            this.ErrorUsuCon.Size = new System.Drawing.Size(0, 14);
            this.ErrorUsuCon.TabIndex = 8;
            // 
            // ErrorUsu
            // 
            this.ErrorUsu.AutoSize = true;
            this.ErrorUsu.Font = new System.Drawing.Font("Decker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorUsu.ForeColor = System.Drawing.Color.Firebrick;
            this.ErrorUsu.Location = new System.Drawing.Point(28, 124);
            this.ErrorUsu.Name = "ErrorUsu";
            this.ErrorUsu.Size = new System.Drawing.Size(0, 14);
            this.ErrorUsu.TabIndex = 7;
            // 
            // ErrorCon
            // 
            this.ErrorCon.AutoSize = true;
            this.ErrorCon.Font = new System.Drawing.Font("Decker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorCon.ForeColor = System.Drawing.Color.Firebrick;
            this.ErrorCon.Location = new System.Drawing.Point(28, 194);
            this.ErrorCon.Name = "ErrorCon";
            this.ErrorCon.Size = new System.Drawing.Size(0, 14);
            this.ErrorCon.TabIndex = 6;
            // 
            // Restablecer
            // 
            this.Restablecer.ActiveLinkColor = System.Drawing.SystemColors.ScrollBar;
            this.Restablecer.AutoSize = true;
            this.Restablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restablecer.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restablecer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Restablecer.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Restablecer.Location = new System.Drawing.Point(161, 265);
            this.Restablecer.Name = "Restablecer";
            this.Restablecer.Size = new System.Drawing.Size(179, 18);
            this.Restablecer.TabIndex = 5;
            this.Restablecer.TabStop = true;
            this.Restablecer.Text = "¿Olvidaste tu contraseña?";
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ingresar.FlatAppearance.BorderSize = 0;
            this.Ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ingresar.Font = new System.Drawing.Font("Decker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ingresar.Location = new System.Drawing.Point(89, 221);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(329, 38);
            this.Ingresar.TabIndex = 4;
            this.Ingresar.Text = "ACCEDER";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Decker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Contraseña
            // 
            this.Contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contraseña.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contraseña.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.Contraseña.Location = new System.Drawing.Point(31, 159);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(434, 23);
            this.Contraseña.TabIndex = 2;
            this.Contraseña.Text = "CONTRASEÑA";
            this.Contraseña.Enter += new System.EventHandler(this.textBox1_Enter);
            this.Contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // Usuario
            // 
            this.Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Usuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.DimGray;
            this.Usuario.Location = new System.Drawing.Point(31, 90);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(434, 23);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "USUARIO";
            this.Usuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.Usuario.Leave += new System.EventHandler(this.Usuario_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-272, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(766, 295);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(423, 82);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(28, 27);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 14;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(459, 82);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(28, 27);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 13;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Location = new System.Drawing.Point(275, -80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 107);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(764, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Usu);
            this.Controls.Add(this.PanelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_Usu.ResumeLayout(false);
            this.Panel_Usu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel Panel_Usu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox Contraseña;
        public System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.LinkLabel Restablecer;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ErrorUsuCon;
        private System.Windows.Forms.Label ErrorUsu;
        private System.Windows.Forms.Label ErrorCon;
    }
}