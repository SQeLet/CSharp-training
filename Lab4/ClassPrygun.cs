using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryzhok
{
    public class Prygun
    {
        int Worstjump;
		int Bestjump;


        public void SetWorstjump(int len)
        {
            Worstjump = len;
        }

        public int GetWorstjump()
        {
            return Worstjump;

        }

        public void SetBestjump(int len2)
        {
            Bestjump = len2;
        }
        public int GetBestjump()
        {
            return Bestjump;
        }
        public double Average()
        {
		     return (Worstjump + Bestjump) / 2.0;

        }
    }
}
