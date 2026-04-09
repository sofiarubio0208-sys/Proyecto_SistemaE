using System;
using SistemaColegio;

class Program
{
    static void Main()
    {
        ListaEstudiantes lista = new ListaEstudiantes();
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE ESTUDIANTES ===");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Buscar estudiante");
            Console.WriteLine("3. Eliminar estudiante");
            Console.WriteLine("4. Listar estudiantes");
            Console.WriteLine("5. Gestionar materias de un estudiante");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine() ?? "";

                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine() ?? "";

                    Console.Write("Dirección: ");
                    string direccion = Console.ReadLine() ?? "";

                    Console.Write("Celular: ");
                    string celular = Console.ReadLine() ?? "";

                    Console.Write("Email: ");
                    string email = Console.ReadLine() ?? "";

                    int codigo = lista.AgregarEstudiante(nombre, apellido, direccion, celular, email);
                    Console.WriteLine($"Estudiante agregado con código: {codigo}");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Write("Código a buscar: ");
                    if (int.TryParse(Console.ReadLine(), out int codBuscar))
                    {
                        NodoEstudiante encontrado = lista.BuscarEstudiante(codBuscar);
                        if (encontrado != null)
                        {
                            Console.WriteLine($"Encontrado: {encontrado.Nombre} {encontrado.Apellido}");
                        }
                        else
                        {
                            Console.WriteLine("Estudiante no encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Código inválido.");
                    }
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Write("Código a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int codEliminar))
                    {
                        if (lista.EliminarEstudiante(codEliminar))
                        {
                            Console.WriteLine("Estudiante eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("Estudiante no encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Código inválido.");
                    }
                    Console.ReadKey();
                    break;

                case "4":
                    lista.ListarEstudiantes();
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Write("Código del estudiante: ");
                    if (int.TryParse(Console.ReadLine(), out int codMaterias))
                    {
                        NodoEstudiante estudiante = lista.BuscarEstudiante(codMaterias);
                        if (estudiante == null)
                        {
                            Console.WriteLine("Estudiante no encontrado.");
                            Console.ReadKey();
                        }
                        else
                        {
                            MenuMaterias(estudiante);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Código inválido.");
                        Console.ReadKey();
                    }
                    break;

                case "6":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void MenuMaterias(NodoEstudiante estudiante)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine($"=== MATERIAS DE {estudiante.Nombre} {estudiante.Apellido} ===");
            Console.WriteLine("1. Agregar materia");
            Console.WriteLine("2. Buscar materia");
            Console.WriteLine("3. Eliminar materia");
            Console.WriteLine("4. Listar materias");
            Console.WriteLine("5. Volver");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    Console.Write("Nombre materia: ");
                    string nombre = Console.ReadLine() ?? "";

                    Console.Write("Nota: ");
                    if (!double.TryParse(Console.ReadLine(), out double nota))
                    {
                        Console.WriteLine("Nota inválida.");
                    }
                    else
                    {
                        if (estudiante.Materias.AgregarMateria(nombre, nota))
                            Console.WriteLine("Materia agregada.");
                        else
                            Console.WriteLine("Esa materia ya existe.");
                    }
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Write("Nombre materia: ");
                    string buscar = Console.ReadLine() ?? "";

                    NodoMateria m = estudiante.Materias.BuscarMateria(buscar);
                    if (m != null)
                        Console.WriteLine($"Materia: {m.Nombre} | Nota: {m.Nota}");
                    else
                        Console.WriteLine("Materia no encontrada.");

                    Console.ReadKey();
                    break;

                case "3":
                    Console.Write("Nombre materia: ");
                    string eliminar = Console.ReadLine() ?? "";

                    if (estudiante.Materias.EliminarMateria(eliminar))
                        Console.WriteLine("Materia eliminada.");
                    else
                        Console.WriteLine("Materia no encontrada.");

                    Console.ReadKey();
                    break;

                case "4":
                    estudiante.Materias.ListarMaterias();
                    Console.ReadKey();
                    break;

                case "5":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}