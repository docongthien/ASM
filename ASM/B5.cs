using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    public class B5
    {
        public int mang(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentException("nằm ngoài khoảng");
            }
            return array[index];
        }
    }
}
