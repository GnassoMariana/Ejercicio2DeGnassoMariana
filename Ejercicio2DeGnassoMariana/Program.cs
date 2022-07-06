using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2DeGnassoMariana
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1 = 0, lado2 = 0, lado3 = 0;
            double perimetro=0, superficie=0;

            if (ValidarLados(lado1, lado2, lado3))
            {
                if (EsTriangulo(lado1, lado2, lado3))
                {
                    InformarTipo(lado1, lado2, lado3);
                    InformarCaracteristicas(lado1, lado2, lado3, perimetro, superficie);
                }
                else
                {
                    Console.WriteLine("Los lados ingresados no conforman un triangulo.");
                }
            }
            else
            {
                Console.WriteLine("Los lados ingresados no son validos.");
            }
            Console.ReadLine();
        }

        private static void InformarCaracteristicas(int lado1, int lado2, int lado3, double perimetro, double superficie)
        {
            double semip;
            perimetro = lado1 + lado2 + lado3;
            semip = perimetro / 2;
            superficie = Math.Sqrt(semip * (semip - lado1) * (semip - lado2) * (semip - lado3));

            Console.WriteLine($"El perimetro del triangulo es: {perimetro}");
            Console.WriteLine($"La superficie del triangulo es: {superficie}");
        }

        private static void InformarTipo(int lado1, int lado2, int lado3)
        {
            if (Math.Pow(lado1, 2) == Math.Pow(lado2, 2) + Math.Pow(lado3, 2))
            {
                Console.WriteLine("El triangulo ingresado es rectangulo");
            }
            else if (Math.Pow(lado1, 2) > Math.Pow(lado2, 2) + Math.Pow(lado3, 2))
            {
                Console.WriteLine("EL triangulo ingresado es obtusalgulo");
            }
            else if (Math.Pow(lado1, 2) < Math.Pow(lado2, 2) + Math.Pow(lado3, 2))
            {
                Console.WriteLine("El triangulo ingresado es acutangulo.");
            }
        }

        private static bool EsTriangulo(int lado1, int lado2, int lado3)
        {
            bool triangulo;
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                triangulo = true;
            }
            else
            {
                triangulo = false;
            }

            return triangulo;
        }

        private static bool ValidarLados(int lado1, int lado2, int lado3)
        {
           
                bool ladosValidos;
                Console.WriteLine("Ingresar la medida del primer lado:");
                lado1 = Convert.ToInt32(Console.ReadLine());
                if (lado1 > 0)
                {
                    Console.WriteLine("Ingresar la medida del segundo lado:");
                    lado2 = Convert.ToInt32(Console.ReadLine());

                    if (lado2 > 0)
                    {
                        Console.WriteLine("Ingresar la medida del tercer lado:");
                        lado3 = Convert.ToInt32(Console.ReadLine());

                        if (lado3 > 0)
                        {
                            ladosValidos = true;
                        }
                        else
                        {
                            ladosValidos = false;
                            Console.WriteLine("La medida del lado debe ser mayor a cero");
                        }
                    }
                    else
                    {
                        ladosValidos = false;
                        Console.WriteLine("La medida del lado debe ser mayor a cero");
                    }
                }
                else
                {
                    ladosValidos = false;
                    Console.WriteLine("La medida del lado debe ser mayor a cero");
                }

                return ladosValidos;

        }
    }
}
