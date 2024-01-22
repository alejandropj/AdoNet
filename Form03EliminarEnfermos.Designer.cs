namespace AdoNet
{
    partial class Form03EliminarEnfermos
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
            btnEliminar = new Button();
            lstEnfermos = new ListBox();
            label2 = new Label();
            txtInscripcion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Inscripción";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(40, 104);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.ItemHeight = 15;
            lstEnfermos.Location = new Point(184, 58);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(166, 139);
            lstEnfermos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 25);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(25, 58);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(100, 23);
            txtInscripcion.TabIndex = 4;
            // 
            // Form03EliminarEnfermos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 218);
            Controls.Add(txtInscripcion);
            Controls.Add(label2);
            Controls.Add(lstEnfermos);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Name = "Form03EliminarEnfermos";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEliminar;
        private ListBox lstEnfermos;
        private Label label2;
        private TextBox txtInscripcion;
    }
}