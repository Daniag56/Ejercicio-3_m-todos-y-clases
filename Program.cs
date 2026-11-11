using System;

void Ejercicio1()
{
    Console.WriteLine("EJERCICIO 1");
    Console.Write("Tamano del array: ");
    int tamano = Convert.ToInt32(Console.ReadLine());
    int[] numeros = new int[tamano];
    int suma = 0;
    for (int i = 0; i < tamano; i++)
    {
        Console.Write($"Valor {i + 1}: ");
        numeros[i] = Convert.ToInt32(Console.ReadLine());
        suma = suma + numeros[i];
    }
    Console.WriteLine($"Suma: {suma}");
    Console.WriteLine($"Media: {(double)suma / tamano}");
}
Ejercicio1();

int ContarEspacios(string texto)
{
    int espacios = 0;
    for (int i = 0; i < texto.Length; i++)
    {
        if (texto[i] == ' ')
        {
            espacios++;
        }
    }
    return espacios;
}

void Ejercicio2()
{
    Console.WriteLine("EJERCICIO 2");
    Console.Write("Escribe un texto: ");
    string texto = Console.ReadLine();
    Console.WriteLine($"Espacios en blanco: {ContarEspacios(texto)}");
}
Ejercicio2();

long Factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    return n * Factorial(n - 1);
}

void Ejercicio3()
{
    Console.WriteLine("EJERCICIO 3");
    Console.Write("Numero: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"El factorial de {n} es {Factorial(n)}");
}
Ejercicio3();

bool EsPrimo(int n)
{
    if (n < 2)
    {
        return false;
    }
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

void Ejercicio4()
{
    Console.WriteLine("EJERCICIO 4");
    Console.Write("Numero: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (EsPrimo(n))
    {
        Console.WriteLine($"{n} es primo");
    }
    else
    {
        Console.WriteLine($"{n} no es primo");
    }
}
Ejercicio4();

long PotenciaIterativa(int baseNum, int exponente)
{
    long resultado = 1;
    for (int i = 0; i < exponente; i++)
    {
        resultado = resultado * baseNum;
    }
    return resultado;
}

long PotenciaRecursiva(int baseNum, int exponente)
{
    if (exponente == 0)
    {
        return 1;
    }
    return baseNum * PotenciaRecursiva(baseNum, exponente - 1);
}

void Ejercicio5()
{
    Console.WriteLine("EJERCICIO 5");
    Console.Write("Base: ");
    int baseNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Exponente: ");
    int exponente = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Iterativa: {PotenciaIterativa(baseNum, exponente)}");
    Console.WriteLine($"Recursiva: {PotenciaRecursiva(baseNum, exponente)}");
}
Ejercicio5();

bool Login(string usuario, string contrasena)
{
    return usuario == "usuario2DAM" && contrasena == "pass2DAM";
}

void Ejercicio6()
{
    Console.WriteLine("EJERCICIO 6");
    bool correcto = false;
    for (int intento = 1; intento <= 3; intento++)
    {
        Console.Write("Usuario: ");
        string usuario = Console.ReadLine();
        Console.Write("Contrasena: ");
        string contrasena = Console.ReadLine();
        if (Login(usuario, contrasena))
        {
            correcto = true;
            break;
        }
        Console.WriteLine("Usuario o contrasena incorrectos");
    }
    if (correcto)
    {
        Console.WriteLine("Login correcto");
    }
    else
    {
        Console.WriteLine("Has agotado los tres intentos");
    }
}
Ejercicio6();

bool EsMultiplo(int a, int b)
{
    return a % b == 0;
}

void Ejercicio7()
{
    Console.WriteLine("EJERCICIO 7");
    Console.Write("Numero 1: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Numero 2: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (EsMultiplo(a, b))
    {
        Console.WriteLine($"{a} es multiplo de {b}");
    }
    else if (EsMultiplo(b, a))
    {
        Console.WriteLine($"{b} es multiplo de {a}");
    }
    else
    {
        Console.WriteLine("Ninguno es multiplo del otro");
    }
}
Ejercicio7();

int SumaDigitos(int n)
{
    int suma = 0;
    while (n > 0)
    {
        suma = suma + n % 10;
        n = n / 10;
    }
    return suma;
}

void Ejercicio8()
{
    Console.WriteLine("EJERCICIO 8");
    Console.Write("Numero: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"La suma de los digitos es {SumaDigitos(n)}");
}
Ejercicio8();

int PosicionMenor(int[] numeros)
{
    int posicion = 0;
    for (int i = 1; i < numeros.Length; i++)
    {
        if (numeros[i] < numeros[posicion])
        {
            posicion = i;
        }
    }
    return posicion;
}

void Ejercicio9()
{
    Console.WriteLine("EJERCICIO 9");
    int[] numeros = { 8, 4, 9, 2, 7, 5 };
    Console.WriteLine($"El numero menor esta en la posicion {PosicionMenor(numeros)}");
}
Ejercicio9();

void Ejercicio10()
{
    Console.WriteLine("EJERCICIO 10");
    Banco banco = new Banco();
    banco.Operar();
    banco.ObtenerEstado();
}
Ejercicio10();

class Cliente
{
    string nombre;
    double cantidadTotal;

    public Cliente(string nombre)
    {
        this.nombre = nombre;
        cantidadTotal = 0;
    }

    public void Ingresar(double cantidad)
    {
        cantidadTotal = cantidadTotal + cantidad;
    }

    public void Sacar(double cantidad)
    {
        cantidadTotal = cantidadTotal - cantidad;
    }

    public double GetCantidadTotal()
    {
        return cantidadTotal;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"{nombre} tiene {cantidadTotal} en su cuenta");
    }
}

class Banco
{
    Cliente cliente1;
    Cliente cliente2;
    Cliente cliente3;

    public Banco()
    {
        cliente1 = new Cliente("Ana");
        cliente2 = new Cliente("Luis");
        cliente3 = new Cliente("Marta");
    }

    public void Operar()
    {
        cliente1.Ingresar(100);
        cliente2.Ingresar(250);
        cliente3.Ingresar(400);
    }

    public void ObtenerEstado()
    {
        double total = cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal();
        Console.WriteLine($"Dinero total en el banco: {total}");
        cliente1.MostrarInformacion();
        cliente2.MostrarInformacion();
        cliente3.MostrarInformacion();
    }
}
