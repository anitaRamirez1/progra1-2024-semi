namespace proyecto1
{
    partial class CalcularPesoIdeal
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
            lblEdad = new Label();
            lblPeso = new Label();
            lblPesokg = new Label();
            lblEstatura = new Label();
            lblCm = new Label();
            lblAños = new Label();
            lblMasDeTi = new Label();
            txtEstatura = new TextBox();
            txtPeso = new TextBox();
            txtAños = new TextBox();
            bntCalcular = new Button();
            btnDietas = new Button();
            SuspendLayout();
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(44, 118);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(60, 25);
            lblEdad.TabIndex = 27;
            lblEdad.Text = "Años:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeso.Location = new Point(44, 200);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(209, 25);
            lblPeso.TabIndex = 26;
            lblPeso.Text = "¿Cuál es tu peso en kg?";
            // 
            // lblPesokg
            // 
            lblPesokg.AutoSize = true;
            lblPesokg.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesokg.Location = new Point(53, 255);
            lblPesokg.Name = "lblPesokg";
            lblPesokg.Size = new Size(40, 25);
            lblPesokg.TabIndex = 25;
            lblPesokg.Text = "Kg:";
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstatura.Location = new Point(455, 66);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(320, 25);
            lblEstatura.TabIndex = 24;
            lblEstatura.Text = "¿Cuál es tu estatura en centímetros?";
            // 
            // lblCm
            // 
            lblCm.AutoSize = true;
            lblCm.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCm.Location = new Point(455, 137);
            lblCm.Name = "lblCm";
            lblCm.Size = new Size(43, 25);
            lblCm.TabIndex = 23;
            lblCm.Text = "cm:";
            // 
            // lblAños
            // 
            lblAños.AutoSize = true;
            lblAños.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAños.Location = new Point(44, 66);
            lblAños.Name = "lblAños";
            lblAños.Size = new Size(199, 25);
            lblAños.TabIndex = 22;
            lblAños.Text = "¿Cuantos años tienes?";
            // 
            // lblMasDeTi
            // 
            lblMasDeTi.AutoSize = true;
            lblMasDeTi.Font = new Font("Arial", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMasDeTi.ForeColor = Color.Navy;
            lblMasDeTi.Location = new Point(132, 9);
            lblMasDeTi.Name = "lblMasDeTi";
            lblMasDeTi.Size = new Size(483, 36);
            lblMasDeTi.TabIndex = 28;
            lblMasDeTi.Text = "¡cuentanos un poco más de ti!";
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(504, 142);
            txtEstatura.Multiline = true;
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(134, 23);
            txtEstatura.TabIndex = 29;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(99, 260);
            txtPeso.Multiline = true;
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(144, 23);
            txtPeso.TabIndex = 30;
            // 
            // txtAños
            // 
            txtAños.Location = new Point(110, 123);
            txtAños.Multiline = true;
            txtAños.Name = "txtAños";
            txtAños.Size = new Size(152, 23);
            txtAños.TabIndex = 31;
            // 
            // bntCalcular
            // 
            bntCalcular.BackColor = Color.CornflowerBlue;
            bntCalcular.FlatStyle = FlatStyle.Popup;
            bntCalcular.ImeMode = ImeMode.NoControl;
            bntCalcular.Location = new Point(342, 338);
            bntCalcular.Name = "bntCalcular";
            bntCalcular.Size = new Size(112, 42);
            bntCalcular.TabIndex = 32;
            bntCalcular.Text = "calcular";
            bntCalcular.UseVisualStyleBackColor = false;
            // 
            // btnDietas
            // 
            btnDietas.BackColor = Color.CornflowerBlue;
            btnDietas.FlatStyle = FlatStyle.Popup;
            btnDietas.ImeMode = ImeMode.NoControl;
            btnDietas.Location = new Point(526, 338);
            btnDietas.Name = "btnDietas";
            btnDietas.Size = new Size(180, 42);
            btnDietas.TabIndex = 33;
            btnDietas.Text = "Ver dietas segun tus resultados";
            btnDietas.UseVisualStyleBackColor = false;
            // 
            // CalcularPesoIdeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDietas);
            Controls.Add(bntCalcular);
            Controls.Add(txtAños);
            Controls.Add(txtPeso);
            Controls.Add(txtEstatura);
            Controls.Add(lblMasDeTi);
            Controls.Add(lblEdad);
            Controls.Add(lblPeso);
            Controls.Add(lblPesokg);
            Controls.Add(lblEstatura);
            Controls.Add(lblCm);
            Controls.Add(lblAños);
            Name = "CalcularPesoIdeal";
            Text = "CalcularPeso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEdad;
        private Label lblPeso;
        private Label lblPesokg;
        private Label lblEstatura;
        private Label lblCm;
        private Label lblAños;
        private Label lblMasDeTi;
        private TextBox txtEstatura;
        private TextBox txtPeso;
        private TextBox txtAños;
        private Button bntCalcular;
        private Button btnDietas;
    }
}