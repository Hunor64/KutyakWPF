using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class Kutyak
    {
        int id;
        int fajtaID;
        int nevID;
        int életkor;
        string utolsoOrvosiEllenorzes;

        public Kutyak(int id, int fajtaID, int nevID, int életkor, string utolsoOrvosiEllenorzes)
        {
            this.id = id;
            this.fajtaID = fajtaID;
            this.nevID = nevID;
            this.életkor = életkor;
            this.utolsoOrvosiEllenorzes = utolsoOrvosiEllenorzes;
        }

        public int Id { get => id;}
        public int FajtaID { get => fajtaID; }
        public int NevID { get => nevID;}
        public int Életkor { get => életkor;}
        public string UtolsoOrvosiEllenorzes { get => utolsoOrvosiEllenorzes;}
    }
}
