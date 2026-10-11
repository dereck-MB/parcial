namespace Frutinovela;

/// Ejercicio 6 - Encapsulamiento.
/// El saldo es privado: desde afuera solo se puede cambiar con Depositar()
/// y solo se puede consultar con ObtenerSaldo().

public class CuentaBancaria
{
    // Atributo privado: nadie fuera de esta clase puede modificarlo directamente
    private decimal saldo;

    public string Titular { get; }

    public CuentaBancaria(string titular)
    {
        Titular = titular;
        saldo = 0m; // la cuenta empieza en cero
    }


    /// Suma el monto al saldo. Rechaza montos de cero o negativos.
    public void Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto a depositar debe ser mayor que cero.");
            return;
        }

        saldo += monto;
        Console.WriteLine($"Depósito exitoso: RD${monto:N2}");
    }

    /// Devuelve el saldo actual para que quien llame lo pueda mostrar.
    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}
