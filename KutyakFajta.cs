using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class KutyakFajta
    {
        int KutyaID;
        string nev;
        string eredetiNev;

        public KutyakFajta(int kutyaID, string nev, string eredetiNev)
        {
            KutyaID = kutyaID;
            this.nev = nev;
            this.eredetiNev = eredetiNev;
        }

        public int KutyaID1 { get => KutyaID;}
        public string Nev { get => nev;}
        public string EredetiNev { get => eredetiNev;}
    }
}
