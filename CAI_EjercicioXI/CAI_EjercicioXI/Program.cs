using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioXI
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vocales = new char[5]
                {'a','e','i','o','u'};

            char[] consonantes = new char[21]
                {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'};

            char[] numerales = new char[10]
                {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            Console.WriteLine("Ingrese cualquier caracter: ");
            string respuesta = Console.ReadLine();

            bool encontrada = false;

            while (respuesta.Length > 1)
            {
                Console.WriteLine("Ingresa un solo caracter y presionar enter");
                respuesta = Console.ReadLine();
            }

            for (int i = 0; i < 1; i++)
            {
                encontrada = false;

                for (int j = 0; j < 5; j++)
                {
                    if (respuesta[i] == vocales[j])
                    {
                        encontrada = true;
                    }
                }
            }
            if (encontrada == true)
            {
                    Console.WriteLine("El caracter ingresado es una vocal");
            }
            else
            {
                    for (int i = 0; i < 1; i++)
                    {
                        for (int j = 0; j < 21; j++)
                        {
                            if (respuesta[i] == consonantes[j])
                            {
                                encontrada = true;
                            }
                        }
                    }

                    if (encontrada == true)
                    {
                        Console.WriteLine("El caracter ingresado es una consonante");
                    }
                    else
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            encontrada = false;
                            for (int j = 0; j < 10; j++)
                            {
                                if (respuesta[i] == numerales[j])
                                {
                                    encontrada = true;
                                }
                            }
                        }

                        if (encontrada == true)
                        {
                            Console.WriteLine("El caracter ingresado es un numeral");
                        }
                        else
                        {
                            Console.WriteLine("El caracter ingresado debe ser un caracter especial");
                        }
                    }

                }
            Console.ReadKey(true);
            }
        }
    }

