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




//-------------------EJERCICIO 2-------------------


int dato = menu();
calculos(dato);


void calculos(int dato){

    Console.WriteLine("Ingrese un número: ");
    string num1 = Console.ReadLine();
    Console.WriteLine("Ingrese otro número: ");
    string num2 = Console.ReadLine();

    int valor;
    float valorDiv;

    switch (dato){
        case 1: valor = suma(Convert.ToInt32(num1), Convert.ToInt32(num2));
        Console.WriteLine("El resultado es: " + valor);
        break;

        case 2: valor = resta(Convert.ToInt32(num1), Convert.ToInt32(num2));
        Console.WriteLine("El resultado es: " + valor);
        break;

        case 3: valor = multiplicacion(Convert.ToInt32(num1), Convert.ToInt32(num2));
        Console.WriteLine("El resultado es: " + valor);
        break;

        case 4: valorDiv = division(Convert.ToInt32(num1), Convert.ToInt32(num2));
        Console.WriteLine("El resultado es: " + valorDiv);
        break;

    }

    Console.WriteLine("\nDesea realizar otra operación?\nOPCIONES:\n[1]: Si\n[0]: No\n");
    string otraOp = Console.ReadLine();
    int decision = Convert.ToInt32(otraOp);

    if (decision == 1){
        dato = menu();
        calculos(dato);
    } else {
        Console.WriteLine("Adiós");
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

    return a/b;
}