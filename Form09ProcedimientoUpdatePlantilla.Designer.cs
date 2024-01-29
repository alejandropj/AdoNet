namespace AdoNet
{
    partial class Form09ProcedimientoUpdatePlantilla
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
            cmbHospitales = new ComboBox();
            btnModificar = new Button();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 21);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 103);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Plantilla";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(38, 58);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(121, 23);
            cmbHospitales.TabIndex = 2;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(202, 47);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(81, 43);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar Salarios";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.ItemHeight = 15;
            lstPlantilla.Location = new Point(38, 136);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(245, 94);
            lstPlantilla.TabIndex = 4;
            lstPlantilla.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form09ProcedimientoUpdatePlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 257);
            Controls.Add(lstPlantilla);
            Controls.Add(btnModificar);
            Controls.Add(cmbHospitales);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form09ProcedimientoUpdatePlantilla";
            Text = "Form09ProcedimientoUpdatePlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbHospitales;
        private Button btnModificar;
        private ListBox lstPlantilla;
    }
}