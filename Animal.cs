namespace Frutinovela;

/// Ejercicio 4 - Herencia.
/// Clase base de la que heredan Perro y Gato.
public class Animal
{
    // Solo se puede leer desde afuera (se asigna en el constructor)
    public string Nombre { get; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace un sonido misterioso...");
    }
}
