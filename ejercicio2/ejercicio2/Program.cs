
byte edad;   //Clase 2
byte num, num2;
int oper;
long numer, numer2;
string sald;


Console.WriteLine("Saludo:"); //Ejercicio 1
sald = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad (Introducir el numero)");
edad = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Wow, no aparentas los " + edad + " años que tienes");


Console.WriteLine("\n\nPor favor, ingrese el primer numero (el numero tiene que tener 2 cifras)");   //Ejercicio 2
num = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Por favor, ingrese el segundo numero (el numero tiene que tener 2 cifras)");
num2 = Convert.ToByte(Console.ReadLine());
oper = num * num2;
Console.WriteLine("El resultado de multiplicar los dos numeros anteriores es: " + oper);


Console.WriteLine("\n\nPor favor, ingrese el primer numero (numero largo)");     //Ejercicio 3
numer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Por favor, ingrese el primer numero (numero largo)");
numer2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("el resultado de sumar los dos numeros largos es: " + (numer + numer2));
Console.WriteLine("el resultado de restar los dos numeros largos es: " + (numer - numer2));
Console.WriteLine("el resultado de multiplicar los dos numeros largos es: " + (numer * numer2));

Console.WriteLine("FIN, ADIOS");
