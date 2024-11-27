using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    public class B4
    {
        public double mang (double[] arr)
        {
            if(arr.Length == 0)
            {
                throw new ArgumentException("danh sách không được để trông");
            }
            double tong = 0;
            foreach (double i in arr)
            {
                tong += i;
            }
            return tong/ arr.Length;
        }
    }
}
