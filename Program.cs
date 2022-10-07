using System;

namespace Numero3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int temperatura,temp_alta,temp_baja,dia_baja,dia_alta;
            Console.Clear();
            Console.WriteLine("BUENAS!!...Bienvenido al sistema de control de temperatura semanal.");
        
            //inicializo variables
            dia_alta=0;
            dia_baja=0;
            temp_alta=-1000;
            temp_baja=1000;
            temperatura=0;
            //bucle for para repetir los dias, ifs para comparar temperaturas
            for(int i=1; i<=7 ;i++){
                Console.WriteLine("Ingrese la temperatura promedio de 7 dias consecutivamente");
                temperatura=Convert.ToInt32(Console.ReadLine());

                 if(temperatura>temp_alta)
                    {
                    temp_alta=temperatura;
                    dia_alta=i;
                    }                 
                if( temperatura<temp_baja)
                    {
                    temp_baja=temperatura;
                    dia_baja=i;
                    }
                }
                    //Mensaje de salida
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El dia de temperatura mas baja registrada fue el dia {0} con unos {1} grados de promedio.",dia_baja, temp_baja);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El dia de la temperatura mas alta registrada fue el dia {0} con unos {1} grados de promedio.",dia_alta,temp_alta);
            
        }
    }
}
