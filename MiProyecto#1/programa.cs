Console.WriteLine("Hola amigo :)");
Console.WriteLine("Este es un programa para la realizacion de operaciones con numeros.");
Console.WriteLine("Por favor sigue las instrucciones, de lo contrario habra un error.");

string nota1, notaM;
Console.WriteLine("Ingrese su texto para que lo imprima en Mayuscula");
nota1 = Console.ReadLine();
notaM = nota1.ToUpper();
Console.WriteLine("Este es su texto " + notaM);

string nota2, notam;
Console.WriteLine("Ingrese su texto para que lo imprima en Minusculas");
nota2 = Console.ReadLine();
notam = nota2.ToLower();
Console.WriteLine("Este es su texto " + notam);

string nota3;
Console.WriteLine("Ingrese su texto que quiere imprimir al reves");
nota3 = Console.ReadLine();
char[] notaInv = nota3.ToCharArray();
Array.Reverse(notaInv);
string notaNueva = new string(notaInv);
Console.WriteLine("Este es su texto " + notaNueva);

string nota4;
Console.WriteLine("Ingrese su cadena de texto");
nota4 = Console.ReadLine();
Console.WriteLine("Ingrese la palabra que quiere buscar");
string Pbuscar = Console.ReadLine();
string notaMinus = nota4.ToLower();
bool Pbuscada = nota4.Contains(notaMinus);

if (Pbuscada)
{
    Console.WriteLine("La palabra " + Pbuscar + " Fue encontrada ");
}
else
{
    Console.WriteLine("La palabra" + Pbuscar + "No fue encontrada en el texto ");
}

string nota5;
Console.WriteLine("Ingrese su texto del cual quiere contar las vocales");
nota5 = Console.ReadLine();
int Cvocales = nota5.Count(c => "aeiouAEIOU".Contains(c));
Console.WriteLine("Este es la cantidad de vocales que tiene su texto " + Cvocales);
