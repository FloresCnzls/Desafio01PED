namespace Pacientes
{
    partial class Form2
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
            txtUsuario = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            Contraseña = new Label();
            btnIngresar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(153, 84);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 90);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Nombre:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(153, 131);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 8;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Location = new Point(75, 137);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(70, 15);
            Contraseña.TabIndex = 7;
            Contraseña.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(129, 179);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 23);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 37);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 10;
            label1.Text = "Ingresar";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 252);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(Contraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label label4;
        private TextBox txtContraseña;
        private Label Contraseña;
        private Button btnIngresar;
        private Label label1;
    }
}