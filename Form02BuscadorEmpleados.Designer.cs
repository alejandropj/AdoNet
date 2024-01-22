namespace AdoNet
{
    partial class Form02BuscadorEmpleados
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
            label1 = new Label();
            txtSalario = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            btnBuscarOficio = new Button();
            txtOficio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(43, 56);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(167, 23);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(67, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(121, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar empleados";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 136);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(43, 154);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(331, 94);
            lstEmpleados.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 24);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Oficio:";
            // 
            // btnBuscarOficio
            // 
            btnBuscarOficio.Location = new Point(286, 100);
            btnBuscarOficio.Name = "btnBuscarOficio";
            btnBuscarOficio.Size = new Size(128, 23);
            btnBuscarOficio.TabIndex = 6;
            btnBuscarOficio.Text = "Buscar oficio";
            btnBuscarOficio.UseVisualStyleBackColor = true;
            btnBuscarOficio.Click += btnBuscarOficio_Click;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(286, 56);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(128, 23);
            txtOficio.TabIndex = 7;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 311);
            Controls.Add(txtOficio);
            Controls.Add(btnBuscarOficio);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscar;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private Button btnBuscarOficio;
        private TextBox txtOficio;
    }
}