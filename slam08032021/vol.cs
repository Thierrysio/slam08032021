using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slam08032021
{
    class vol
    {
        public int id;
        public DateTime ladate;
        public DateTime heureD;
        public DateTime heureF;

        public vol(int id, DateTime ladate, DateTime heureD, DateTime heureF)
        {
            this.id = id;
            this.ladate = ladate;
            this.heureD = heureD;
            this.heureF = heureF;
        }
    }
}
