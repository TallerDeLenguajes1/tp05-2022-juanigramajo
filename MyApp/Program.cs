// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



// Console.WriteLine("Trying second commit");



/* Console.WriteLine("Ingrese un texto: ");
string texto = Console.ReadLine();
int numero = 4;
Console.WriteLine("Usted escribió [" + texto + "]. | Y el número es [" + numero + "]"); */



/* Console.WriteLine("Ingrese un número: ");
string numero1 = Console.ReadLine();
Console.WriteLine("Ingrese otro número: ");
string numero2 = Console.ReadLine();
int resultado = Convert.ToInt32(numero1) + Convert.ToInt32(numero2);
Console.WriteLine("La suma de ambos números es: " + resultado);



Console.WriteLine("Ingrese otro número más: ");
string numero3 = Console.ReadLine();

double cuadrado = Cuadrado(Convert.ToDouble(numero3));

Console.WriteLine("El cuadrado del último número es: " + cuadrado);


double Cuadrado(double a){


    return a*a;
} */



//-------------------EJERCICIO 1-------------------

/* Console.WriteLine("Ingrese un número: ");
string num = Console.ReadLine();

int numInvertir = Convert.ToInt32(num);
int resto, numInvertido=0;

while (numInvertir > 0){
    
    resto = numInvertir % 10;
    numInvertir = numInvertir / 10;
    numInvertido = numInvertido * 10 + resto;
    
}

Console.WriteLine(numInvertido); */



//-------------------EJERCICIO 3-------------------


Console.WriteLine("Ingrese un número: ");
string num = Console.ReadLine();
double numero = Convert.ToDouble(num);


Console.WriteLine("El valor absoluto del número es: " + Math.Abs(numero));
Console.WriteLine("El cuadrado del número es: " + Math.Pow(numero, 2));
Console.WriteLine("La raíz cuadrada del número es: " + Math.Sqrt(numero));
Console.WriteLine("El seno del número es: " + Math.Sin(numero));
Console.WriteLine("El coseno del número es: " + Math.Cos(numero));
Console.WriteLine("La parte entera del número es: " + Math.Truncate(numero));


Console.WriteLine("Ingrese otro número: ");
string num1 = Console.ReadLine();
Console.WriteLine("Ingrese un número más: ");
string num2 = Console.ReadLine();


Console.WriteLine("El número máximo entre ambos números es: " + Math.Max(Convert.ToInt32(num1), Convert.ToInt32(num2)));
Console.WriteLine("El número mínimo entre ambos números es: " + Math.Min(Convert.ToInt32(num1), Convert.ToInt32(num2)));