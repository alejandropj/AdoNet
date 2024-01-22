namespace AdoNet
{
    partial class Form05DepartamentosEmpleados
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lstDepartamentos = new ListBox();
            lstEmpleados = new ListBox();
            txtOficio = new TextBox();
            txtSalario = new TextBox();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 20);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 20);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Oficio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 83);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Salario";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 15;
            lstDepartamentos.Location = new Point(34, 41);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(120, 184);
            lstDepartamentos.TabIndex = 4;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(202, 41);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(120, 184);
            lstEmpleados.TabIndex = 5;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(361, 41);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 6;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(361, 101);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 7;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(361, 150);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 44);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar Datos";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form05DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 261);
            Controls.Add(btnModificar);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(lstEmpleados);
            Controls.Add(lstDepartamentos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form05DepartamentosEmpleados";
            Text = "Form05DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstDepartamentos;
        private ListBox lstEmpleados;
        private TextBox txtOficio;
        private TextBox txtSalario;
        private Button btnModificar;
    }
}