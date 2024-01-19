namespace AdoNet
{
    partial class Form01PrimerAdo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConectar = new Button();
            btnDesconnect = new Button();
            btnRead = new Button();
            label1 = new Label();
            lstApellidos = new ListBox();
            label2 = new Label();
            label3 = new Label();
            lblMensaje = new Label();
            lstColumnas = new ListBox();
            lstTiposDato = new ListBox();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(32, 26);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(92, 23);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconnect
            // 
            btnDesconnect.Location = new Point(32, 65);
            btnDesconnect.Name = "btnDesconnect";
            btnDesconnect.Size = new Size(92, 23);
            btnDesconnect.TabIndex = 1;
            btnDesconnect.Text = "Desconectar";
            btnDesconnect.UseVisualStyleBackColor = true;
            btnDesconnect.Click += btnDesconnect_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(32, 105);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(92, 23);
            btnRead.TabIndex = 2;
            btnRead.Text = "Leer datos";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.ItemHeight = 15;
            lstApellidos.Location = new Point(142, 65);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(88, 94);
            lstApellidos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 26);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Columnas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 26);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "Tipos dato";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(32, 206);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(38, 15);
            lblMensaje.TabIndex = 7;
            lblMensaje.Text = "label4";
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.ItemHeight = 15;
            lstColumnas.Location = new Point(262, 65);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(83, 94);
            lstColumnas.TabIndex = 8;
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.ItemHeight = 15;
            lstTiposDato.Location = new Point(368, 65);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(100, 94);
            lstTiposDato.TabIndex = 9;
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 266);
            Controls.Add(lstTiposDato);
            Controls.Add(lstColumnas);
            Controls.Add(lblMensaje);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Controls.Add(btnRead);
            Controls.Add(btnDesconnect);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconnect;
        private Button btnRead;
        private Label label1;
        private ListBox lstApellidos;
        private Label label2;
        private Label label3;
        private Label lblMensaje;
        private ListBox lstColumnas;
        private ListBox lstTiposDato;
    }
}
