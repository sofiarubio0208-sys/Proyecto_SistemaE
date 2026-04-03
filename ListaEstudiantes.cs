namespace SistemaColegio
{
    public class ListaEstudiantes
    {
        private NodoEstudiante cabeza;
        private int contadorCodigo;

        public ListaEstudiantes()
        {
            cabeza = null;
            contadorCodigo = 1000;
        }

        public int AgregarEstudiante(string nombre, string apellido, string direccion,
                                     string celular, string email)
        {
            contadorCodigo++;

            NodoEstudiante nuevoEstudiante = new NodoEstudiante(
                contadorCodigo, nombre, apellido, direccion, celular, email);

            if (cabeza == null)
            {
                cabeza = nuevoEstudiante;
            }
            else
            {
                NodoEstudiante actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoEstudiante;
            }

            return contadorCodigo;
        }

        public NodoEstudiante BuscarEstudiante(int codigo)
        {
            NodoEstudiante actual = cabeza;

            while (actual != null)
            {
                if (actual.Codigo == codigo)
                    return actual;

                actual = actual.Siguiente;
            }

            return null;
        }

        public bool EliminarEstudiante(int codigo)
        {
            if (cabeza == null) return false;

            if (cabeza.Codigo == codigo)
            {
                cabeza = cabeza.Siguiente;
                return true;
            }

            NodoEstudiante actual = cabeza;

            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Codigo == codigo)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }

                actual = actual.Siguiente;
            }

            return false;
        }
        public void ListarEstudiantes()
{
    NodoEstudiante actual = cabeza;
    while (actual != null)
    {
        Console.WriteLine($"Código: {actual.Codigo} | Nombre: {actual.Nombre} {actual.Apellido}");
        actual = actual.Siguiente;
    }
}
    }
}