namespace AdoNet
{
    partial class Form11ParametrosSalida
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
            cmbDept = new ComboBox();
            label1 = new Label();
            btnMostrar = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            label3 = new Label();
            txtMedia = new TextBox();
            txtPersonas = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // cmbDept
            // 
            cmbDept.FormattingEnabled = true;
            cmbDept.Location = new Point(32, 58);
            cmbDept.Name = "cmbDept";
            cmbDept.Size = new Size(121, 23);
            cmbDept.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Departamentos";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(32, 87);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(121, 33);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 135);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(32, 165);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 209);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Media";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(32, 242);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 6;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(32, 311);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(100, 23);
            txtPersonas.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 282);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 18);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(215, 53);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(179, 214);
            lstEmpleados.TabIndex = 10;
            // 
            // Form11ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 352);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(label1);
            Controls.Add(cmbDept);
            Name = "Form11ParametrosSalida";
            Text = "Form11ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDept;
        private Label label1;
        private Button btnMostrar;
        private Label label2;
        private TextBox txtSuma;
        private Label label3;
        private TextBox txtMedia;
        private TextBox txtPersonas;
        private Label label4;
        private Label label5;
        private ListBox lstEmpleados;
    }
}