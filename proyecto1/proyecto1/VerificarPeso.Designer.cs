namespace proyecto1
{
    partial class VerificarPeso
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
            lblBienvenido = new Label();
            lblNombre = new Label();
            lblMensaje2 = new Label();
            lblPregunta = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnHombre = new Button();
            btnMujer = new Button();
            bntSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = SystemColors.ButtonFace;
            lblBienvenido.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblBienvenido.ImeMode = ImeMode.NoControl;
            lblBienvenido.Location = new Point(241, -1);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(210, 40);
            lblBienvenido.TabIndex = 2;
            lblBienvenido.Text = "¡BIENVENIDO!";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.White;
            lblNombre.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblNombre.ImeMode = ImeMode.NoControl;
            lblNombre.Location = new Point(235, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 25);
            lblNombre.TabIndex = 6;
            // 
            // lblMensaje2
            // 
            lblMensaje2.AutoSize = true;
            lblMensaje2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje2.Location = new Point(251, 39);
            lblMensaje2.Name = "lblMensaje2";
            lblMensaje2.Size = new Size(205, 25);
            lblMensaje2.TabIndex = 7;
            lblMensaje2.Text = "¡Verifiquemos tu peso!";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(52, 72);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(177, 25);
            lblPregunta.TabIndex = 8;
            lblPregunta.Text = "¿Cuál es tu genero?";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources._9CD6FAEA_2E47_404C_B036_A4291ED0580C_;
            pictureBox1.Location = new Point(359, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 155);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._DDED54AD_3CDE_45F4_A2F2_CB36ECEBCB12_;
            pictureBox2.Location = new Point(150, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 155);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // btnHombre
            // 
            btnHombre.BackColor = Color.Silver;
            btnHombre.FlatStyle = FlatStyle.Popup;
            btnHombre.ImeMode = ImeMode.NoControl;
            btnHombre.Location = new Point(172, 316);
            btnHombre.Name = "btnHombre";
            btnHombre.Size = new Size(106, 42);
            btnHombre.TabIndex = 14;
            btnHombre.Text = "Hombre";
            btnHombre.UseVisualStyleBackColor = false;
            // 
            // btnMujer
            // 
            btnMujer.BackColor = Color.Silver;
            btnMujer.FlatStyle = FlatStyle.Popup;
            btnMujer.ImeMode = ImeMode.NoControl;
            btnMujer.Location = new Point(393, 316);
            btnMujer.Name = "btnMujer";
            btnMujer.Size = new Size(112, 42);
            btnMujer.TabIndex = 15;
            btnMujer.Text = "Mujer";
            btnMujer.UseVisualStyleBackColor = false;
            btnMujer.Click += btnMujer_Click;
            // 
            // bntSiguiente
            // 
            bntSiguiente.BackColor = Color.CornflowerBlue;
            bntSiguiente.FlatStyle = FlatStyle.Popup;
            bntSiguiente.ImeMode = ImeMode.NoControl;
            bntSiguiente.Location = new Point(622, 350);
            bntSiguiente.Name = "bntSiguiente";
            bntSiguiente.Size = new Size(112, 42);
            bntSiguiente.TabIndex = 16;
            bntSiguiente.Text = "siguiente";
            bntSiguiente.UseVisualStyleBackColor = false;
            // 
            // VerificarPeso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntSiguiente);
            Controls.Add(btnMujer);
            Controls.Add(btnHombre);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblPregunta);
            Controls.Add(lblMensaje2);
            Controls.Add(lblNombre);
            Controls.Add(lblBienvenido);
            Name = "VerificarPeso";
            Text = "VerificarPeso";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblNombre;
        private Label lblMensaje2;
        private Label lblPregunta;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnHombre;
        private Button btnMujer;
        private Button bntSiguiente;
    }
}