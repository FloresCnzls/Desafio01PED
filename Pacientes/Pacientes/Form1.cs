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
            arbol = new Arbol(); // Inicialización del árbol al crear el formulario
        }

        // Evento al hacer clic en el botón Agregar Paciente
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

                // Insertar el paciente en el árbol
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

        // Evento al hacer clic en el botón Buscar Pacientes
        private void btnBuscarPacientes_Click(object sender, EventArgs e)
        {
            // Capturar los valores ingresados por el usuario para la búsqueda
            string genero = txtGeneroBusqueda.Text;
            string tipoSanguineo = txtTipoSanguineoBusqueda.Text;
            string presionArterial = txtPresionArterialBusqueda.Text;

            // Buscar pacientes que cumplan con los criterios de búsqueda
            List<Paciente> pacientesEncontrados = arbol.BuscarPacientes(genero, tipoSanguineo, presionArterial);

            // Limpiar la lista de pacientes encontrados en el formulario
            listBoxPacientesEncontrados.Items.Clear();

            // Mostrar los pacientes encontrados en la lista del formulario
            foreach (Paciente paciente in pacientesEncontrados)
            {
                listBoxPacientesEncontrados.Items.Add("Nombre: " + paciente.Nombre + ", Género: " + paciente.Genero + ", Tipo Sanguíneo: " + paciente.TipoSanguineo + ", Presión Arterial: " + paciente.PresionArterial);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Método para actualizar la lista de pacientes en el formulario
        private void ActualizarListaPacientes()
        {
            listBoxPacientes.Items.Clear(); // Limpiar la lista actual

            // Recorrer el árbol en orden e insertar cada paciente en la lista
            RecorridoInorden(arbol.Raiz);
        }

        // Método recursivo para recorrer el árbol en orden
        private void RecorridoInorden(Nodo raiz)
        {
            if (raiz != null)
            {
                RecorridoInorden(raiz.Izquierdo); // Recorrer el subárbol izquierdo
                listBoxPacientes.Items.Add("Nombre: " + raiz.Paciente.Nombre + ", Género: " + raiz.Paciente.Genero + ", Tipo Sanguíneo: " + raiz.Paciente.TipoSanguineo + ", Presión Arterial: " + raiz.Paciente.PresionArterial);
                RecorridoInorden(raiz.Derecho); // Recorrer el subárbol derecho
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

    // Clase que representa a un nodo en el árbol
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

    // Clase que representa un árbol de pacientes
    public class Arbol
    {
        public Nodo Raiz; // Nodo raíz del árbol

        // Constructor de la clase Arbol
        public Arbol()
        {
            Raiz = null; // Inicializar la raíz como nula al crear el árbol
        }

        // Método para insertar un nuevo paciente en el árbol
        public void Insertar(Paciente paciente)
        {
            Raiz = InsertarRec(Raiz, paciente); // Llamar al método recursivo de inserción
        }

        // Método recursivo para insertar un paciente en el árbol
        private Nodo InsertarRec(Nodo raiz, Paciente paciente)
        {
            if (raiz == null)
            {
                raiz = new Nodo(paciente); // Crear un nuevo nodo si la raíz es nula
                return raiz;
            }

            // Insertar en el subárbol izquierdo si el paciente es menor en orden
            if (string.Compare(paciente.Genero, raiz.Paciente.Genero) < 0)
                raiz.Izquierdo = InsertarRec(raiz.Izquierdo, paciente);
            // Insertar en el subárbol derecho si el paciente es mayor en orden
            else if (string.Compare(paciente.Genero, raiz.Paciente.Genero) > 0)
                raiz.Derecho = InsertarRec(raiz.Derecho, paciente);

            return raiz;
        }

        // Método para buscar pacientes que cumplan con ciertos criterios
        public List<Paciente> BuscarPacientes(string genero, string tipoSanguineo, string presionArterial)
        {
            List<Paciente> pacientesEncontrados = new List<Paciente>(); // Lista para almacenar los pacientes encontrados
            BuscarRec(Raiz, genero, tipoSanguineo, presionArterial, ref pacientesEncontrados); // Llamar al método recursivo de búsqueda
            return pacientesEncontrados; // Devolver la lista de pacientes encontrados
        }

        // Método recursivo para buscar pacientes en el árbol
        private void BuscarRec(Nodo raiz, string genero, string tipoSanguineo, string presionArterial, ref List<Paciente> pacientesEncontrados)
        {
            if (raiz != null)
            {
                // Si el paciente cumple con los criterios de búsqueda, agregarlo a la lista de pacientes encontrados
                if (raiz.Paciente.Genero == genero && raiz.Paciente.TipoSanguineo == tipoSanguineo && raiz.Paciente.PresionArterial == presionArterial)
                {
                    pacientesEncontrados.Add(raiz.Paciente);
                }

                // Llamar recursivamente al método para los subárboles izquierdo y derecho
                BuscarRec(raiz.Izquierdo, genero, tipoSanguineo, presionArterial, ref pacientesEncontrados);
                BuscarRec(raiz.Derecho, genero, tipoSanguineo, presionArterial, ref pacientesEncontrados);
            }
        }

        // Método para determinar el riesgo asociado a un paciente
        public string DeterminarRiesgo(Paciente paciente)
        {
            string riesgo = "";

            // Ejemplo de análisis de riesgo (ajusta según tus necesidades)
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



