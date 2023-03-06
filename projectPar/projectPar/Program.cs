
int num;   //PARCIAL progra
int cont;
int suma = 0;
int i;

int valida = 0;

Console.WriteLine("HOLA, BIENVENIDO");
do
{
    try
    {
        do  //Inicia bucle do while para controlar que el numero que ingrese el usuario cumpla con que tiene que ser mayor a 0
        {
            Console.WriteLine("\n\nPor favor ingrese un numero entero positivo (Tiene que ser mayor a 0)");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 1)    //Lo implemente para mostrar error al ingresar un numero menor a 1
            {
                Console.WriteLine("\nERROR, ingrese un numero mayor a 0");
            }

        } while (num < 1);   //finaliza bucle do while

        cont = 1;   //Inicio del inciso 3
        while (cont <= num)
        {
            suma = suma + cont; //En la vuelta 1 del ciclo, suma valdra 1, pero en la siguiente vuelta del ciclo valdra 3, porque conteo valdra 2 por ir por la segundo vuelta y asi sucesivamente
            cont++;
        }        //Fin inciso 3
        Console.WriteLine("\nLos numeros enteros positivos menores o iguales al numero ingresado al inicio son: ");   //Inciso 4
        for (i = 1; i <= num; i++)   //en este bucle buscamos que nos muestre los numeros enteros positivos menor o iguales al numero ingresado al inicio del programa
        {
            Console.WriteLine(i);
        }             //Fin  inciso 4
        Console.WriteLine("\nLos numeros enteros impares menores o iguales al numero ingresado al inicio son: ");    //Inicio inciso 5
        for (i = 1; i <= num; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }

        }    //Fin inciso 5
        Console.WriteLine("\nLa Tabla de Multiplicar del 1 al 10 del numero ingresado: " + num + " es:");   //Inciso 6
        for (i = 1; i <= 10; i++)    //Utilice el bucle for para crear la tabla de multiplicar del numero ingresado
        {
            Console.WriteLine(+num + "X" + i + "=" + (num * i));
        }      //Fin inciso 6
        Console.WriteLine("\nLa secuencia de numeros empezando por el ingresado al inicio y aumentado en 2 hasta alcanzar un valor mayor a 20 es: ");
        int k = num;
        if (num > 20)
        {
            Console.WriteLine("COMO EL NUMERO QUE INGRESASTE ES MAYOR A 20 NO HAY UNA LISTA PARA MOSTRAR");
        }
        else
        {
            while (k <= 22)
            {
                Console.WriteLine(k);
                k += 2;
            }
        }

        Console.WriteLine("\nEl Numero Ingresado fue: " + num);
        Console.WriteLine("La Suma de los primeros N numeros es: " + suma);   //Inciso numero 8, con esto finaliza el codigo
    }

    catch (Exception ex)
    {
        valida = 1;
        Console.WriteLine("Ups, Ingresaste un dato incorrecto, ingresa nuevamente el dato solicitado correctamente");
        Console.WriteLine("El dato incorrecto que ingresaste es: " + ex.Message);
    }
} while (valida == 1);   //Finaliza bucle do while principal
