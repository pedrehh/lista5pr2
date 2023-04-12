using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista6pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           


            {


                int pro;

                Console.WriteLine("Você deseja qual exercicio ?");
                pro = int.Parse(Console.ReadLine());

                switch (pro)
                {
                    case 1:
                        int num;
                        Console.WriteLine("Digite o numero desejado");
                        num = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= num; i++)
                        {


                            Console.WriteLine(i);


                        }
                        break;
                    case 2:
                        int nume;
                        Console.WriteLine("Digite o numero desejado");
                        nume = int.Parse(Console.ReadLine());

                        for (int i = 0; i <= nume; i++)
                        {

                            if (i % 2 == 0)
                                Console.WriteLine(i);


                        }
                        break;

                    case 3:
                        int numer;
                        Console.WriteLine("Digite o numero desejado");
                        numer = int.Parse(Console.ReadLine());

                        for (int i = 1000; i >= numer; i--)
                        {

                            if (i % 2 == 0)
                                Console.WriteLine(i);


                        }
                        break;

                    case 4:
                        int numero1, numero2, som = 0;
                        Console.WriteLine("qual o primeiro numero desejado?");
                        numero1 = int.Parse(Console.ReadLine());


                        for (; numero1 <= 200;)
                        {
                            Console.WriteLine("digite o segundo numero:");
                            numero2 = int.Parse(Console.ReadLine());
                            if (numero2 > 0)
                                numero1 = numero1 + numero2;
                            Console.WriteLine(numero1);


                        }




                        break;

                    case 5:

                        int numero;
                        Console.WriteLine("Digite o numero desejado");
                        numero = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= numero; i++)
                        {

                            if (numero % i == 0)
                                Console.WriteLine(i);


                        }


                        break;

                    case 6:


                        int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;

                        Console.WriteLine("qual o num1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("qual o num2");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("qual o num3");
                        num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("qual o num4");
                        num4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("qual o num5");
                        num5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("qual o num6");
                        num6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("qual o num7");
                        num7 = int.Parse(Console.ReadLine());
                        Console.WriteLine("qual o num8");
                        num8 = int.Parse(Console.ReadLine());
                        Console.WriteLine("qual o num9");
                        num9 = int.Parse(Console.ReadLine());
                        Console.WriteLine("qual o num10");
                        num10 = int.Parse(Console.ReadLine());
                        for (int i = 1; ; i++)
                        {

                            if (num1 == i || num2 == i || num3 == i || num4 == i || num5 == i || num6 == i || num7 == i || num8 == i || num9 == i || num10 == i)
                            {
                                Console.WriteLine(i);
                            }


                        }
                        break;

                    case 7:

                        int numerrr, numerr, numeros = 0;
                        Console.WriteLine("qual o primeiro numero desejado?");
                        numerrr = int.Parse(Console.ReadLine());




                        for (int i = 1; numerrr > 0; i++)
                        {

                            Console.WriteLine("digite o segundo numero:");
                            numerr = int.Parse(Console.ReadLine());
                            if (numerr == 0)
                                break;
                            if (numerr % 2 == 0)
                            {
                                numerrr = numerrr + numerr;
                                Console.WriteLine(numerrr);
                            }
                            else
                            {

                                numeros = numeros + numerr;
                                Console.WriteLine(numeros);
                            }




                        }






                        break;


                }
            }
        }
    }
}
    

