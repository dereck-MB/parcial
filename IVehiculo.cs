namespace Frutinovela;

/// Ejercicio 7 - Interfaces y abstracción.
/// Contrato que deben cumplir todos los vehículos: saber encender y apagar.
/// La interfaz dice QUÉ se hace, cada clase decide CÓMO.
public interface IVehiculo
{
    void Encender();
    void Apagar();
}
