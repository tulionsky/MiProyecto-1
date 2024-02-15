using System.Timers;

int entero, num3, num4, ent;
decimal num1, dec;
float num2, flot;
char num5;


Console.WriteLine("Hola amigo :)");
Console.WriteLine("Este es un programa para la realizacion de convercion de numeros.");
Console.WriteLine("Por favor sigue las instrucciones, de lo contrario habra un error.");
Console.WriteLine("1. Por favor agrega el numero entero que desees convertir a decimal");
entero =Convert.ToInt32(Console.ReadLine());
num1 = (decimal)entero;
Console.WriteLine("**La conversion resulto exitosa**");
Console.WriteLine("El numero que ingresaste convertido en decimal es: " + num1);

Console.WriteLine("2. Por favor agrega el numero decimal que desees convertir a flotante");
dec = Convert.ToDecimal(Console.ReadLine());
num2 = (float)dec;
Console.WriteLine("**La conversion resulto exitosa**");
Console.WriteLine("El numero que ingresaste convertido en Flotante es: " + num2);

Console.WriteLine("3. Por favor agrega el numero flotante que desees convertir a entero");
flot = Convert.ToSingle(Console.ReadLine());
num3 = (Int32)flot;
Console.WriteLine("**La conversion resulto exitosa**");
Console.WriteLine("El numero que ingresaste convertido en Entero es: " + num3);

Console.WriteLine("4. Por favor agrega el numero Caracter que desees convertir a entero");
num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("**La conversion resulto exitosa**");
Console.WriteLine("El numero que ingresaste convertido en Entero es: " + num4);

Console.WriteLine("5. Por favor agrega el numero entero que desees convertir a caracter");
ent = Convert.ToInt32(Console.ReadLine());
num5 = (char)ent;
Console.WriteLine("**La conversion resulto exitosa**");
Console.WriteLine("El numero que ingresaste convertido en Entero es: " + num5); //En esta parte mostrara una letra, esa letra es la respectiva al numero que se ingreso.

