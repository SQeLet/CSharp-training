using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room
{
    public class MyRoom
    {
        int length;
        int width;
        public void SetLength(int len)
        {
            length = len;
        }
        public int GetLength()
        {
            return length;
        }
        public void SetWidth(int w)
        {
            width = w;
        }
        public int GetWidth()
        {
            return width;
        }
        public int Perimeter()
        {
            return 2 * (length + width);
        }
        public int Square()
        {
            return length * width;
        }
        public bool CheckSq()
        {
            if (length == width)
                return true;
            else
                return false;
        }

        public string Category()
        {
            string s = "";
            if (Square() > 40)
                s = "Зал";
            if (Square() <= 40 && Square() > 24)
                s = "Большая комната";
            if (Square() <= 24 && Square() > 14)
                s = "Обычная комната";
            if (Square() <= 14 && Square() > 8)
                s = "Маленькая комната";
            if (Square() < 9)
                s = "Каморка";
            return s;



        }
       /// <summary>
       /// Вычисление факториала
       /// </summary>
       /// <param name="n">Число, факториал которого вычисляется</param>
       /// <returns></returns> 
        private double Fact(int n)
        {
            double f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;
                return f;
        }
        /// <summary>
        /// Число размещений детей
        /// </summary>
        /// <param name="countChildren">Число детей</param>
        /// <param name="countAngles">Число свободных углов</param>
        /// <returns></returns>
        public int ChildrenDispos(int countChildren, int countAngles)
        {
            return Convert.ToInt32(Fact(countChildren)/Fact(countChildren-countAngles));
        }

    }

}
