namespace AdoNet
{
    partial class Form04ModificarSalas
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
            btnModificar = new Button();
            label1 = new Label();
            txtSala = new TextBox();
            label5 = new Label();
            lstModificar = new ListBox();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(47, 108);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar Salas";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Nuevo nombre";
            // 
            // txtSala
            // 
            txtSala.Location = new Point(31, 56);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(100, 23);
            txtSala.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 18);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 3;
            label5.Text = "Salas";
            // 
            // lstModificar
            // 
            lstModificar.FormattingEnabled = true;
            lstModificar.ItemHeight = 15;
            lstModificar.Location = new Point(175, 64);
            lstModificar.Name = "lstModificar";
            lstModificar.Size = new Size(120, 109);
            lstModificar.TabIndex = 4;
            // 
            // Form04ModificarSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 209);
            Controls.Add(lstModificar);
            Controls.Add(label5);
            Controls.Add(txtSala);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Name = "Form04ModificarSalas";
            Text = "Form04ModificarSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Label label1;
        private TextBox txtSala;
        private Label label5;
        private ListBox lstModificar;
    }
}