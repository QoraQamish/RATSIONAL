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
            Ratsional[] ratsionals = new Ratsional[2];

            Console.WriteLine("Birinchi soni suratni kirting");
            int surat1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikkinchi soni mahrajni kiriting");
            int maxraj1 = int.Parse(Console.ReadLine());

            ratsionals[0] = new Ratsional(surat1, maxraj1);

            Console.WriteLine("Ikkinchi soni suratni kiriting");
            int surat2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikkinchi soni maxrajni kiriting");
            int maxraj2 = int.Parse(Console.ReadLine());

            ratsionals[1] = new Ratsional(surat2, maxraj2);

            Ratsional resalt = new Ratsional();
            //1-masala: Berilgan a va b ratsional sonlar o'zaro tengmi?
            Console.WriteLine("______________Tenglik________________\n");
            if (resalt.Tekshir(ratsionals[0], ratsionals[1]))
            {
                Console.WriteLine("Ushbu ikkita ratsional son o'zaro teng");
            }
            else
            {
                Console.WriteLine("Ushbu ikkita ratsional son o'zaro teng emas");
            }
            Console.WriteLine("\n____________Amal__________________");
            //2-masala: Berilgan a va b ratsional sonni yig'indisini toping
            Console.WriteLine("Beringan ratsional soni yig'indisi");
            resalt = resalt.Sum(ratsionals[0], ratsionals[1]);
            Console.WriteLine(resalt.surat+"/"+ resalt.maxraj);
            Console.WriteLine("Beringan ratsional soni ayirmasi");
            resalt = resalt.Ayir(ratsionals[0], ratsionals[1]);
            Console.WriteLine(resalt.surat + "/" + resalt.maxraj);
            Console.WriteLine("Beringan ratsional soni ko'paytmasi");
            resalt = resalt.Kopay(ratsionals[0], ratsionals[1]);
            Console.WriteLine(resalt.surat + "/" + resalt.maxraj);
            Console.WriteLine("Beringan ratsional soni bo'linmasi");
            resalt = resalt.Bol(ratsionals[0], ratsionals[1]);
            Console.WriteLine(resalt.surat + "/" + resalt.maxraj);

            //3-masala: Berilgan a va b ratsional sonni qisqartring:
            Console.WriteLine("________________Qisqatma_____________\n");
           
            Console.WriteLine("Berilgan a va b ratsional sonni qisqardi");
            resalt = resalt.Qisqartirish(ratsionals[0]);
            Console.WriteLine(resalt.surat+"/"+ resalt.maxraj);
            resalt = resalt.Qisqartirish(ratsionals[1]);
            Console.WriteLine(resalt.surat + "/" + resalt.maxraj);
           
            Console.WriteLine("\n________________Eng katasini topish______________");
            resalt = resalt.SortBuubly(ratsionals);
            Console.WriteLine(resalt.surat + "/" + resalt.maxraj);
            Console.ReadKey();

        }
    }
}
