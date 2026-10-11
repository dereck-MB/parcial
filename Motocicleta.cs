namespace Frutinovela;

/// Implementa IVehiculo con mensajes propios de una motocicleta.
public class Motocicleta : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("Motocicleta: pisas el arranque y el motor ruge: brrrum brrrum!");
    }

    public void Apagar()
    {
        Console.WriteLine("Motocicleta: bajas la pata de cabra y apagas el motor.");
    }
}
