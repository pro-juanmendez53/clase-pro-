
int año;      //EJERCICIO DADO EN CLASE
string name;
int day;
int year;
int op;

Console.WriteLine("Ingresa tu Nombre");
name = Console.ReadLine();

try
{
    Console.WriteLine("\n\nOPCIONES DISPONIBLES");
    Console.WriteLine("1) Lunes");
    Console.WriteLine("2) Martes");
    Console.WriteLine("3) Miercoles");
    Console.WriteLine("4) Jueves");
    Console.WriteLine("5) Viernes");
    Console.WriteLine("6) Sabado");
    Console.WriteLine("7) Domingo");

    Console.WriteLine("Ingresa el numero de opcion dependiendo en que dia naciste");
    day = Convert.ToInt32(Console.ReadLine());
    switch (day)
    {
        case 1:
            Console.WriteLine("Naciste en el dia Lunes");
            break;
        case 2:
            Console.WriteLine("Naciste en el dia Martes");
            break;
        case 3:
            Console.WriteLine("Naciste el dia Miercoles");
            break;
        case 4:
            Console.WriteLine("Naciste el dia Jueves");
            break;
        case 5:
            Console.WriteLine("Naciste el dia Viernes");
            break;
        case 6:
            Console.WriteLine("Naciste el dia Sabado");
            break;
        case 7:
            Console.WriteLine("Naciste el dia Domingo");
            break;
        default:
            Console.WriteLine("Ingresaste un numero de opcion fuera del rango");
            break;
    }


}
catch (Exception ex)
{
    Console.WriteLine("Ups, Ingresaste un dato incorrecto, Por favor reinicia el programa y vuelve a intentarlo");
    Console.WriteLine("la excepcion es: " + ex.Message);
}

Console.WriteLine("\n¿En que año naciste?");
year = Convert.ToInt32(Console.ReadLine());
if (year % 2 == 0)
{
    Console.WriteLine("El año de nacimiento es par");
}
else
{
    Console.WriteLine("El año es impar");
}
año = DateTime.Now.Year;
op = año - year;
Console.WriteLine("La edad que tu tienes es, " + op);

if (op <= 17)
{
    Console.WriteLine(name + ", sos patojo, frega todo lo que podas, deja buenas anecdotas");
}
else if (op == 18 || op == 19)
{
    Console.WriteLine(name + ", sos patojo con DPI, pero sentrate en tus metas y alejate del reggaeton");
}
else if (op >= 20 && op <= 29)
{
    Console.WriteLine(name + ", sos joven y aprovecha tu juventud, no metas la pata aun y se vale equivocar");
}
else if (op >= 30 && op <= 60)
{
    Console.WriteLine(name + ", sos adulto, disfruta tu vida profesional");
}
else
{
    Console.WriteLine(name + ", cosecha lo que sembraste");
}
Console.WriteLine(":D"); 

