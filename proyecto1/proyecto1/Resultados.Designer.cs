namespace proyecto1
{
    partial class Dietas
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
            lblAños = new Label();
            txtPesoBajo = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtPesoNormal = new TextBox();
            pictureBox1 = new PictureBox();
            bntSiguiente = new Button();
            lblPesoNormal = new Label();
            lblPesoBajo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAños
            // 
            lblAños.AutoSize = true;
            lblAños.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAños.Location = new Point(234, 9);
            lblAños.Name = "lblAños";
            lblAños.Size = new Size(78, 23);
            lblAños.TabIndex = 23;
            lblAños.Text = "Recetas:";
            // 
            // txtPesoBajo
            // 
            txtPesoBajo.BackColor = Color.Cyan;
            txtPesoBajo.Location = new Point(331, 9);
            txtPesoBajo.Multiline = true;
            txtPesoBajo.Name = "txtPesoBajo";
            txtPesoBajo.Size = new Size(214, 375);
            txtPesoBajo.TabIndex = 30;
            txtPesoBajo.TextChanged += txtEstatura_TextChanged;
            // 
            // txtPesoNormal
            // 
            txtPesoNormal.BackColor = Color.FromArgb(0, 192, 0);
            txtPesoNormal.Location = new Point(561, 9);
            txtPesoNormal.Multiline = true;
            txtPesoNormal.Name = "txtPesoNormal";
            txtPesoNormal.Size = new Size(227, 375);
            txtPesoNormal.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._FEBAB1F6_AB4E_4CEC_B821_162D607C7E26_;
            pictureBox1.Location = new Point(43, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 296);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // bntSiguiente
            // 
            bntSiguiente.BackColor = Color.CornflowerBlue;
            bntSiguiente.FlatStyle = FlatStyle.Popup;
            bntSiguiente.ImeMode = ImeMode.NoControl;
            bntSiguiente.Location = new Point(615, 396);
            bntSiguiente.Name = "bntSiguiente";
            bntSiguiente.Size = new Size(112, 42);
            bntSiguiente.TabIndex = 35;
            bntSiguiente.Text = "siguente";
            bntSiguiente.UseVisualStyleBackColor = false;
            // 
            // lblPesoNormal
            // 
            lblPesoNormal.AutoSize = true;
            lblPesoNormal.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesoNormal.Location = new Point(203, 35);
            lblPesoNormal.Name = "lblPesoNormal";
            lblPesoNormal.Size = new Size(109, 23);
            lblPesoNormal.TabIndex = 36;
            lblPesoNormal.Text = "Peso normal";
            lblPesoNormal.Click += lblPesoNormal_Click;
            // 
            // lblPesoBajo
            // 
            lblPesoBajo.AutoSize = true;
            lblPesoBajo.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesoBajo.Location = new Point(67, 35);
            lblPesoBajo.Name = "lblPesoBajo";
            lblPesoBajo.Size = new Size(88, 23);
            lblPesoBajo.TabIndex = 37;
            lblPesoBajo.Text = "Peso Bajo";
            // 
            // Dietas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPesoBajo);
            Controls.Add(lblPesoNormal);
            Controls.Add(bntSiguiente);
            Controls.Add(pictureBox1);
            Controls.Add(txtPesoNormal);
            Controls.Add(txtPesoBajo);
            Controls.Add(lblAños);
            Name = "Dietas";
            Text = "Resultados";
            Load += Resultados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAños;
        private TextBox txtPesoBajo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtPesoNormal;
        private PictureBox pictureBox1;
        private Button bntSiguiente;
        private Label lblPesoNormal;
        private Label lblPesoBajo;
    }
}