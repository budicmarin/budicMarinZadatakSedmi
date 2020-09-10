using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinZadatakSedmi
{
    class KlasaC
    {
       public int Zbroj(int[] brojevi)
        {
            int zbroj=0;
            for(int i=0;i<5;i++)
            {
                zbroj = zbroj+brojevi[i];
            }
            return zbroj;
        }
       public  double Prosjek(int[] brojevi)
        {
            int zbroj = Zbroj(brojevi);
            double pros = (double)zbroj / 5;
            return pros;
        }
    }
}
