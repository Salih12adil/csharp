using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type__character_point_ty
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;

            int charMax = char.MaxValue;

            char myvar = 'G';
            int myvalue='G';
            
            Console.WriteLine("\nMin char ={0} \nMax char ={1} my \ncharacter={2} \nmy value number={3}"
                , charMin, charMax, myvar, myvalue );


            string mystring = "This is my varioble";
            Console.WriteLine("\nmystring is {0}" , mystring );

            bool myBool = true;
            Console.WriteLine("\nmy bool value is ={0}", myBool);


            Console.ReadKey();







        }
    }
}
