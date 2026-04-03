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
            Console.WriteLine("2. Salir");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

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