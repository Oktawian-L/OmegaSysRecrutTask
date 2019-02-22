using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmgSys
{
    public class COper
    {
        public float argumentFirst { get; set; }
        public float argumentSecond { get; set; }
        public string operation { get; set; }
        public float response { get; set; }

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
