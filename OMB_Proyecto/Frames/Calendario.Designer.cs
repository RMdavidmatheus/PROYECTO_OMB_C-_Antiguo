namespace OMB_Proyecto.Frames
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.DateTimePicker();
            this.GuardarFormato = new System.Windows.Forms.Button();
            this.Receptor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Decker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESNANDO FECHA";
            // 
            // Calendar
            // 
            this.Calendar.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.Calendar.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calendar.Font = new System.Drawing.Font("Decker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Calendar.Location = new System.Drawing.Point(56, 98);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(197, 40);
            this.Calendar.TabIndex = 1;
            // 
            // GuardarFormato
            // 
            this.GuardarFormato.Font = new System.Drawing.Font("Decker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarFormato.Location = new System.Drawing.Point(93, 155);
            this.GuardarFormato.Name = "GuardarFormato";
            this.GuardarFormato.Size = new System.Drawing.Size(126, 41);
            this.GuardarFormato.TabIndex = 2;
            this.GuardarFormato.Text = "Guardar";
            this.GuardarFormato.UseVisualStyleBackColor = true;
            this.GuardarFormato.Click += new System.EventHandler(this.GuardarFormato_Click);
            // 
            // Receptor
            // 
            this.Receptor.Enabled = false;
            this.Receptor.Font = new System.Drawing.Font("Decker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receptor.HideSelection = false;
            this.Receptor.Location = new System.Drawing.Point(56, 98);
            this.Receptor.Name = "Receptor";
            this.Receptor.Size = new System.Drawing.Size(197, 40);
            this.Receptor.TabIndex = 3;
            this.Receptor.TextChanged += new System.EventHandler(this.Receptor_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 161);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(289, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 160);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(3, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 10);
            this.panel4.TabIndex = 6;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(295, 216);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.Receptor);
            this.Controls.Add(this.GuardarFormato);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Calendar;
        private System.Windows.Forms.Button GuardarFormato;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Receptor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}