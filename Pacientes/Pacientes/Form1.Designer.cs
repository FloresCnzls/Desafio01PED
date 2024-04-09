namespace Pacientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtGenero = new TextBox();
            txtTipoSanguineo = new TextBox();
            txtPresionArterial = new TextBox();
            btnAgregarPaciente = new Button();
            listBoxPacientes = new ListBox();
            btnBuscarPacientes = new Button();
            txtTipoSanguineoBusqueda = new TextBox();
            txtPresionArterialBusqueda = new TextBox();
            txtGeneroBusqueda = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBoxPacientesEncontrados = new ListBox();
            txtEdad = new TextBox();
            Edad = new Label();
            checkBoxFuma = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Genero:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo Sanguineo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Presion Arterial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(90, 51);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(100, 23);
            txtGenero.TabIndex = 5;
            // 
            // txtTipoSanguineo
            // 
            txtTipoSanguineo.Location = new Point(110, 91);
            txtTipoSanguineo.Name = "txtTipoSanguineo";
            txtTipoSanguineo.Size = new Size(100, 23);
            txtTipoSanguineo.TabIndex = 6;
            // 
            // txtPresionArterial
            // 
            txtPresionArterial.Location = new Point(110, 134);
            txtPresionArterial.Name = "txtPresionArterial";
            txtPresionArterial.Size = new Size(100, 23);
            txtPresionArterial.TabIndex = 7;
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Location = new Point(135, 221);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(75, 23);
            btnAgregarPaciente.TabIndex = 8;
            btnAgregarPaciente.Text = "Agregar";
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // listBoxPacientes
            // 
            listBoxPacientes.FormattingEnabled = true;
            listBoxPacientes.ItemHeight = 15;
            listBoxPacientes.Location = new Point(245, 18);
            listBoxPacientes.Name = "listBoxPacientes";
            listBoxPacientes.Size = new Size(507, 184);
            listBoxPacientes.TabIndex = 9;
            // 
            // btnBuscarPacientes
            // 
            btnBuscarPacientes.Location = new Point(27, 494);
            btnBuscarPacientes.Name = "btnBuscarPacientes";
            btnBuscarPacientes.Size = new Size(75, 23);
            btnBuscarPacientes.TabIndex = 10;
            btnBuscarPacientes.Text = "Buscar";
            btnBuscarPacientes.UseVisualStyleBackColor = true;
            btnBuscarPacientes.Click += btnBuscarPacientes_Click;
            // 
            // txtTipoSanguineoBusqueda
            // 
            txtTipoSanguineoBusqueda.Location = new Point(110, 408);
            txtTipoSanguineoBusqueda.Name = "txtTipoSanguineoBusqueda";
            txtTipoSanguineoBusqueda.Size = new Size(100, 23);
            txtTipoSanguineoBusqueda.TabIndex = 16;
            // 
            // txtPresionArterialBusqueda
            // 
            txtPresionArterialBusqueda.Location = new Point(110, 327);
            txtPresionArterialBusqueda.Name = "txtPresionArterialBusqueda";
            txtPresionArterialBusqueda.Size = new Size(100, 23);
            txtPresionArterialBusqueda.TabIndex = 15;
            // 
            // txtGeneroBusqueda
            // 
            txtGeneroBusqueda.Location = new Point(101, 365);
            txtGeneroBusqueda.Name = "txtGeneroBusqueda";
            txtGeneroBusqueda.Size = new Size(100, 23);
            txtGeneroBusqueda.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 335);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 13;
            label5.Text = "Presion Arterial:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 408);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 12;
            label6.Text = "Tipo Sanguineo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 368);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 11;
            label7.Text = "Genero:";
            // 
            // listBoxPacientesEncontrados
            // 
            listBoxPacientesEncontrados.FormattingEnabled = true;
            listBoxPacientesEncontrados.ItemHeight = 15;
            listBoxPacientesEncontrados.Location = new Point(245, 327);
            listBoxPacientesEncontrados.Name = "listBoxPacientesEncontrados";
            listBoxPacientesEncontrados.Size = new Size(507, 154);
            listBoxPacientesEncontrados.TabIndex = 17;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(110, 177);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 18;
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.Location = new Point(12, 180);
            Edad.Name = "Edad";
            Edad.Size = new Size(36, 15);
            Edad.TabIndex = 19;
            Edad.Text = "Edad:";
            // 
            // checkBoxFuma
            // 
            checkBoxFuma.AutoSize = true;
            checkBoxFuma.Location = new Point(13, 221);
            checkBoxFuma.Name = "checkBoxFuma";
            checkBoxFuma.Size = new Size(74, 19);
            checkBoxFuma.TabIndex = 20;
            checkBoxFuma.Text = "Fumador";
            checkBoxFuma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(checkBoxFuma);
            Controls.Add(Edad);
            Controls.Add(txtEdad);
            Controls.Add(listBoxPacientesEncontrados);
            Controls.Add(txtTipoSanguineoBusqueda);
            Controls.Add(txtPresionArterialBusqueda);
            Controls.Add(txtGeneroBusqueda);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btnBuscarPacientes);
            Controls.Add(listBoxPacientes);
            Controls.Add(btnAgregarPaciente);
            Controls.Add(txtPresionArterial);
            Controls.Add(txtTipoSanguineo);
            Controls.Add(txtGenero);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtGenero;
        private TextBox txtTipoSanguineo;
        private TextBox txtPresionArterial;
        private Button btnAgregarPaciente;
        private ListBox listBoxPacientes;
        private Button btnBuscarPacientes;
        private TextBox txtTipoSanguineoBusqueda;
        private TextBox txtPresionArterialBusqueda;
        private TextBox txtGeneroBusqueda;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBoxPacientesEncontrados;
        private TextBox txtEdad;
        private Label Edad;
        private CheckBox checkBoxFuma;
    }
}
