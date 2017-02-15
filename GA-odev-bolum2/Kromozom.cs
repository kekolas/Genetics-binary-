using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_odev_bolum2
{
    class Kromozom
    {
        public int deger;
        public int fitness;
        public double olasilik = 0;
        public string[] binaryCode = new string[8];
        public void fitnessHesapla()
        {
            fitness = deger * deger + 22 * deger;

        }
        public void degerHesapla()
        {
            deger = 0;
            deger -= Convert.ToInt32(binaryCode[0]) * Convert.ToInt32(Math.Pow(2, 7));
            for (int i = 1; i < binaryCode.Length; i++)
            {
                deger += Convert.ToInt32(binaryCode[i]) * Convert.ToInt32(Math.Pow(2, 7-i));
            }
        }
        public Kromozom onePointCrossover(Kromozom partner, int breakPoint)
        {
            int i, j;
            Kromozom cocuk = new Kromozom();
            for (i = 0; i <= breakPoint; i++)
            {
                cocuk.binaryCode[i] = this.binaryCode[i];
            }
            for (i = breakPoint+1; i < binaryCode.Length; i++)
            {
                cocuk.binaryCode[i] = partner.binaryCode[i];
            }
            return cocuk;
        }
        

    }
}
