using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Class1
    {
        enum byti: long
        {
            li = 64,
            lo = 200,
        };
        byti f = byti.li;
        int b = 112;
        const byte c = 11;
        int[] d = {1, 2, 3, 4, 5,};
        //global::Lab_1.Properties.Resources.ResourseManager
        public Class1()
        {
            this.f = f;
            this.b = b;
            this.d = d;
            f = byti.lo;
            b = 1 + 2;
            byte k = c + 1;
            d[2] = 10;
        }
    }
}
