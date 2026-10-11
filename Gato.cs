namespace Frutinovela;

/// Clase hija de Animal. Sobrescribe HacerSonido() con el maullido del gato.
public class Gato : Animal
{
    public Gato(string nombre) : base(nombre)
    {
    }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} (gato) dice: Miau");
    }
}
