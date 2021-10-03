using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        //   Reverse String
        //   Vinit = tinitV
        static void Main(string[] args)
        {
            
            string str = "Vinit", revstr=null;
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstr = revstr + str[i];
            }

            Console.WriteLine(revstr);
            Console.ReadLine();
        }
    }


