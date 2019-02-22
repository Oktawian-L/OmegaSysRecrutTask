using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmgSys
{
    class COper
    {
        public float argumentFirst;
        public float argumentSecond;
        public string operation;
        public float response;

        public COper()
        {
        }

        public COper(int v1, int v2, string v3, int v4)
        {
            this.argumentFirst = v1;
            this.argumentSecond = v2;
            this.operation = v3;
            this.response= v4;
        }
    }
}
