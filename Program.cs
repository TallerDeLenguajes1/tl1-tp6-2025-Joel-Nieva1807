// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;

Console.WriteLine("valor de a:" + a);

int numero;
string cadena = Console.ReadLine();
int longitud = cadena.Length; //longitud de la cadena
string invertido = "";

if (int.TryParse(cadena, out numero) && numero > 0)//verifica que lo ingresado sea solo un numero
{
    for (int i = longitud - 1; i >= 0; i--)
    {

        invertido += cadena[i];

    }

    int.TryParse(invertido, out numero);
    Console.WriteLine("El numero invertido es: " + numero);
}
else
{
    Console.WriteLine("Ingrese un numero mayor que 0");
}

