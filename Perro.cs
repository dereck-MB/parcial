namespace Frutinovela;


/// Clase hija de Animal. Sobrescribe HacerSonido() con el ladrido del perro.
public class Perro : Animal
{
    // ": base(nombre)" envía el nombre al constructor de la clase Animal
    public Perro(string nombre) : base(nombre)
    {
    }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} (perro) dice: Guau, guau");
    }
}
