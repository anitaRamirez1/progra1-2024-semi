namespace academica_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.texNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lbldireccionAlumno = new System.Windows.Forms.Label();
            this.lblduiAlumo = new System.Windows.Forms.Label();
            this.lbltelefonoAlumno = new System.Windows.Forms.Label();
            this.txttelefonoAlumno = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnPrimerAlumno = new System.Windows.Forms.Button();
            this.groupDatosAlumnos.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(25, 16);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(83, 26);
            this.lblCodigoAlumno.TabIndex = 0;
            this.lblCodigoAlumno.Text = "codigo:";
            this.lblCodigoAlumno.Click += new System.EventHandler(this.lblCodigoAlumno_Click);
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(114, 19);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(119, 20);
            this.txtCodigoAlumno.TabIndex = 1;
            this.txtCodigoAlumno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(12, 51);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(96, 26);
            this.lblNombreAlumno.TabIndex = 2;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // texNombreAlumno
            // 
            this.texNombreAlumno.Location = new System.Drawing.Point(114, 57);
            this.texNombreAlumno.Name = "texNombreAlumno";
            this.texNombreAlumno.Size = new System.Drawing.Size(217, 20);
            this.texNombreAlumno.TabIndex = 3;
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(125, 98);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(206, 20);
            this.txtDireccionAlumno.TabIndex = 4;
            // 
            // lbldireccionAlumno
            // 
            this.lbldireccionAlumno.AutoSize = true;
            this.lbldireccionAlumno.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccionAlumno.Location = new System.Drawing.Point(6, 92);
            this.lbldireccionAlumno.Name = "lbldireccionAlumno";
            this.lbldireccionAlumno.Size = new System.Drawing.Size(100, 26);
            this.lbldireccionAlumno.TabIndex = 5;
            this.lbldireccionAlumno.Text = "direccion";
            // 
            // lblduiAlumo
            // 
            this.lblduiAlumo.AutoSize = true;
            this.lblduiAlumo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduiAlumo.Location = new System.Drawing.Point(25, 190);
            this.lblduiAlumo.Name = "lblduiAlumo";
            this.lblduiAlumo.Size = new System.Drawing.Size(50, 26);
            this.lblduiAlumo.TabIndex = 6;
            this.lblduiAlumo.Text = "Dui:";
            // 
            // lbltelefonoAlumno
            // 
            this.lbltelefonoAlumno.AutoSize = true;
            this.lbltelefonoAlumno.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefonoAlumno.Location = new System.Drawing.Point(10, 147);
            this.lbltelefonoAlumno.Name = "lbltelefonoAlumno";
            this.lbltelefonoAlumno.Size = new System.Drawing.Size(96, 26);
            this.lbltelefonoAlumno.TabIndex = 7;
            this.lbltelefonoAlumno.Text = "Telefono";
            // 
            // txttelefonoAlumno
            // 
            this.txttelefonoAlumno.Location = new System.Drawing.Point(125, 147);
            this.txttelefonoAlumno.Name = "txttelefonoAlumno";
            this.txttelefonoAlumno.Size = new System.Drawing.Size(119, 20);
            this.txttelefonoAlumno.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 9;
            // 
            // groupDatosAlumnos
            // 
            this.groupDatosAlumnos.Controls.Add(this.lblCodigoAlumno);
            this.groupDatosAlumnos.Controls.Add(this.textBox2);
            this.groupDatosAlumnos.Controls.Add(this.txtCodigoAlumno);
            this.groupDatosAlumnos.Controls.Add(this.lblduiAlumo);
            this.groupDatosAlumnos.Controls.Add(this.txttelefonoAlumno);
            this.groupDatosAlumnos.Controls.Add(this.lblNombreAlumno);
            this.groupDatosAlumnos.Controls.Add(this.lbltelefonoAlumno);
            this.groupDatosAlumnos.Controls.Add(this.texNombreAlumno);
            this.groupDatosAlumnos.Controls.Add(this.lbldireccionAlumno);
            this.groupDatosAlumnos.Controls.Add(this.txtDireccionAlumno);
            this.groupDatosAlumnos.Location = new System.Drawing.Point(26, 28);
            this.groupDatosAlumnos.Name = "groupDatosAlumnos";
            this.groupDatosAlumnos.Size = new System.Drawing.Size(357, 235);
            this.groupDatosAlumnos.TabIndex = 10;
            this.groupDatosAlumnos.TabStop = false;
            this.groupDatosAlumnos.Text = "Datos Alumnos:";
            this.groupDatosAlumnos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimerAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(26, 320);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(200, 100);
            this.grbNavegacionAlumno.TabIndex = 11;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Location = new System.Drawing.Point(282, 320);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(200, 100);
            this.grbEdicionAlumno.TabIndex = 12;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "navegacion";
            // 
            // btnPrimerAlumno
            // 
            this.btnPrimerAlumno.Location = new System.Drawing.Point(11, 19);
            this.btnPrimerAlumno.Name = "btnPrimerAlumno";
            this.btnPrimerAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnPrimerAlumno.TabIndex = 0;
            this.btnPrimerAlumno.Text = "|<";
            this.btnPrimerAlumno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.groupDatosAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupDatosAlumnos.ResumeLayout(false);
            this.groupDatosAlumnos.PerformLayout();
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox texNombreAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lbldireccionAlumno;
        private System.Windows.Forms.Label lblduiAlumo;
        private System.Windows.Forms.Label lbltelefonoAlumno;
        private System.Windows.Forms.TextBox txttelefonoAlumno;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupDatosAlumnos;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnPrimerAlumno;
    }
}

