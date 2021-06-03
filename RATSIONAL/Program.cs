using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RATSIONAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Ratsional[] ratsionals = new Ratsional[3];
            ratsionals[0] = new Ratsional(12, 4);
            ratsionals[1] = new Ratsional(24, 6);
            ratsionals[2] = new Ratsional();
            //1-masala: Berilgan a va b ratsional sonlar o'zaro tengmi?
            if(ratsionals[2].Tekshir(ratsionals[0], ratsionals[1]))
            {
                Console.WriteLine("Ushbu ikkita ratsional son o'zaro teng");
            }
            else
            {
                Console.WriteLine("Ushbu ikkita ratsional son o'zaro teng emas");
            }
            //2-masala: Berilgan a va b ratsional sonni yig'indisini toping
            ratsionals[2] = ratsionals[2].Sum(ratsionals[0], ratsionals[1]);
            Console.WriteLine(ratsionals[2].surat+"/"+ratsionals[2].maxraj);

            //3-masala: Berilgan a va b ratsional sonni qisqartring:
            Console.WriteLine("Berilgan a va b ratsional sonni qisqardi");
           ratsionals[2]=ratsionals[2].Qisqartirish(ratsionals[2]);
            Console.WriteLine(ratsionals[2].surat+"/"+ratsionals[2].maxraj);

            Console.ReadKey();

        }
    }
}
