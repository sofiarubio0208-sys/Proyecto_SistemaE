using System;

namespace SistemaColegio
{
    public class ListaMaterias
    {
        private NodoMateria cabeza;

        public ListaMaterias()
        {
            cabeza = null;
        }

        public bool AgregarMateria(string nombre, double nota)
        {
            if (BuscarMateria(nombre) != null)
                return false;

            NodoMateria nuevo = new NodoMateria(nombre, nota);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoMateria actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;

                actual.Siguiente = nuevo;
            }

            return true;
        }

        public NodoMateria BuscarMateria(string nombre)
        {
            NodoMateria actual = cabeza;

            while (actual != null)
            {
                if (actual.Nombre == nombre)
                    return actual;

                actual = actual.Siguiente;
            }

            return null;
        }

        public bool EliminarMateria(string nombre)
        {
            if (cabeza == null) return false;

            if (cabeza.Nombre == nombre)
            {
                cabeza = cabeza.Siguiente;
                return true;
            }

            NodoMateria actual = cabeza;

            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Nombre == nombre)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }

                actual = actual.Siguiente;
            }

            return false;
        }

        public void ListarMaterias()
        {
            if (cabeza == null)
            {
                Console.WriteLine("No hay materias registradas.");
                return;
            }

            NodoMateria actual = cabeza;

            while (actual != null)
            {
                Console.WriteLine($"Materia: {actual.Nombre} | Nota: {actual.Nota}");
                actual = actual.Siguiente;
            }
        }
    }
}