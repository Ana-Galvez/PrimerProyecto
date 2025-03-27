namespace PrimerProyecto
{
    partial class Form1
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
            btnIngresar = new Button();
            btnLimpiar = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDocumento = new Label();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnIngresar.Location = new Point(560, 73);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(123, 33);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnLimpiar.Location = new Point(560, 163);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 33);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblNombre.Location = new Point(79, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(91, 24);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblApellido.Location = new Point(79, 119);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(94, 24);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            lblApellido.Click += label2_Click;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblDocumento.Location = new Point(79, 163);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(128, 24);
            lblDocumento.TabIndex = 4;
            lblDocumento.Text = "Documento";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            txtNombre.Location = new Point(260, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 32);
            txtNombre.TabIndex = 5;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            txtDocumento.Location = new Point(260, 163);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(177, 32);
            txtDocumento.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic);
            txtApellido.Location = new Point(260, 116);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(177, 32);
            txtApellido.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtApellido);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnLimpiar;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private TextBox txtApellido;
    }
}
