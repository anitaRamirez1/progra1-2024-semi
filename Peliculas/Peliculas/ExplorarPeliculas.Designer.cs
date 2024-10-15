namespace Peliculas
{
    partial class ExplorarPeliculas
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
            this.lblBuscarDocentes = new System.Windows.Forms.Label();
            this.txtBuscarDocentes = new System.Windows.Forms.TextBox();
            this.grdDatosPelicula = new System.Windows.Forms.DataGridView();
            this.grbNavegacionPeliculas = new System.Windows.Forms.GroupBox();
            this.lblRegistrosPeliculas = new System.Windows.Forms.Label();
            this.btnUltimaPelicula = new System.Windows.Forms.Button();
            this.btnSiguientePelicula = new System.Windows.Forms.Button();
            this.btnAnteriorPelicula = new System.Windows.Forms.Button();
            this.btnPrimeroPelicula = new System.Windows.Forms.Button();
            this.grbDatosPeliculas = new System.Windows.Forms.GroupBox();
            this.lblDescripcionP = new System.Windows.Forms.Label();
            this.txtDescripcionP = new System.Windows.Forms.TextBox();
            this.lblPrecioPelicula = new System.Windows.Forms.Label();
            this.txtPrecioPelicula = new System.Windows.Forms.TextBox();
            this.lblAñoPelicula = new System.Windows.Forms.Label();
            this.txtAñoPelicula = new System.Windows.Forms.TextBox();
            this.lblNombrePeliculas = new System.Windows.Forms.Label();
            this.txtNombrePeliculas = new System.Windows.Forms.TextBox();
            this.lblCodigoPeliculas = new System.Windows.Forms.Label();
            this.txtCodigoPeliculas = new System.Windows.Forms.TextBox();
            this.btnComprarPelicula = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPelicula)).BeginInit();
            this.grbNavegacionPeliculas.SuspendLayout();
            this.grbDatosPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarDocentes
            // 
            this.lblBuscarDocentes.AutoSize = true;
            this.lblBuscarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDocentes.Location = new System.Drawing.Point(377, 69);
            this.lblBuscarDocentes.Name = "lblBuscarDocentes";
            this.lblBuscarDocentes.Size = new System.Drawing.Size(91, 24);
            this.lblBuscarDocentes.TabIndex = 21;
            this.lblBuscarDocentes.Text = "BUSCAR:";
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(468, 74);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(347, 20);
            this.txtBuscarDocentes.TabIndex = 22;
            // 
            // grdDatosPelicula
            // 
            this.grdDatosPelicula.AllowUserToAddRows = false;
            this.grdDatosPelicula.AllowUserToDeleteRows = false;
            this.grdDatosPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.Año,
            this.Precio,
            this.Descripcion});
            this.grdDatosPelicula.Location = new System.Drawing.Point(372, 100);
            this.grdDatosPelicula.Name = "grdDatosPelicula";
            this.grdDatosPelicula.ReadOnly = true;
            this.grdDatosPelicula.Size = new System.Drawing.Size(527, 252);
            this.grdDatosPelicula.TabIndex = 20;
            // 
            // grbNavegacionPeliculas
            // 
            this.grbNavegacionPeliculas.Controls.Add(this.lblRegistrosPeliculas);
            this.grbNavegacionPeliculas.Controls.Add(this.btnUltimaPelicula);
            this.grbNavegacionPeliculas.Controls.Add(this.btnSiguientePelicula);
            this.grbNavegacionPeliculas.Controls.Add(this.btnAnteriorPelicula);
            this.grbNavegacionPeliculas.Controls.Add(this.btnPrimeroPelicula);
            this.grbNavegacionPeliculas.Location = new System.Drawing.Point(2, 354);
            this.grbNavegacionPeliculas.Name = "grbNavegacionPeliculas";
            this.grbNavegacionPeliculas.Size = new System.Drawing.Size(213, 58);
            this.grbNavegacionPeliculas.TabIndex = 18;
            this.grbNavegacionPeliculas.TabStop = false;
            this.grbNavegacionPeliculas.Text = "Navegacion";
            // 
            // lblRegistrosPeliculas
            // 
            this.lblRegistrosPeliculas.AutoSize = true;
            this.lblRegistrosPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosPeliculas.Location = new System.Drawing.Point(76, 24);
            this.lblRegistrosPeliculas.Name = "lblRegistrosPeliculas";
            this.lblRegistrosPeliculas.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosPeliculas.TabIndex = 10;
            this.lblRegistrosPeliculas.Text = "x de n";
            // 
            // btnUltimaPelicula
            // 
            this.btnUltimaPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaPelicula.Location = new System.Drawing.Point(172, 14);
            this.btnUltimaPelicula.Name = "btnUltimaPelicula";
            this.btnUltimaPelicula.Size = new System.Drawing.Size(35, 38);
            this.btnUltimaPelicula.TabIndex = 3;
            this.btnUltimaPelicula.Text = ">|";
            this.btnUltimaPelicula.UseVisualStyleBackColor = true;
            // 
            // btnSiguientePelicula
            // 
            this.btnSiguientePelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguientePelicula.Location = new System.Drawing.Point(139, 14);
            this.btnSiguientePelicula.Name = "btnSiguientePelicula";
            this.btnSiguientePelicula.Size = new System.Drawing.Size(35, 38);
            this.btnSiguientePelicula.TabIndex = 2;
            this.btnSiguientePelicula.Text = ">";
            this.btnSiguientePelicula.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorPelicula
            // 
            this.btnAnteriorPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorPelicula.Location = new System.Drawing.Point(40, 18);
            this.btnAnteriorPelicula.Name = "btnAnteriorPelicula";
            this.btnAnteriorPelicula.Size = new System.Drawing.Size(35, 38);
            this.btnAnteriorPelicula.TabIndex = 1;
            this.btnAnteriorPelicula.Text = "<";
            this.btnAnteriorPelicula.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroPelicula
            // 
            this.btnPrimeroPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroPelicula.Location = new System.Drawing.Point(7, 18);
            this.btnPrimeroPelicula.Name = "btnPrimeroPelicula";
            this.btnPrimeroPelicula.Size = new System.Drawing.Size(35, 38);
            this.btnPrimeroPelicula.TabIndex = 0;
            this.btnPrimeroPelicula.Text = "|<";
            this.btnPrimeroPelicula.UseVisualStyleBackColor = true;
            // 
            // grbDatosPeliculas
            // 
            this.grbDatosPeliculas.Controls.Add(this.lblDescripcionP);
            this.grbDatosPeliculas.Controls.Add(this.txtDescripcionP);
            this.grbDatosPeliculas.Controls.Add(this.lblPrecioPelicula);
            this.grbDatosPeliculas.Controls.Add(this.txtPrecioPelicula);
            this.grbDatosPeliculas.Controls.Add(this.lblAñoPelicula);
            this.grbDatosPeliculas.Controls.Add(this.txtAñoPelicula);
            this.grbDatosPeliculas.Controls.Add(this.lblNombrePeliculas);
            this.grbDatosPeliculas.Controls.Add(this.txtNombrePeliculas);
            this.grbDatosPeliculas.Controls.Add(this.lblCodigoPeliculas);
            this.grbDatosPeliculas.Controls.Add(this.txtCodigoPeliculas);
            this.grbDatosPeliculas.Enabled = false;
            this.grbDatosPeliculas.Location = new System.Drawing.Point(2, 34);
            this.grbDatosPeliculas.Name = "grbDatosPeliculas";
            this.grbDatosPeliculas.Size = new System.Drawing.Size(370, 314);
            this.grbDatosPeliculas.TabIndex = 17;
            this.grbDatosPeliculas.TabStop = false;
            this.grbDatosPeliculas.Text = "Datos Peliculas";
            // 
            // lblDescripcionP
            // 
            this.lblDescripcionP.AutoSize = true;
            this.lblDescripcionP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionP.Location = new System.Drawing.Point(31, 200);
            this.lblDescripcionP.Name = "lblDescripcionP";
            this.lblDescripcionP.Size = new System.Drawing.Size(115, 24);
            this.lblDescripcionP.TabIndex = 9;
            this.lblDescripcionP.Text = "Descripcion:";
            // 
            // txtDescripcionP
            // 
            this.txtDescripcionP.Location = new System.Drawing.Point(143, 205);
            this.txtDescripcionP.Multiline = true;
            this.txtDescripcionP.Name = "txtDescripcionP";
            this.txtDescripcionP.Size = new System.Drawing.Size(212, 90);
            this.txtDescripcionP.TabIndex = 8;
            // 
            // lblPrecioPelicula
            // 
            this.lblPrecioPelicula.AutoSize = true;
            this.lblPrecioPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPelicula.Location = new System.Drawing.Point(31, 155);
            this.lblPrecioPelicula.Name = "lblPrecioPelicula";
            this.lblPrecioPelicula.Size = new System.Drawing.Size(69, 24);
            this.lblPrecioPelicula.TabIndex = 7;
            this.lblPrecioPelicula.Text = "Precio:";
            // 
            // txtPrecioPelicula
            // 
            this.txtPrecioPelicula.Location = new System.Drawing.Point(131, 159);
            this.txtPrecioPelicula.Name = "txtPrecioPelicula";
            this.txtPrecioPelicula.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioPelicula.TabIndex = 6;
            // 
            // lblAñoPelicula
            // 
            this.lblAñoPelicula.AutoSize = true;
            this.lblAñoPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoPelicula.Location = new System.Drawing.Point(31, 116);
            this.lblAñoPelicula.Name = "lblAñoPelicula";
            this.lblAñoPelicula.Size = new System.Drawing.Size(50, 24);
            this.lblAñoPelicula.TabIndex = 5;
            this.lblAñoPelicula.Text = "Año:";
            // 
            // txtAñoPelicula
            // 
            this.txtAñoPelicula.Location = new System.Drawing.Point(131, 120);
            this.txtAñoPelicula.Name = "txtAñoPelicula";
            this.txtAñoPelicula.Size = new System.Drawing.Size(74, 20);
            this.txtAñoPelicula.TabIndex = 4;
            // 
            // lblNombrePeliculas
            // 
            this.lblNombrePeliculas.AutoSize = true;
            this.lblNombrePeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePeliculas.Location = new System.Drawing.Point(31, 76);
            this.lblNombrePeliculas.Name = "lblNombrePeliculas";
            this.lblNombrePeliculas.Size = new System.Drawing.Size(84, 24);
            this.lblNombrePeliculas.TabIndex = 3;
            this.lblNombrePeliculas.Text = "Nombre:";
            // 
            // txtNombrePeliculas
            // 
            this.txtNombrePeliculas.Location = new System.Drawing.Point(121, 81);
            this.txtNombrePeliculas.Name = "txtNombrePeliculas";
            this.txtNombrePeliculas.Size = new System.Drawing.Size(243, 20);
            this.txtNombrePeliculas.TabIndex = 2;
            this.txtNombrePeliculas.TextChanged += new System.EventHandler(this.txtNombrePeliculas_TextChanged);
            // 
            // lblCodigoPeliculas
            // 
            this.lblCodigoPeliculas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lblCodigoPeliculas.AutoSize = true;
            this.lblCodigoPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPeliculas.Location = new System.Drawing.Point(31, 37);
            this.lblCodigoPeliculas.Name = "lblCodigoPeliculas";
            this.lblCodigoPeliculas.Size = new System.Drawing.Size(76, 24);
            this.lblCodigoPeliculas.TabIndex = 1;
            this.lblCodigoPeliculas.Text = "Codigo:";
            // 
            // txtCodigoPeliculas
            // 
            this.txtCodigoPeliculas.Location = new System.Drawing.Point(131, 41);
            this.txtCodigoPeliculas.Name = "txtCodigoPeliculas";
            this.txtCodigoPeliculas.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPeliculas.TabIndex = 0;
            // 
            // btnComprarPelicula
            // 
            this.btnComprarPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarPelicula.Location = new System.Drawing.Point(283, 368);
            this.btnComprarPelicula.Name = "btnComprarPelicula";
            this.btnComprarPelicula.Size = new System.Drawing.Size(131, 38);
            this.btnComprarPelicula.TabIndex = 23;
            this.btnComprarPelicula.Text = "Comprar";
            this.btnComprarPelicula.UseVisualStyleBackColor = true;
            this.btnComprarPelicula.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(449, 371);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 38);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "Año";
            this.Año.HeaderText = "AÑO";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "PRECIO";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "DESCRIPCION";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // ExplorarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnComprarPelicula);
            this.Controls.Add(this.lblBuscarDocentes);
            this.Controls.Add(this.txtBuscarDocentes);
            this.Controls.Add(this.grdDatosPelicula);
            this.Controls.Add(this.grbNavegacionPeliculas);
            this.Controls.Add(this.grbDatosPeliculas);
            this.Name = "ExplorarPeliculas";
            this.Text = "ExplorarPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPelicula)).EndInit();
            this.grbNavegacionPeliculas.ResumeLayout(false);
            this.grbNavegacionPeliculas.PerformLayout();
            this.grbDatosPeliculas.ResumeLayout(false);
            this.grbDatosPeliculas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarDocentes;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.DataGridView grdDatosPelicula;
        private System.Windows.Forms.GroupBox grbNavegacionPeliculas;
        private System.Windows.Forms.Label lblRegistrosPeliculas;
        private System.Windows.Forms.Button btnUltimaPelicula;
        private System.Windows.Forms.Button btnSiguientePelicula;
        private System.Windows.Forms.Button btnAnteriorPelicula;
        private System.Windows.Forms.Button btnPrimeroPelicula;
        private System.Windows.Forms.GroupBox grbDatosPeliculas;
        private System.Windows.Forms.Label lblDescripcionP;
        private System.Windows.Forms.TextBox txtDescripcionP;
        private System.Windows.Forms.Label lblPrecioPelicula;
        private System.Windows.Forms.TextBox txtPrecioPelicula;
        private System.Windows.Forms.Label lblAñoPelicula;
        private System.Windows.Forms.TextBox txtAñoPelicula;
        private System.Windows.Forms.Label lblNombrePeliculas;
        private System.Windows.Forms.TextBox txtNombrePeliculas;
        private System.Windows.Forms.Label lblCodigoPeliculas;
        private System.Windows.Forms.TextBox txtCodigoPeliculas;
        private System.Windows.Forms.Button btnComprarPelicula;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}