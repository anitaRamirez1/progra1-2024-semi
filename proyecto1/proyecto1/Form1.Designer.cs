namespace proyecto1
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            lblSaudavel = new Label();
            lbl = new Label();
            lblMensaje = new Label();
            lblNombre = new Label();
            lblCiudad = new Label();
            lblCorreo = new Label();
            lblMovil = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtCiudad = new TextBox();
            txtMovil = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblSaudavel
            // 
            resources.ApplyResources(lblSaudavel, "lblSaudavel");
            lblSaudavel.BackColor = SystemColors.ButtonFace;
            lblSaudavel.Name = "lblSaudavel";
            lblSaudavel.Click += lblSaudavel_Click;
            // 
            // lbl
            // 
            resources.ApplyResources(lbl, "lbl");
            lbl.BackColor = SystemColors.AppWorkspace;
            lbl.Name = "lbl";
            // 
            // lblMensaje
            // 
            resources.ApplyResources(lblMensaje, "lblMensaje");
            lblMensaje.BackColor = Color.FromArgb(128, 255, 128);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Click += label1_Click;
            // 
            // lblNombre
            // 
            resources.ApplyResources(lblNombre, "lblNombre");
            lblNombre.BackColor = Color.White;
            lblNombre.Name = "lblNombre";
            // 
            // lblCiudad
            // 
            resources.ApplyResources(lblCiudad, "lblCiudad");
            lblCiudad.BackColor = Color.White;
            lblCiudad.Name = "lblCiudad";
            // 
            // lblCorreo
            // 
            resources.ApplyResources(lblCorreo, "lblCorreo");
            lblCorreo.BackColor = Color.White;
            lblCorreo.Name = "lblCorreo";
            // 
            // lblMovil
            // 
            resources.ApplyResources(lblMovil, "lblMovil");
            lblMovil.BackColor = Color.White;
            lblMovil.Name = "lblMovil";
            // 
            // txtNombre
            // 
            resources.ApplyResources(txtNombre, "txtNombre");
            txtNombre.Name = "txtNombre";
            // 
            // txtCorreo
            // 
            resources.ApplyResources(txtCorreo, "txtCorreo");
            txtCorreo.Name = "txtCorreo";
            // 
            // txtCiudad
            // 
            resources.ApplyResources(txtCiudad, "txtCiudad");
            txtCiudad.Name = "txtCiudad";
            // 
            // txtMovil
            // 
            resources.ApplyResources(txtMovil, "txtMovil");
            txtMovil.Name = "txtMovil";
            // 
            // btnIngresar
            // 
            resources.ApplyResources(btnIngresar, "btnIngresar");
            btnIngresar.BackColor = Color.FromArgb(128, 255, 128);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // principal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(btnIngresar);
            Controls.Add(txtMovil);
            Controls.Add(txtCiudad);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(lblMovil);
            Controls.Add(lblCorreo);
            Controls.Add(lblCiudad);
            Controls.Add(lblNombre);
            Controls.Add(lblMensaje);
            Controls.Add(lbl);
            Controls.Add(lblSaudavel);
            Name = "principal";
            TransparencyKey = Color.MintCream;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaudavel;
        private Label lbl;
        private Label lblMensaje;
        private Label lblNombre;
        private Label lblCiudad;
        private Label lblCorreo;
        private Label lblMovil;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtCiudad;
        private TextBox txtMovil;
        private Button btnIngresar;
    }
}
