using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascara_Cpf_ou_CNpj
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            if (num.Length == 14)
                num = Convert.ToInt64(num).ToString(@"00\.000\.000\/0000\-00");
            
            else if (num.Length == 11)
                num = Convert.ToInt64(num).ToString(@"000\.000\.000\-00");

            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
