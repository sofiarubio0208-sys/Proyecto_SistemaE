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

        public NodoEstudiante(int codigo, string nombre, string apellido,
                              string direccion, string celular, string email)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Celular = celular;
            Email = email;
            Siguiente = null;
        }
    }
}