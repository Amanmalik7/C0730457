using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730457
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        
            {
                MethodA();
            }

             static void MethodA()

            {
                while (Peanut())
                {
                    Console.WriteLine(i);
                    if (i > 10)
                    {
                        return;
                    }
                }
            }
             static bool Peanut()
            {
                i++;
                return true;
            }
        }
    }


