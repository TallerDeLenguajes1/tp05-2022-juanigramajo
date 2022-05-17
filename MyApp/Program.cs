// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.WriteLine("Trying second commit");



/* Console.WriteLine("Ingrese un texto: ");
string texto = Console.ReadLine();
int numero = 4;
Console.WriteLine("Usted escribió [" + texto + "]. | Y el número es [" + numero + "]"); */



Console.WriteLine("Ingrese un número: ");
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
}