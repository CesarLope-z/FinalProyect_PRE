using System;
using System.IO;
struct Cancion
{
    public string Artista;
    public string Titulo;
    public int Duracion;
    public double Tamano;
}
class Program
{
    static void Main()
    {
        Console.Clear();
        Cancion c;
        Console.Write("Ingrese el Artista: ");
        c.Artista = Console.ReadLine();
        Console.Write("Ingrese el Titulo: ");
        c.Titulo = Console.ReadLine();
        Console.Write("Ingrese la Duracion (en segundos): ");
        c.Duracion = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Tamaño del archivo (en KB): ");
        c.Tamano = double.Parse(Console.ReadLine());
        Console.WriteLine("\nDatos de la Canción:");
        Console.WriteLine("Artista:  "+ c.Artista);
        Console.WriteLine("Titulo:   "+ c.Titulo);
        Console.WriteLine("Duración: "+ c.Duracion + "segundos");
        Console.WriteLine("Tamaño:   "+ c.Tamano);

        Console.ReadKey();
    }
}
