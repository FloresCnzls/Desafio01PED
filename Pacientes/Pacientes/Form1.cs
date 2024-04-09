using System;
using System.Windows.Forms;

namespace Pacientes
{
    // Clase principal del formulario
    public partial class Form1 : Form
    {
        private Arbol arbol; // Instancia de la clase Arbol para almacenar los pacientes

        // Constructor del formulario
        public Form1()
        {
            InitializeComponent();
            arbol = new Arbol(); // Inicializaci�n del �rbol al crear el formulario
        }

        // Evento al hacer clic en el bot�n Agregar Paciente
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            // Capturar los valores ingresados por el usuario
            string nombre = txtNombre.Text;
            string genero = txtGenero.Text;
            string tipoSanguineo = txtTipoSanguineo.Text;
            string presionArterial = txtPresionArterial.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            bool fuma = checkBoxFuma.Checked;

            // Validar que se hayan ingresado todos los datos
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(genero) && !string.IsNullOrEmpty(tipoSanguineo) && !string.IsNullOrEmpty(presionArterial))
            {
                // Crear un nuevo objeto Paciente con los datos ingresados
                Paciente paciente = new Paciente(nombre, genero, tipoSanguineo, presionArterial, edad, fuma);

                // Insertar el paciente en el �rbol
                arbol.Insertar(paciente);

                // Determinar el riesgo asociado al paciente
                string riesgo = arbol.DeterminarRiesgo(paciente);

                // Actualizar la lista de pacientes en el formulario
                ActualizarListaPacientes();

                // Mostrar un mensaje con el resultado
                MessageBox.Show("Paciente agregado. Riesgo: " + riesgo);
            }
            else
            {
                // Mostrar un mensaje de error si faltan datos
                MessageBox.Show("Por favor ingrese todos los datos del paciente.");
            }
        }

        // Evento al hacer clic en el bot�n Buscar Pacientes
        private void btnBuscarPacientes_Click(object sender, EventArgs e)
        {
            // Capturar los valores ingresados por el usuario para la b�squeda
            string genero = txtGeneroBusqueda.Text;
            string tipoSanguineo = txtTipoSanguineoBusqueda.Text;
            string presionArterial = txtPresionArterialBusqueda.Text;

            // Buscar pacientes que cumplan con los criterios de b�squeda
            List<Paciente> pacientesEncontrados = arbol.BuscarPacientes(genero, tipoSanguineo, presionArterial);

            // Limpiar la lista de pacientes encontrados en el formulario
            listBoxPacientesEncontrados.Items.Clear();

            // Mostrar los pacientes encontrados en la lista del formulario
            foreach (Paciente paciente in pacientesEncontrados)
            {
                listBoxPacientesEncontrados.Items.Add("Nombre: " + paciente.Nombre + ", G�nero: " + paciente.Genero + ", Tipo Sangu�neo: " + paciente.TipoSanguineo + ", Presi�n Arterial: " + paciente.PresionArterial);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // M�todo para actualizar la lista de pacientes en el formulario
        private void ActualizarListaPacientes()
        {
            listBoxPacientes.Items.Clear(); // Limpiar la lista actual

            // Recorrer el �rbol en orden e insertar cada paciente en la lista
            RecorridoInorden(arbol.Raiz);
        }

        // M�todo recursivo para recorrer el �rbol en orden
        private void RecorridoInorden(Nodo raiz)
        {
            if (raiz != null)
            {
                RecorridoInorden(raiz.Izquierdo); // Recorrer el sub�rbol izquierdo
                listBoxPacientes.Items.Add("Nombre: " + raiz.Paciente.Nombre + ", G�nero: " + raiz.Paciente.Genero + ", Tipo Sangu�neo: " + raiz.Paciente.TipoSanguineo + ", Presi�n Arterial: " + raiz.Paciente.PresionArterial);
                RecorridoInorden(raiz.Derecho); // Recorrer el sub�rbol derecho
            }
        }
    }

    // Clase que representa a un paciente
    public class Paciente
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string TipoSanguineo { get; set; }
        public string PresionArterial { get; set; }
        public int Edad { get; set; }
        public bool Fuma { get; set; }

        // Constructor de la clase Paciente
        public Paciente(string nombre, string genero, string tipoSanguineo, string presionArterial, int edad, bool fuma)
        {
            Nombre = nombre;
            Genero = genero;
            TipoSanguineo = tipoSanguineo;
            PresionArterial = presionArterial;
            Edad = edad;
            Fuma = fuma;
        }
    }

    // Clase que representa a un nodo en el �rbol
    public class Nodo
    {
        public Paciente Paciente { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        // Constructor de la clase Nodo
        public Nodo(Paciente paciente)
        {
            Paciente = paciente;
            Izquierdo = null;
            Derecho = null;
        }
    }

    // Clase que representa un �rbol de pacientes
    public class Arbol
    {
        public Nodo Raiz; // Nodo ra�z del �rbol

        // Constructor de la clase Arbol
        public Arbol()
        {
            Raiz = null; // Inicializar la ra�z como nula al crear el �rbol
        }

        // M�todo para insertar un nuevo paciente en el �rbol
        public void Insertar(Paciente paciente)
        {
            Raiz = InsertarRec(Raiz, paciente); // Llamar al m�todo recursivo de inserci�n
        }

        // M�todo recursivo para insertar un paciente en el �rbol
        private Nodo InsertarRec(Nodo raiz, Paciente paciente)
        {
            if (raiz == null)
            {
                raiz = new Nodo(paciente); // Crear un nuevo nodo si la ra�z es nula
                return raiz;
            }

            // Insertar en el sub�rbol izquierdo si el paciente es menor en orden
            if (string.Compare(paciente.Genero, raiz.Paciente.Genero) < 0)
                raiz.Izquierdo = InsertarRec(raiz.Izquierdo, paciente);
            // Insertar en el sub�rbol derecho si el paciente es mayor en orden
            else if (string.Compare(paciente.Genero, raiz.Paciente.Genero) > 0)
                raiz.Derecho = InsertarRec(raiz.Derecho, paciente);

            return raiz;
        }

        // M�todo para buscar pacientes que cumplan con ciertos criterios
        public List<Paciente> BuscarPacientes(string genero, string tipoSanguineo, string presionArterial)
        {
            List<Paciente> pacientesEncontrados = new List<Paciente>(); // Lista para almacenar los pacientes encontrados
            BuscarRec(Raiz, genero, tipoSanguineo, presionArterial, ref pacientesEncontrados); // Llamar al m�todo recursivo de b�squeda
            return pacientesEncontrados; // Devolver la lista de pacientes encontrados
        }

        // M�todo recursivo para buscar pacientes en el �rbol
        private void BuscarRec(Nodo raiz, string genero, string tipoSanguineo, string presionArterial, ref List<Paciente> pacientesEncontrados)
        {
            if (raiz != null)
            {
                // Si el paciente cumple con los criterios de b�squeda, agregarlo a la lista de pacientes encontrados
                if (raiz.Paciente.Genero == genero && raiz.Paciente.TipoSanguineo == tipoSanguineo && raiz.Paciente.PresionArterial == presionArterial)
                {
                    pacientesEncontrados.Add(raiz.Paciente);
                }

                // Llamar recursivamente al m�todo para los sub�rboles izquierdo y derecho
                BuscarRec(raiz.Izquierdo, genero, tipoSanguineo, presionArterial, ref pacientesEncontrados);
                BuscarRec(raiz.Derecho, genero, tipoSanguineo, presionArterial, ref pacientesEncontrados);
            }
        }

        // M�todo para determinar el riesgo asociado a un paciente
        public string DeterminarRiesgo(Paciente paciente)
        {
            string riesgo = "";

            // Ejemplo de an�lisis de riesgo (ajusta seg�n tus necesidades)
            if (paciente.Edad > 50 && paciente.PresionArterial == "Alta" && paciente.Fuma)
            {
                riesgo = "Alto riesgo cardiovascular";
            }
            else if (paciente.Edad < 30 && paciente.TipoSanguineo == "O-" && !paciente.Fuma)
            {
                riesgo = "Bajo riesgo de enfermedades cardiacas";
            }
            else
            {
                riesgo = "Riesgo no determinado";
            }

            return riesgo;
        }
    }
   
}



