Console.WriteLine("Hola amigo :)");
Console.WriteLine("Este es un programa para la realizacion de operaciones con numeros.");
Console.WriteLine("Por favor sigue las instrucciones, de lo contrario habra un error.");

int num1, num2;
int resultado1;
Console.WriteLine("Ingrese los numeros enteros que quiere Sumar");
Console.WriteLine("Ingrese primer numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
num2 = int.Parse(Console.ReadLine());
resultado1 = num1 + num2;
Console.WriteLine("El resultado es " + resultado1);

decimal num3, num4, resultado2;
Console.WriteLine("Ingrese los numeros enteros que quiere Restar");
Console.WriteLine("Ingrese primer numero");
num3 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
num4 = decimal.Parse(Console.ReadLine());
resultado2 = num3 - num4;
Console.WriteLine("El resultado es " + resultado2);

float num5, num6, resultado3;
Console.WriteLine("Ingrese los numeros flotantes que quiere Multiplicar");
Console.WriteLine("Ingrese primer numero");
num5 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
num6 = float.Parse(Console.ReadLine());
resultado3 = num5 * num6;
Console.WriteLine("El resultado es " + resultado3);

int num7, num8, resultado4;
Console.WriteLine("Ingrese los numeros enteros que quiere Dividir");
Console.WriteLine("Ingrese primer numero");
num7 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
num8 = int.Parse(Console.ReadLine());
resultado4 = num7 / num8;
Console.WriteLine("El resultado es " + resultado4);

int num9, num10, resultado5;
Console.WriteLine("Ingrese los numeros enteros que quiere ver su modul");
Console.WriteLine("Ingrese primer numero");
num9 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
num10 = int.Parse(Console.ReadLine());
resultado5 = num9 % num10;
Console.WriteLine("El resultado de" + num9 + "entre" + num10 + "es el modulo " + resultado5);
