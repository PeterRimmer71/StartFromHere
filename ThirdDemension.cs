using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ThirdDemension : CoOrd
    {
        private int z;

        public ThirdDemension()
        {
            z = 0;
        }

        public int Z
        {
            get { return z; }
            set { z = value; }
        }
    }
}
