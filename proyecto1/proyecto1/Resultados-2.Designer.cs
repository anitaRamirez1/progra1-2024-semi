namespace proyecto1
{
    partial class Resultados_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados_2));
            lblSobrepeso = new Label();
            lblPesoObeso = new Label();
            bntSiguiente = new Button();
            pictureBox1 = new PictureBox();
            txtPesoObeso = new TextBox();
            txtSobrepeso = new TextBox();
            lblAños = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSobrepeso
            // 
            lblSobrepeso.AutoSize = true;
            lblSobrepeso.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSobrepeso.Location = new Point(52, 37);
            lblSobrepeso.Name = "lblSobrepeso";
            lblSobrepeso.Size = new Size(95, 23);
            lblSobrepeso.TabIndex = 44;
            lblSobrepeso.Text = "sobrepeso";
            // 
            // lblPesoObeso
            // 
            lblPesoObeso.AutoSize = true;
            lblPesoObeso.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesoObeso.Location = new Point(188, 37);
            lblPesoObeso.Name = "lblPesoObeso";
            lblPesoObeso.Size = new Size(101, 23);
            lblPesoObeso.TabIndex = 43;
            lblPesoObeso.Text = "Peso Obeso";
            // 
            // bntSiguiente
            // 
            bntSiguiente.BackColor = Color.CornflowerBlue;
            bntSiguiente.FlatStyle = FlatStyle.Popup;
            bntSiguiente.ImeMode = ImeMode.NoControl;
            bntSiguiente.Location = new Point(600, 398);
            bntSiguiente.Name = "bntSiguiente";
            bntSiguiente.Size = new Size(112, 42);
            bntSiguiente.TabIndex = 42;
            bntSiguiente.Text = "siguente";
            bntSiguiente.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 296);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // txtPesoObeso
            // 
            txtPesoObeso.BackColor = Color.DarkOrange;
            txtPesoObeso.Location = new Point(546, 11);
            txtPesoObeso.Multiline = true;
            txtPesoObeso.Name = "txtPesoObeso";
            txtPesoObeso.Size = new Size(227, 375);
            txtPesoObeso.TabIndex = 40;
            // 
            // txtSobrepeso
            // 
            txtSobrepeso.BackColor = Color.Gold;
            txtSobrepeso.Location = new Point(316, 11);
            txtSobrepeso.Multiline = true;
            txtSobrepeso.Name = "txtSobrepeso";
            txtSobrepeso.Size = new Size(214, 375);
            txtSobrepeso.TabIndex = 39;
            // 
            // lblAños
            // 
            lblAños.AutoSize = true;
            lblAños.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAños.Location = new Point(219, 11);
            lblAños.Name = "lblAños";
            lblAños.Size = new Size(78, 23);
            lblAños.TabIndex = 38;
            lblAños.Text = "Recetas:";
            // 
            // Resultados_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSobrepeso);
            Controls.Add(lblPesoObeso);
            Controls.Add(bntSiguiente);
            Controls.Add(pictureBox1);
            Controls.Add(txtPesoObeso);
            Controls.Add(txtSobrepeso);
            Controls.Add(lblAños);
            Name = "Resultados_2";
            Text = "Resultados_2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSobrepeso;
        private Label lblPesoObeso;
        private Button bntSiguiente;
        private PictureBox pictureBox1;
        private TextBox txtPesoObeso;
        private TextBox txtSobrepeso;
        private Label lblAños;
    }
}