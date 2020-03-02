using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryzhok
{
    public class Prygun
    {
        double Worstjump; 
		double Bestjump;
        string digits;
        

        public void SetWorstjump(double len)
        {
            Worstjump = len;
        }

        public double GetWorstjump()
        
        {
            return Worstjump;

        }

        public void SetBestjump(double len2)
        {
            Bestjump = len2;
        }

        public double GetBestjump()
        {
            return Bestjump;
        }

        public double Average()
        {
		     return Math.Round((Worstjump + Bestjump) / 2 ,3);
                
        }
        
        public double Record (double a)
        {
            return a - Bestjump;
        }

        public void SetDigits(string dig)
        {
            digits = dig;
        }

        public string GetDigits()
        {
            return digits;
        }

  
    }
}

