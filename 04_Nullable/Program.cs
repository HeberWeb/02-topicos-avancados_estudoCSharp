using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Struct - sendo por valor, contendo um limite minumo e maximo no caso do int, e não recebe valor null
            //int i = null;

            //Class - por referencia podendo receber valores null
            object o = null;

            Nullable<int> Idade = null;
            int? Idade2 = null;
        }
    }
}
