namespace Frutinovela;

/// Implementa IVehiculo con mensajes propios de un carro.
public class Carro : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("Carro: giras la llave, el motor arranca y suena el radio con merengue.");
    }

    public void Apagar()
    {
        Console.WriteLine("Carro: sacas la llave y el motor se apaga.");
    }
}
