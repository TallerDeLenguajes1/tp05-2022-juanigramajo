// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



// Console.WriteLine("Trying second commit");



/* Console.WriteLine("\nIngrese un texto: ");
string texto = Console.ReadLine();
int numero = 4;
Console.WriteLine("\nUsted escribió [" + texto + "]. | Y el número es [" + numero + "]"); */



/* Console.WriteLine("\nIngrese un número: ");
string numero1 = Console.ReadLine();
Console.WriteLine("\nIngrese otro número: ");
string numero2 = Console.ReadLine();
int resultado = Convert.ToInt32(numero1) + Convert.ToInt32(numero2);
Console.WriteLine("\nLa suma de ambos números es: " + resultado);



Console.WriteLine("\nIngrese otro número más: ");
string numero3 = Console.ReadLine();

double cuadrado = Cuadrado(Convert.ToDouble(numero3));

Console.WriteLine("\nEl cuadrado del último número es: " + cuadrado);


double Cuadrado(double a){


    return a*a;
} */



//-------------------EJERCICIO 1-------------------

/* Console.WriteLine("\nIngrese un número: ");
string num = Console.ReadLine();

int numInvertir = Convert.ToInt32(num);
int resto, numInvertido=0;

while (numInvertir > 0){
    
    resto = numInvertir % 10;
    numInvertir = numInvertir / 10;
    numInvertido = numInvertido * 10 + resto;
    
}

Console.WriteLine(n\numInvertido); */




//-------------------EJERCICIO 2-------------------


/* int dato = menu();
calculos(dato);


void calculos(int dato){

    Console.WriteLine("\nIngrese un número: ");
    string num1 = Console.ReadLine();
    Console.WriteLine("\nIngrese otro número: ");
    string num2 = Console.ReadLine();

    int valor;
    float valorDiv;

    switch (dato){
        case 1: valor = suma(Convert.ToInt32(num1), Convert.ToInt32(num2));
        Console.WriteLine("\nEl resultado es: " + valor);
        break;

        case 2: valor = resta(Convert.ToInt32(num1), Convert.ToInt32(num2));
        Console.WriteLine("\nEl resultado es: " + valor);
        break;

        case 3: valor = multiplicacion(Convert.ToInt32(num1), Convert.ToInt32(num2));
        Console.WriteLine("\nEl resultado es: " + valor);
        break;

        case 4: valorDiv = division(Convert.ToInt32(num1), Convert.ToInt32(num2));
        Console.WriteLine("\nEl resultado es: " + valorDiv);
        break;

    }

    Console.WriteLine("\nDesea realizar otra operación?\nOPCIONES:\n[1]: Si\n[0]: No\n");
    string otraOp = Console.ReadLine();
    int decision = Convert.ToInt32(otraOp);

    if (decision == 1){
        dato = menu();
        calculos(dato);
    } else {
        Console.WriteLine("\nAdiós");
    }
}

int menu(){

    Console.WriteLine("\nOPCIONES:\n[1]: Suma\n[2]: Resta\n[3]: Multiplicación\n[4]: División\nIngrese que operación desea realizar: ");
    string opcion = Console.ReadLine();

    return Convert.ToInt32(opcion);
}


int suma(int a, int b){

    return a+b;
}

int resta(int a, int b){

    return a-b;
}

int multiplicacion(int a, int b){

    return a*b;
}

float division(int a, int b){

    while (b <= 0) {
        Console.WriteLine("\nError de formato, ingrese el denominador mayor que 0: ");
        b = Convert.ToInt32(Console.ReadLine());
    }

    return a/b;
} 

*/




//-------------------EJERCICIO 3-------------------


/* Console.WriteLine("\nIngrese un número: ");
string num = Console.ReadLine();
double numero = Convert.ToDouble(num);


Console.WriteLine("\nEl valor absoluto del número es: " + Math.Abs(numero));
Console.WriteLine("\nEl cuadrado del número es: " + Math.Pow(numero, 2));
Console.WriteLine("\nLa raíz cuadrada del número es: " + Math.Sqrt(numero));
Console.WriteLine("\nEl seno del número es: " + Math.Sin(numero));
Console.WriteLine("\nEl coseno del número es: " + Math.Cos(numero));
Console.WriteLine("\nLa parte entera del número es: " + Math.Truncate(numero));


Console.WriteLine("\nIngrese otro número: ");
string num1 = Console.ReadLine();
Console.WriteLine("\nIngrese un número más: ");
string num2 = Console.ReadLine();


Console.WriteLine("\nEl número máximo entre ambos números es: " + Math.Max(Convert.ToInt32(num1), Convert.ToInt32(num2)));
Console.WriteLine("\nEl número mínimo entre ambos números es: " + Math.Min(Convert.ToInt32(num1), Convert.ToInt32(num2))); */




//-------------------EJERCICIO 4-------------------

Console.WriteLine("\nIngrese una cadena: ");
string cadena = Console.ReadLine();


Console.WriteLine("\nAlgunas letras que forman parte de una cadena son: [" + cadena[1] + "] [" + cadena[4] + "]");


Console.WriteLine("\nLa longitud de la cadena es de [" + cadena.Length + "] caracteres");


Console.WriteLine("\nIngrese otra cadena: ");
string cadena2 = Console.ReadLine();
Console.WriteLine("\nAmbas cadenas concatenadas: " + cadena + cadena2);


Console.WriteLine("Ingrese la cantidad de caracteres para la subcadena: ");
string cantCaracteres = Console.ReadLine();
int caracteres = Convert.ToInt32(cantCaracteres);

Console.WriteLine("La subcadena es: " + cadena.Substring(caracteres));


foreach (char letra in cadena){
    Console.WriteLine(letra);
}


Console.WriteLine("\nLa cadena en mayúsculas: " + cadena.ToUpper());
Console.WriteLine("\nLa cadena en minúsculas: " + cadena.ToLower());


Console.WriteLine("\nIngrese una cadena para ser comparada con \"" + cadena + "\": ");
string cadena3 = Console.ReadLine();

int valores = cadena.CompareTo(cadena3);
if (valores == 0){

    Console.WriteLine("\nAmbas cadenas son iguales");

} else {

    if (valores < 0){

        Console.WriteLine("La cadena 1 es menor que la cadena 2");
    } else {

        Console.WriteLine("La cadena 1 es mayor que la cadena 2");
    }
}


string[] arreglo = cadena.Split(" ");

Console.WriteLine("\nIngrese una palabra: ");
string palabra = Console.ReadLine();
int cantOcurrencias = 0;

foreach (var comp in arreglo){

    if(comp.CompareTo(palabra) == 0){
        cantOcurrencias ++;
    }

}

Console.WriteLine("\nLa cantidad de veces que aparece " + palabra + " en " + cadena + " es: " + cantOcurrencias);