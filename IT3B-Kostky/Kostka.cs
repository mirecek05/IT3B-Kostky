using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3B_Kostky
{
    public class Kostka

    {
        private int hodnota;
        public int Value { get => hodnota; }

        public Kostka()
        {

        }
        public void Hod()
        {
            Random random = new Random();
            hodnota = random.Next(1, 7);
        }
    }
   
}
