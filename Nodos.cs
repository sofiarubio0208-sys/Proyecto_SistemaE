using System;

namespace SistemaColegio
{
    public class NodoEstudiante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public NodoEstudiante Siguiente { get; set; }
        public ListaMaterias Materias { get; set; } // lista de materias

        public NodoEstudiante(int codigo, string nombre, string apellido,
                              string direccion, string celular, string email)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Celular = celular;
            Email = email;
            Materias = new ListaMaterias(); // inicializa la lista
            Siguiente = null;
        }
    }

    public class NodoMateria
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }
        public NodoMateria Siguiente { get; set; }

        public NodoMateria(string nombre, double nota)
        {
            Nombre = nombre;
            Nota = nota;
            Siguiente = null;
        }
    }
}