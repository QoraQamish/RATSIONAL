using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RATSIONAL
{
    public class Ratsional
    {
        public int surat { get; set; }
        public int maxraj { get; set; }
        public Ratsional()
        {

        }
        public  Ratsional(int _surat,int _maxraj)
        {
            this.surat = _surat;
            this.maxraj = _maxraj;
        }
        //Berilgan a va b ratsional sonni tekshirish
        public bool Tekshir(Ratsional ratsional1,Ratsional ratsional2)
        {
            this.surat = ratsional1.surat * ratsional2.maxraj;
            this.maxraj = ratsional1.maxraj * ratsional2.surat;

            if (this.surat
                ==this.maxraj) return true;
            return false;
        }

        // Berilgan a va b ratsional sonni yig'indisi
        public Ratsional Sum(Ratsional ratsional1, Ratsional ratsional2)
        {
            maxraj = ratsional1.maxraj * ratsional2.maxraj;
            surat = ratsional2.maxraj * ratsional1.surat + ratsional1.maxraj * ratsional2.surat;
            return this;
        }
    
        // Berilgan a va b ratsional sonni qisqartirish
        public Ratsional Qisqartirish(Ratsional ratsional)
        {
            this.surat = ratsional.surat;
            this.maxraj = ratsional.maxraj;
            for (int i = 2; i < surat/2; i++)
            {
                if (surat%i==0 && maxraj%i==0)
                {
                    surat=surat / i;
                    maxraj=maxraj / i;
                    i--;
                }
            }
            return this;
        }
    
    }
}
