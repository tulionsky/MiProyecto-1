
Console.WriteLine("Este es un programa para el uso de datos numericos.");
Console.WriteLine("Por favor sigue las instrucciones, de lo contrario habra un error.");

double noc = 0.5;
Console.WriteLine(" 1. Ingrese los datos que se le pide");
Console.WriteLine("-Ingrese la base del triangulo-");
double bas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-Ingrese la altura del triangulo-");
int alt = Convert.ToInt32(Console.ReadLine());
double respuesta = noc * bas * alt;
Console.WriteLine("El resultado es --> " + respuesta);

Console.WriteLine("2. Ingrese los datos que se le pide");
double pi = 3.14159;
double cal = 1.333333333;
Console.WriteLine("Ingrese el radio de la esfera");
double radio = Convert.ToInt32(Console.ReadLine());
double resul1 = radio * radio * radio;
double resul2 = cal * pi * resul1;
Console.WriteLine("El volumen de la esfera es --> " + resul2);


Console.WriteLine(" 3. Ingrese los datos que se le pide");
Console.WriteLine("Ingrese los datos del punto A");
Console.WriteLine("Ingrese el dato de X");
double Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el dato de Y");
double Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese los datos del punto B");
Console.WriteLine("Ingrese el dato de X");
double Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el dato de Y");
double By = Convert.ToInt32(Console.ReadLine());
double rDistancia = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2));
Console.WriteLine("La distancia entre los dos puntos es --> " + rDistancia);

Console.WriteLine(" 4. Ingrese los datos que se le pide");
Console.WriteLine("Ingrese los grados Celsius");
double cel = double.Parse(Console.ReadLine());
double resultadoFah = (cel * 9 / 5) + 32;
Console.WriteLine("La temperatura en Fahrenheit son --> " + resultadoFah);

Console.WriteLine("5. Ingrese los datos que se le pide");
Console.WriteLine("Ingrese los grados fahrenheit");
double fah = double.Parse(Console.ReadLine());
double resultadoCel = (fah - 32) * 5 / 9;
Console.WriteLine("La temperatura en Fahrenheit son --> " + resultadoCel);
