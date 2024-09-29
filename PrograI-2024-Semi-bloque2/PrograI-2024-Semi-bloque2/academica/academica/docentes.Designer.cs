namespace academica
{
    partial class docentes
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
            this.grdDatosDocentes = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionDocentes = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocentes = new System.Windows.Forms.Button();
            this.btnModificarDocentes = new System.Windows.Forms.Button();
            this.btnNuevoDocentes = new System.Windows.Forms.Button();
            this.grbNavegacionDocentes = new System.Windows.Forms.GroupBox();
            this.lblRegistrosDocentes = new System.Windows.Forms.Label();
            this.btnUltimoDocentes = new System.Windows.Forms.Button();
            this.btnSiguienteDocentes = new System.Windows.Forms.Button();
            this.btnAnteriorDocentes = new System.Windows.Forms.Button();
            this.btnPrimeroDocentes = new System.Windows.Forms.Button();
            this.grbDatosDocentes = new System.Windows.Forms.GroupBox();
            this.lblDuiDocentes = new System.Windows.Forms.Label();
            this.txtDuiDocentes = new System.Windows.Forms.TextBox();
            this.lblTelefonoDocentes = new System.Windows.Forms.Label();
            this.txtTelefonoDocentes = new System.Windows.Forms.TextBox();
            this.lblDireccionDocentes = new System.Windows.Forms.Label();
            this.txtDireccionDocentes = new System.Windows.Forms.TextBox();
            this.lblNombreDocentes = new System.Windows.Forms.Label();
            this.txtNombreDocentes = new System.Windows.Forms.TextBox();
            this.lblCodigoDocentes = new System.Windows.Forms.Label();
            this.txtCodigoDocentes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).BeginInit();
            this.grbEdicionDocentes.SuspendLayout();
            this.grbNavegacionDocentes.SuspendLayout();
            this.grbDatosDocentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarDocentes
            // 
            this.lblBuscarDocentes.AutoSize = true;
            this.lblBuscarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDocentes.Location = new System.Drawing.Point(384, 57);
            this.lblBuscarDocentes.Name = "lblBuscarDocentes";
            this.lblBuscarDocentes.Size = new System.Drawing.Size(91, 24);
            this.lblBuscarDocentes.TabIndex = 15;
            this.lblBuscarDocentes.Text = "BUSCAR:";
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(475, 62);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(347, 20);
            this.txtBuscarDocentes.TabIndex = 16;
            // 
            // grdDatosDocentes
            // 
            this.grdDatosDocentes.AllowUserToAddRows = false;
            this.grdDatosDocentes.AllowUserToDeleteRows = false;
            this.grdDatosDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDatosDocentes.Location = new System.Drawing.Point(400, 84);
            this.grdDatosDocentes.Name = "grdDatosDocentes";
            this.grdDatosDocentes.ReadOnly = true;
            this.grdDatosDocentes.Size = new System.Drawing.Size(434, 252);
            this.grdDatosDocentes.TabIndex = 14;
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
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // grbEdicionDocentes
            // 
            this.grbEdicionDocentes.Controls.Add(this.btnEliminarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnModificarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnNuevoDocentes);
            this.grbEdicionDocentes.Location = new System.Drawing.Point(199, 346);
            this.grbEdicionDocentes.Name = "grbEdicionDocentes";
            this.grbEdicionDocentes.Size = new System.Drawing.Size(294, 58);
            this.grbEdicionDocentes.TabIndex = 13;
            this.grbEdicionDocentes.TabStop = false;
            this.grbEdicionDocentes.Text = "Navegacion";
            // 
            // btnEliminarDocentes
            // 
            this.btnEliminarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocentes.Location = new System.Drawing.Point(189, 19);
            this.btnEliminarDocentes.Name = "btnEliminarDocentes";
            this.btnEliminarDocentes.Size = new System.Drawing.Size(97, 38);
            this.btnEliminarDocentes.TabIndex = 6;
            this.btnEliminarDocentes.Text = "Eliminar";
            this.btnEliminarDocentes.UseVisualStyleBackColor = true;
            // 
            // btnModificarDocentes
            // 
            this.btnModificarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocentes.Location = new System.Drawing.Point(87, 19);
            this.btnModificarDocentes.Name = "btnModificarDocentes";
            this.btnModificarDocentes.Size = new System.Drawing.Size(104, 38);
            this.btnModificarDocentes.TabIndex = 5;
            this.btnModificarDocentes.Text = "Modificar";
            this.btnModificarDocentes.UseVisualStyleBackColor = true;
            // 
            // btnNuevoDocentes
            // 
            this.btnNuevoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocentes.Location = new System.Drawing.Point(6, 19);
            this.btnNuevoDocentes.Name = "btnNuevoDocentes";
            this.btnNuevoDocentes.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoDocentes.TabIndex = 4;
            this.btnNuevoDocentes.Text = "Nuevo";
            this.btnNuevoDocentes.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionDocentes
            // 
            this.grbNavegacionDocentes.Controls.Add(this.lblRegistrosDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnUltimoDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnSiguienteDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnAnteriorDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnPrimeroDocentes);
            this.grbNavegacionDocentes.Location = new System.Drawing.Point(-20, 346);
            this.grbNavegacionDocentes.Name = "grbNavegacionDocentes";
            this.grbNavegacionDocentes.Size = new System.Drawing.Size(213, 58);
            this.grbNavegacionDocentes.TabIndex = 12;
            this.grbNavegacionDocentes.TabStop = false;
            this.grbNavegacionDocentes.Text = "Navegacion";
            // 
            // lblRegistrosDocentes
            // 
            this.lblRegistrosDocentes.AutoSize = true;
            this.lblRegistrosDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosDocentes.Location = new System.Drawing.Point(76, 24);
            this.lblRegistrosDocentes.Name = "lblRegistrosDocentes";
            this.lblRegistrosDocentes.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosDocentes.TabIndex = 10;
            this.lblRegistrosDocentes.Text = "x de n";
            // 
            // btnUltimoDocentes
            // 
            this.btnUltimoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocentes.Location = new System.Drawing.Point(172, 14);
            this.btnUltimoDocentes.Name = "btnUltimoDocentes";
            this.btnUltimoDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnUltimoDocentes.TabIndex = 3;
            this.btnUltimoDocentes.Text = ">|";
            this.btnUltimoDocentes.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteDocentes
            // 
            this.btnSiguienteDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocentes.Location = new System.Drawing.Point(139, 14);
            this.btnSiguienteDocentes.Name = "btnSiguienteDocentes";
            this.btnSiguienteDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnSiguienteDocentes.TabIndex = 2;
            this.btnSiguienteDocentes.Text = ">";
            this.btnSiguienteDocentes.UseVisualStyleBackColor = true;
            this.btnSiguienteDocentes.Click += new System.EventHandler(this.btnSiguienteDocentes_Click);
            // 
            // btnAnteriorDocentes
            // 
            this.btnAnteriorDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocentes.Location = new System.Drawing.Point(40, 18);
            this.btnAnteriorDocentes.Name = "btnAnteriorDocentes";
            this.btnAnteriorDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnAnteriorDocentes.TabIndex = 1;
            this.btnAnteriorDocentes.Text = "<";
            this.btnAnteriorDocentes.UseVisualStyleBackColor = true;
            this.btnAnteriorDocentes.Click += new System.EventHandler(this.btnAnteriorDocentes_Click);
            // 
            // btnPrimeroDocentes
            // 
            this.btnPrimeroDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroDocentes.Location = new System.Drawing.Point(7, 18);
            this.btnPrimeroDocentes.Name = "btnPrimeroDocentes";
            this.btnPrimeroDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnPrimeroDocentes.TabIndex = 0;
            this.btnPrimeroDocentes.Text = "|<";
            this.btnPrimeroDocentes.UseVisualStyleBackColor = true;
            // 
            // grbDatosDocentes
            // 
            this.grbDatosDocentes.Controls.Add(this.lblDuiDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtDuiDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblTelefonoDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtTelefonoDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblDireccionDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtDireccionDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblNombreDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtNombreDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblCodigoDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtCodigoDocentes);
            this.grbDatosDocentes.Enabled = false;
            this.grbDatosDocentes.Location = new System.Drawing.Point(8, 22);
            this.grbDatosDocentes.Name = "grbDatosDocentes";
            this.grbDatosDocentes.Size = new System.Drawing.Size(370, 258);
            this.grbDatosDocentes.TabIndex = 11;
            this.grbDatosDocentes.TabStop = false;
            this.grbDatosDocentes.Text = "Datos Docentes";
            // 
            // lblDuiDocentes
            // 
            this.lblDuiDocentes.AutoSize = true;
            this.lblDuiDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiDocentes.Location = new System.Drawing.Point(31, 200);
            this.lblDuiDocentes.Name = "lblDuiDocentes";
            this.lblDuiDocentes.Size = new System.Drawing.Size(43, 24);
            this.lblDuiDocentes.TabIndex = 9;
            this.lblDuiDocentes.Text = "Dui:";
            // 
            // txtDuiDocentes
            // 
            this.txtDuiDocentes.Location = new System.Drawing.Point(131, 204);
            this.txtDuiDocentes.Name = "txtDuiDocentes";
            this.txtDuiDocentes.Size = new System.Drawing.Size(100, 20);
            this.txtDuiDocentes.TabIndex = 8;
            // 
            // lblTelefonoDocentes
            // 
            this.lblTelefonoDocentes.AutoSize = true;
            this.lblTelefonoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoDocentes.Location = new System.Drawing.Point(31, 155);
            this.lblTelefonoDocentes.Name = "lblTelefonoDocentes";
            this.lblTelefonoDocentes.Size = new System.Drawing.Size(90, 24);
            this.lblTelefonoDocentes.TabIndex = 7;
            this.lblTelefonoDocentes.Text = "Telefono:";
            // 
            // txtTelefonoDocentes
            // 
            this.txtTelefonoDocentes.Location = new System.Drawing.Point(131, 159);
            this.txtTelefonoDocentes.Name = "txtTelefonoDocentes";
            this.txtTelefonoDocentes.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoDocentes.TabIndex = 6;
            // 
            // lblDireccionDocentes
            // 
            this.lblDireccionDocentes.AutoSize = true;
            this.lblDireccionDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionDocentes.Location = new System.Drawing.Point(31, 116);
            this.lblDireccionDocentes.Name = "lblDireccionDocentes";
            this.lblDireccionDocentes.Size = new System.Drawing.Size(95, 24);
            this.lblDireccionDocentes.TabIndex = 5;
            this.lblDireccionDocentes.Text = "Direccion:";
            // 
            // txtDireccionDocentes
            // 
            this.txtDireccionDocentes.Location = new System.Drawing.Point(131, 120);
            this.txtDireccionDocentes.Name = "txtDireccionDocentes";
            this.txtDireccionDocentes.Size = new System.Drawing.Size(251, 20);
            this.txtDireccionDocentes.TabIndex = 4;
            // 
            // lblNombreDocentes
            // 
            this.lblNombreDocentes.AutoSize = true;
            this.lblNombreDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDocentes.Location = new System.Drawing.Point(31, 76);
            this.lblNombreDocentes.Name = "lblNombreDocentes";
            this.lblNombreDocentes.Size = new System.Drawing.Size(84, 24);
            this.lblNombreDocentes.TabIndex = 3;
            this.lblNombreDocentes.Text = "Nombre:";
            // 
            // txtNombreDocentes
            // 
            this.txtNombreDocentes.Location = new System.Drawing.Point(131, 80);
            this.txtNombreDocentes.Name = "txtNombreDocentes";
            this.txtNombreDocentes.Size = new System.Drawing.Size(251, 20);
            this.txtNombreDocentes.TabIndex = 2;
            // 
            // lblCodigoDocentes
            // 
            this.lblCodigoDocentes.AutoSize = true;
            this.lblCodigoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDocentes.Location = new System.Drawing.Point(31, 37);
            this.lblCodigoDocentes.Name = "lblCodigoDocentes";
            this.lblCodigoDocentes.Size = new System.Drawing.Size(76, 24);
            this.lblCodigoDocentes.TabIndex = 1;
            this.lblCodigoDocentes.Text = "Codigo:";
            // 
            // txtCodigoDocentes
            // 
            this.txtCodigoDocentes.Location = new System.Drawing.Point(131, 41);
            this.txtCodigoDocentes.Name = "txtCodigoDocentes";
            this.txtCodigoDocentes.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDocentes.TabIndex = 0;
            // 
            // docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.lblBuscarDocentes);
            this.Controls.Add(this.txtBuscarDocentes);
            this.Controls.Add(this.grdDatosDocentes);
            this.Controls.Add(this.grbEdicionDocentes);
            this.Controls.Add(this.grbNavegacionDocentes);
            this.Controls.Add(this.grbDatosDocentes);
            this.Name = "docentes";
            this.Text = "docentes";
            this.Load += new System.EventHandler(this.docentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).EndInit();
            this.grbEdicionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.PerformLayout();
            this.grbDatosDocentes.ResumeLayout(false);
            this.grbDatosDocentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarDocentes;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.DataGridView grdDatosDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.GroupBox grbEdicionDocentes;
        private System.Windows.Forms.Button btnEliminarDocentes;
        private System.Windows.Forms.Button btnModificarDocentes;
        private System.Windows.Forms.Button btnNuevoDocentes;
        private System.Windows.Forms.GroupBox grbNavegacionDocentes;
        private System.Windows.Forms.Label lblRegistrosDocentes;
        private System.Windows.Forms.Button btnUltimoDocentes;
        private System.Windows.Forms.Button btnSiguienteDocentes;
        private System.Windows.Forms.Button btnAnteriorDocentes;
        private System.Windows.Forms.Button btnPrimeroDocentes;
        private System.Windows.Forms.GroupBox grbDatosDocentes;
        private System.Windows.Forms.Label lblDuiDocentes;
        private System.Windows.Forms.TextBox txtDuiDocentes;
        private System.Windows.Forms.Label lblTelefonoDocentes;
        private System.Windows.Forms.TextBox txtTelefonoDocentes;
        private System.Windows.Forms.Label lblDireccionDocentes;
        private System.Windows.Forms.TextBox txtDireccionDocentes;
        private System.Windows.Forms.Label lblNombreDocentes;
        private System.Windows.Forms.TextBox txtNombreDocentes;
        private System.Windows.Forms.Label lblCodigoDocentes;
        private System.Windows.Forms.TextBox txtCodigoDocentes;
    }
}