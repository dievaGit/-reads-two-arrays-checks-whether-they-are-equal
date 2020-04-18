using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant1 = 0, cant2 = 0;

            Console.WriteLine(" Write the number of element to the first arragement:");
            cant1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Write the number of element to the second arragement:");
            cant2 = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[cant1];
            int[] array2 = new int[cant2];

            if (cant1 == cant2)
            {
                Console.WriteLine(" ARRAY1");
                for (int i = 0; i < cant1; i++)
                {
                    Console.Write(" Write the number:");
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine(" ARRAY2");
                for (int i = 0; i < cant1; i++)
                {
                    Console.Write(" Write the number:");
                    array2[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine(" ARRAY1");
                for (int i = 0; i < cant1; i++)
                {
                    Console.Write(" {0}", array1[i]);
                   
                }
                Console.Write(" \n");

                Console.WriteLine(" ARRAY2");
                for (int i = 0; i < cant1; i++)
                {
                    Console.Write(" {0}", array2[i]);

                }

                for (int i = 0; i < cant1; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        Console.Write(" The arrangements are different");
                        break;
                    }
                }
                Console.Write(" The arrangements are equal");
            }
            else
            {
                Console.Write(" The arrangements are different");
            }
           
            Console.ReadKey();
        }
    }
}
