using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class KutyakNeve
    {
        int kutyaID;
        string kutyaNeve;

        public KutyakNeve(int kutyaID, string kutyaNeve)
        {
            this.kutyaID = kutyaID;
            this.kutyaNeve = kutyaNeve;
        }

        public int KutyaID { get => kutyaID; }
        public string KutyaNeve { get => kutyaNeve; }
    }
}
