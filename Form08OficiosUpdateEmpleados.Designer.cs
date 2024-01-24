namespace AdoNet
{
    partial class Form08OficiosUpdateEmpleados
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
            lblSuma = new Label();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            txtIncremento = new TextBox();
            btnSalarios = new Button();
            lblMedia = new Label();
            lblMinimo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 20);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Incremento";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.ForeColor = SystemColors.ActiveCaption;
            lblSuma.Location = new Point(35, 161);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(50, 15);
            lblSuma.TabIndex = 3;
            lblSuma.Text = "lblSuma";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.ItemHeight = 15;
            lstOficios.Location = new Point(17, 55);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(120, 94);
            lstOficios.TabIndex = 4;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(175, 55);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(120, 139);
            lstEmpleados.TabIndex = 5;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(339, 55);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(106, 23);
            txtIncremento.TabIndex = 6;
            // 
            // btnSalarios
            // 
            btnSalarios.Location = new Point(339, 94);
            btnSalarios.Name = "btnSalarios";
            btnSalarios.Size = new Size(106, 38);
            btnSalarios.TabIndex = 7;
            btnSalarios.Text = "Incrementar Salarios";
            btnSalarios.UseVisualStyleBackColor = true;
            btnSalarios.Click += btnSalarios_Click;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.ForeColor = Color.IndianRed;
            lblMedia.Location = new Point(35, 179);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(53, 15);
            lblMedia.TabIndex = 8;
            lblMedia.Text = "lblMedia";
            // 
            // lblMinimo
            // 
            lblMinimo.AutoSize = true;
            lblMinimo.ForeColor = Color.FromArgb(192, 0, 192);
            lblMinimo.Location = new Point(35, 198);
            lblMinimo.Name = "lblMinimo";
            lblMinimo.Size = new Size(62, 15);
            lblMinimo.TabIndex = 9;
            lblMinimo.Text = "lblMinimo";
            // 
            // Form08OficiosUpdateEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 225);
            Controls.Add(lblMinimo);
            Controls.Add(lblMedia);
            Controls.Add(btnSalarios);
            Controls.Add(txtIncremento);
            Controls.Add(lstEmpleados);
            Controls.Add(lstOficios);
            Controls.Add(lblSuma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form08OficiosUpdateEmpleados";
            Text = "Form08OficiosUpdateEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSuma;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private TextBox txtIncremento;
        private Button btnSalarios;
        private Label lblMedia;
        private Label lblMinimo;
    }
}