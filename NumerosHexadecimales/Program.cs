using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosHexadecimales
{
    class Program
    {
        
        static void Main()
        {
            int opcion;
            Console.Clear();

            Console.WriteLine("1.- Obtener hexadecimal");
            Console.WriteLine("2.- Suma de hexadecimales");
            Console.WriteLine("3.- Comparacion de esferaz");
            Console.WriteLine("4.- Salir");
            Console.WriteLine("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            string num;
            switch (opcion)
            {
                case 1:
                    ObtenerHexadecimal();
                    Main();
                    break;
                case 2:
                    SumarHexadecimales();
                    Main();
                    break;
                case 3:
                    ComparacionDeEsdefaz();
                    Main();
                    break;
                case 4:
                    Console.WriteLine("Gracias por utilizar el programa");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

        }

        static void ObtenerHexadecimal()
        {
            int Opcion1;
            int numero;
            string num;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Ingresa un numero entero no negativo");
                num = Console.ReadLine();

                Console.Clear();

                string hexadecimal = "";

                numero = int.Parse(num);
                hexadecimal = Obtenerhexadecimal(numero);

                if (numero > 0)
                {
                    Console.WriteLine("El numero hexadecimal es: " + hexadecimal);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Necesitas un numero entero no negativo");
                }

                Console.WriteLine("Deceas Obtener otro numero hexadecimal 1/Si 2/No");
                Opcion1 = int.Parse(Console.ReadLine());

            } while (Opcion1!=2);

        }

        static string Obtenerhexadecimal(int numero)
        {
            string hexadecimal1 = "";
            string hexadecimal = "";


            while (numero > 0)
            {
                int result;
                numero = Math.DivRem(numero, 16, out result);
                if (result == 10)
                    hexadecimal += "A";
                else if (result == 11)
                    hexadecimal += "B";
                else if (result == 12)
                    hexadecimal += "C";
                else if (result == 13)
                    hexadecimal += "D";
                else if (result == 14)
                    hexadecimal += "E";
                else if (result == 15)
                    hexadecimal += "F";
                else
                    hexadecimal += result;
            }

            for (int i = hexadecimal.Count(); i > 0; i--)
                hexadecimal1 += hexadecimal[i - 1];

            return hexadecimal1;

        }

        static void SumarHexadecimales()
        {
            int opcion;

            do
            {
                string num1, num2;
                int numero1, numero2;

                Console.Clear();

                Console.WriteLine("Ingresa el primer numero");
                num1 = Console.ReadLine();
                Console.WriteLine("Ingresa el segundo numero");
                num2 = Console.ReadLine();

                numero1 = int.Parse(num1);
                numero2 = int.Parse(num2);

                string hexadecimal1;
                string hexadecimal2;
                hexadecimal1 = Obtenerhexadecimal(numero1);
                hexadecimal2 = Obtenerhexadecimal(numero2);

                Console.WriteLine("El numero 1 en hexadecimal es de: {0}", hexadecimal1);
                Console.WriteLine("El numero 2 en hexadecimal es de: {0}", hexadecimal2);

                int suma;
                string sumahexadecimal;
                suma = numero1 + numero2;
                sumahexadecimal = Obtenerhexadecimal(suma);
                Console.WriteLine("La suma de los hexadecimales es de: {0}", sumahexadecimal);

                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Decesa hacer otra suma 1/Si o 2/No");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion!=2);
            

        }

        static void ComparacionDeEsdefaz()
        {

            int opcion;

            do
            {
                Console.Clear();
                int num;
                Console.WriteLine("Ingresa el numero de esferaz a comparar");
                num = int.Parse(Console.ReadLine());

                Double[] Volumen = new double[num];
                for (int i = 0; i < num; i++)
                    Volumen[i] = 1;

                for (int i = 0; i < num; i++)
                {
                    double radio;
                    Console.WriteLine("Ingresa el radio de la {0} ezfera",i+1);

                    radio = double.Parse(Console.ReadLine());

                    Volumen[i] = (4 * Math.PI * Math.Pow(radio, 3)) / 3;

                }

                double VolumenMayor = 0;

                for (int i = 0; i < num; i++)
                    for (int j = 1; j < num; j++)
                        if (Volumen[i] >= Volumen[j])
                            VolumenMayor = Volumen[i];
                        else
                            VolumenMayor = Volumen[j];

                Console.WriteLine("El mayor es: {0}", VolumenMayor);

                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Deceas comparar mas esferaz 1/Si o 2/No");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion!=2);
        }
    }
}
