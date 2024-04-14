using System;
using System.Collections.Generic;

// Clase Estudiante
public class Estudiante
{
    // Propiedades
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Carnet { get; set; }
    public bool Solvente { get; set; }

    // Constructor
    public Estudiante(string nombre, int edad, string carnet, bool solvente)
    {
        Nombre = nombre;
        Edad = edad;
        Carnet = carnet;
        Solvente = solvente;
    }

    // Método para mostrar información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
        Console.WriteLine("Carnet: " + Carnet);
        Console.WriteLine("Solvente: " + (Solvente ? "Sí" : "No"));
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de estudiantes
        List<Estudiante> estudiantes = new List<Estudiante>();

        // Agregar algunos estudiantes a la lista
        estudiantes.Add(new Estudiante("Juan", 20, "20210001", true));
        estudiantes.Add(new Estudiante("María", 22, "20210002", false));
        estudiantes.Add(new Estudiante("Pedro", 21, "20210003", true));

        // Mostrar información de todos los estudiantes
        Console.WriteLine("Información de los estudiantes:");
        foreach (Estudiante estudiante in estudiantes)
        {
            estudiante.MostrarInformacion();
        }

        // Modificar la información de un estudiante
        Console.WriteLine("Modificando información del estudiante...");
        Estudiante estudianteModificar = estudiantes[1];
        estudianteModificar.Nombre = "María Fernanda";
        estudianteModificar.Edad = 23;
        estudianteModificar.Solvente = true;

        // Mostrar la información actualizada del estudiante modificado
        Console.WriteLine("Información actualizada del estudiante:");
        estudianteModificar.MostrarInformacion();
    }
}
