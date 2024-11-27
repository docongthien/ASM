using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    public class B1
    {
        public double Tong2songuyen(double x , double y)
        {
            if (x>=0 && x <= 10 &&  y>=0 && y <= 10) 
            {
                if ((double.IsInteger(x) && double.IsInteger(y)))
                {
                    return x + y;
                }
                else
                {
                    throw new ArgumentException("a và b không phải là số nguyên");
                }
            }
            else
            {
                throw new ArgumentException("a và b không thuộc khổng từ 0-10");
            }
        }
    }
}
