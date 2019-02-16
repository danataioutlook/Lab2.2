using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5 }; //  // Alternative syntax
            bool flag = false; //flag is a boolean type variable that can take the values 0 (false) or 1 (true)
            for (int i = 0; i < ar.Length; i++) // This is a test loop.
            {


                if (ar[i] <= 1)
                {
                    flag = false;
                    continue;
                }
                else
                {
                    for (int j = 2; j < ar[i]; j++)
                        if (ar[i] % j == 0)
                            flag = true;
                }
            }
            if (flag=true)
            {
              
                    Console.Write(ar.Length);

            }
        }
   
                }
            }
 





    
