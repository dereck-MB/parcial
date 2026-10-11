using System.Text;

namespace Frutinovela;

internal static class Program
{
    // Nombre del grupo
    private const string NombreGrupo = "Frutinovela";

    private static void Main()
    {
        // Para que se vean bonito las tildes y la ñ en la consola
        Console.OutputEncoding = Encoding.UTF8;

        bool salir = false;

        // Menú principal: se repite hasta que el usuario elija salir
        while (!salir)
        {
            MostrarMenu();
            string? opcion = Console.ReadLine();
            Console.WriteLine();

            // Si no hay más entrada (null), salimos para no quedar en un ciclo infinito
            if (opcion == null)
            {
                break;
            }

            switch (opcion.Trim())
            {
                case "1": Ejercicio1_SintaxisYVariables(); break;
                case "2": Ejercicio2_EstructurasDeControl(); break;
                case "3": Ejercicio3_ClasesYObjetos(); break;
                case "4": Ejercicio4_Herencia(); break;
                case "5": Ejercicio5_Polimorfismo(); break;
                case "6": Ejercicio6_Encapsulamiento(); break;
                case "7": Ejercicio7_Interfaces(); break;
                case "8": EjecutarTodos(); break;
                case "0": salir = true; break;
                default: Console.WriteLine("Opción no válida, intenta de nuevo."); break;
            }

            if (!salir)
            {
                Console.WriteLine();
                Console.WriteLine("Presiona ENTER para volver al menú...");
                Console.ReadLine();
            }
        }

        Console.WriteLine($"¡Gracias por probar by{NombreGrupo}!");
    }

    //Muestra las opciones disponibles
    private static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine($"===== Proyecto C# - Equipo {NombreGrupo} =====");
        Console.WriteLine("1. Sintaxis básica y variables");
        Console.WriteLine("2. Estructuras de control");
        Console.WriteLine("3. Clases y objetos (Persona)");
        Console.WriteLine("4. Herencia (Animal, Perro, Gato)");
        Console.WriteLine("5. Polimorfismo (List<Animal>)");
        Console.WriteLine("6. Encapsulamiento (CuentaBancaria)");
        Console.WriteLine("7. Interfaces y abstracción (IVehiculo)");
        Console.WriteLine("8. Ejecutar todos los ejercicios");
        Console.WriteLine("0. Salir");
        Console.Write("Elige una opción: ");
    }

    //Corre los 7 ejercicios uno detrás de otro
    {
        Ejercicio1_SintaxisYVariables();
        Separador();
        Ejercicio2_EstructurasDeControl();
        Separador();
        Ejercicio3_ClasesYObjetos();
        Separador();
        Ejercicio4_Herencia();
        Separador();
        Ejercicio5_Polimorfismo();
        Separador();
        Ejercicio6_Encapsulamiento();
        Separador();
        Ejercicio7_Interfaces();
    }

    //decorativa para separar ejercicios
    private static void Separador()
    {
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
    }

   
    // EJERCICIO 1 - Sintaxis básica y variables
    private static void Ejercicio1_SintaxisYVariables()
    {
        Console.WriteLine("Ejercicio 1: Sintaxis básica y variables");

        // Mensaje de bienvenida con el nombre del grupo
        Console.WriteLine($"Bienvenidos al equipo {NombreGrupo}");

        // Variables de distintos tipos
        int cantidadFrutas = 12; 
        string fruta = "mango";
        double precioPorLibra = 45.75;
        bool hayEnExistencia = true;

        // Imprimimos cada variable
        Console.WriteLine($"Cantidad de frutas: {cantidadFrutas}");
        Console.WriteLine($"Fruta favorita: {fruta}");
        Console.WriteLine($"Precio por libra en RD$: {precioPorLibra}");
        Console.WriteLine($"¿Hay en existencia?: {hayEnExistencia}");
    }

    // EJERCICIO 2 - Estructuras de control
    private static void Ejercicio2_EstructurasDeControl()
    {
        Console.WriteLine("Ejercicio 2: Estructuras de control");

        // Pedimos un número y repetimos hasta que escriba uno válido
        int numero;
        Console.Write("Escribe un número entero: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Eso no es un número válido, intenta otra vez: ");
        }

        // Un número es par si al dividirlo entre 2 el residuo es 0
        if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es PAR.");
        }
        else
        {
            Console.WriteLine($"El número {numero} es IMPAR.");
        }

        // Bucle for: imprime del 1 al 10
        Console.WriteLine("Números del 1 al 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // EJERCICIO 3 - Clases y objetos
    private static void Ejercicio3_ClasesYObjetos()
    {
        Console.WriteLine("Ejercicio 3: Clases y objetos");

        //
        Persona integrante1 = new Persona("Rolando Joed", 21);
        Persona integrante2 = new Persona("Cinthia de la cruz Rosario", 21);

        // Cada objeto se presenta usando su propio método
        integrante1.Presentarse();
        integrante2.Presentarse();
        
    }

   
    // EJERCICIO 4 - Herencia
    private static void Ejercicio4_Herencia()
    {
        Console.WriteLine("Ejercicio 4: Herencia");

        // Perro y Gato heredan de Animal, pero cada uno tiene su sonido
        Perro perro = new Perro("Capitán");
        Gato gato = new Gato("Michi");

        perro.HacerSonido();
        gato.HacerSonido();
    }

    // EJERCICIO 5 - Polimorfismo
    private static void Ejercicio5_Polimorfismo()
    {
        Console.WriteLine("Ejercicio 5: Polimorfismo");

        // Una sola lista guarda objetos de distintos tipos (todos son Animal)
        List<Animal> animales = new List<Animal>
        {
            new Perro("Capitán"),
            new Gato("Michi"),
            new Perro("Rocky"),
            new Gato("Luna")
        };

        // Al pasar por la lista llamamos al mismo método, pero C# ejecuta
        // la versión correcta según el tipo real de cada objeto
        foreach (Animal animal in animales)
        {
            animal.HacerSonido();
        }
    }

    // EJERCICIO 6 - Encapsulamiento
    private static void Ejercicio6_Encapsulamiento()
    {
        Console.WriteLine("Ejercicio 6: Encapsulamiento");

        // Cuenta del colmado del equipo
        CuentaBancaria cuenta = new CuentaBancaria("Colmado Frutinovela");

        // El saldo no se toca directamente: solo con Depositar()
        cuenta.Depositar(1500.50m);
        cuenta.Depositar(499.50m);

        // Para ver el saldo usamos ObtenerSaldo()
        Console.WriteLine($"Saldo actual de {cuenta.Titular}: RD${cuenta.ObtenerSaldo():N2}");
    }

    // EJERCICIO 7 - Interfaces y abstracción
    private static void Ejercicio7_Interfaces()
    {
        Console.WriteLine("Ejercicio 7: Interfaces y abstracción");

        // Probamos cada clase por separado
        Carro carro = new Carro();
        Motocicleta moto = new Motocicleta();

        carro.Encender();
        carro.Apagar();
        moto.Encender();
        moto.Apagar();

        // Ambas se pueden tratar como IVehiculo (misma interfaz, distinto comportamiento)
        Console.WriteLine();
        Console.WriteLine("Ahora usando la interfaz IVehiculo:");
        List<IVehiculo> vehiculos = new List<IVehiculo> { carro, moto };
        foreach (IVehiculo vehiculo in vehiculos)
        {
            vehiculo.Encender();
        }
    }
}
