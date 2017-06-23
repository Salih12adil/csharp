using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_tepy_float_point_ty
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine ("Minvalue ={0} Maxvalue={1}",flMin,flMax);
            Console.ReadKey();




            float flval = 1F / 3;
            double dlval = 1D / 3;
            decimal dcval = 1M / 3;

            Console.WriteLine("flout value={0} double value ={1} decimal value ={2}",flval, dlval,dcval);
            Console.ReadKey();
        }
    }
}
