namespace Frutinovela;

/// Ejercicio 3 - Clases y objetos.
/// Representa a una persona con nombre y edad.
public class Persona
{
    // Propiedades públicas de la persona
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor: recibe los datos al momento de crear el objeto
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}
