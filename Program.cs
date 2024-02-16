
using System;

class Program
{
    static void Main(string[] args)
    {
        // Conversión de número entero a decimal
        Console.WriteLine("Ingrese un número entero para convertirlo a decimal:");
        int entero = int.Parse(Console.ReadLine());
        decimal decimalNum = Convert.ToDecimal(entero);
        Console.WriteLine($"El número {entero} como decimal es: {decimalNum}");

        // Conversión de número decimal a flotante
        Console.WriteLine("Ingrese un número decimal para convertirlo a flotante:");
        decimal decimalInput = decimal.Parse(Console.ReadLine());
        float floatNum = Convert.ToSingle(decimalInput);
        Console.WriteLine($"El número {decimalInput} como flotante es: {floatNum}");

        // Conversión de número flotante a entero
        Console.WriteLine("Ingrese un número flotante para convertirlo a entero:");
        float floatInput = float.Parse(Console.ReadLine());
        int intNum = Convert.ToInt32(floatInput);
        Console.WriteLine($"El número {floatInput} como entero es: {intNum}");

        // Conversión de caracter a entero
        Console.WriteLine("Ingrese un caracter para convertirlo a entero:");
        char charInput = char.Parse(Console.ReadLine());
        int charToInt = (int)charInput;
        Console.WriteLine($"El caracter '{charInput}' como entero es: {charToInt}");

        // Conversión de entero a caracter
        Console.WriteLine("Ingrese un entero para convertirlo a caracter:");
        int intInput = int.Parse(Console.ReadLine());
        char intToChar = (char)intInput;
        Console.WriteLine($"El entero {intInput} como caracter es: {intToChar}");

        // Suma de dos números enteros
        Console.WriteLine("Ingrese dos números enteros para sumar:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int suma = num1 + num2;
        Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");

        // Resta de dos números decimales
        Console.WriteLine("Ingrese dos números decimales para restar:");
        decimal dec1 = decimal.Parse(Console.ReadLine());
        decimal dec2 = decimal.Parse(Console.ReadLine());
        decimal resta = dec1 - dec2;
        Console.WriteLine($"La resta de {dec1} y {dec2} es: {resta}");

        // Multiplicación de dos números flotantes
        Console.WriteLine("Ingrese dos números flotantes para multiplicar:");
        float float1 = float.Parse(Console.ReadLine());
        float float2 = float.Parse(Console.ReadLine());
        float multiplicacion = float1 * float2;
        Console.WriteLine($"La multiplicación de {float1} y {float2} es: {multiplicacion}");

        // División de dos números enteros
        Console.WriteLine("Ingrese dos números enteros para dividir:");
        int divNum1 = int.Parse(Console.ReadLine());
        int divNum2 = int.Parse(Console.ReadLine());
        int division = divNum1 / divNum2;
        Console.WriteLine($"La división de {divNum1} entre {divNum2} es: {division}");

        // Módulo de dos números enteros
        Console.WriteLine("Ingrese dos números enteros para calcular el módulo:");
        int modNum1 = int.Parse(Console.ReadLine());
        int modNum2 = int.Parse(Console.ReadLine());
        int modulo = modNum1 % modNum2;
        Console.WriteLine($"El módulo de {modNum1} entre {modNum2} es: {modulo}");

        // Leer una cadena y convertirla a mayúsculas
        Console.WriteLine("Ingrese una cadena de texto para convertirla a mayúsculas:");
        string texto = Console.ReadLine();
        string mayusculas = texto.ToUpper();
        Console.WriteLine($"La cadena en mayúsculas es: {mayusculas}");

        // Leer una cadena y convertirla a minúsculas
        Console.WriteLine("Ingrese una cadena de texto para convertirla a minúsculas:");
        string minusculas = texto.ToLower();
        Console.WriteLine($"La cadena en minúsculas es: {minusculas}");

        // Leer una cadena y imprimir al revés
        Console.WriteLine("Ingrese una cadena de texto para imprimir al revés:");
        char[] charArray = texto.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        Console.WriteLine($"La cadena al revés es: {reversed}");

        // Buscar una palabra en una cadena de texto
        Console.WriteLine("Ingrese una cadena de texto:");
        string textoBusqueda = Console.ReadLine();
        Console.WriteLine("Ingrese la palabra que desea buscar:");
        string palabraBuscar = Console.ReadLine();
        bool contienePalabra = textoBusqueda.Contains(palabraBuscar);
        Console.WriteLine($"La cadena {(contienePalabra ? "sí" : "no")} contiene la palabra '{palabraBuscar}'.");

        // Contar el número de vocales en una cadena de texto
        int contadorVocales = 0;
        foreach (char c in textoBusqueda.ToLower())
        {
            if ("aeiou".Contains(c))
                contadorVocales++;
        }
        Console.WriteLine($"El número de vocales en la cadena es: {contadorVocales}");

        // Calcular el área de un triángulo
        Console.WriteLine("Ingrese la base del triángulo:");
        double baseTriangulo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del triángulo:");
        double alturaTriangulo = double.Parse(Console.ReadLine());
        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Console.WriteLine($"El área del triángulo es: {areaTriangulo}");

        // Calcular el volumen de una esfera
        Console.WriteLine("Ingrese el radio de la esfera:");
        double radioEsfera = double.Parse(Console.ReadLine());
        double volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);
        Console.WriteLine($"El volumen de la esfera es: {volumenEsfera}");

        // Calcular la distancia entre dos puntos
        Console.WriteLine("Ingrese las coordenadas del primer punto (x1 y y1):");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese las coordenadas del segundo punto (x2 y y2):");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");

        // Convertir temperatura de Celsius a Fahrenheit
        Console.WriteLine("Ingrese la temperatura en grados Celsius:");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) +
