namespace AdoNet
{
    partial class Form12EmpleadosHospital
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
            cmbHospitales = new ComboBox();
            label1 = new Label();
            txtSuma = new TextBox();
            txtMedia = new TextBox();
            txtPersonas = new TextBox();
            lstEmpleados = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSalario = new TextBox();
            txtOficio = new TextBox();
            SuspendLayout();
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(28, 46);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(121, 23);
            cmbHospitales.TabIndex = 0;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Hospitales";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(28, 118);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(121, 23);
            txtSuma.TabIndex = 2;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(28, 191);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(121, 23);
            txtMedia.TabIndex = 3;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(28, 275);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(121, 23);
            txtPersonas.TabIndex = 4;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(205, 55);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(184, 304);
            lstEmpleados.TabIndex = 5;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 100);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 162);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Media";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 257);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 28);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 10;
            label5.Text = "Empleados Hospital";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(411, 28);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Salario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 100);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 12;
            label7.Text = "Oficio";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(412, 55);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 13;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(411, 118);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 14;
            // 
            // Form12EmpleadosHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 384);
            Controls.Add(txtOficio);
            Controls.Add(txtSalario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstEmpleados);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(txtSuma);
            Controls.Add(label1);
            Controls.Add(cmbHospitales);
            Name = "Form12EmpleadosHospital";
            Text = "Form12EmpleadosHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbHospitales;
        private Label label1;
        private TextBox txtSuma;
        private TextBox txtMedia;
        private TextBox txtPersonas;
        private ListBox lstEmpleados;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSalario;
        private TextBox txtOficio;
    }
}