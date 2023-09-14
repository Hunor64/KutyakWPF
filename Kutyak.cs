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
        int eletkor;
        string utolsoOrvosiEllenorzes;

        public Kutyak(int id, int fajtaID, int nevID, int eletkor, string utolsoOrvosiEllenorzes)
        {
            this.id = id;
            this.fajtaID = fajtaID;
            this.nevID = nevID;
            this.eletkor = eletkor;
            this.utolsoOrvosiEllenorzes = utolsoOrvosiEllenorzes;
        }

        public int Id { get => id;}
        public int FajtaID { get => fajtaID; }
        public int NevID { get => nevID;}
        public int Eletkor { get => eletkor;}
        public string UtolsoOrvosiEllenorzes { get => utolsoOrvosiEllenorzes;}
    }
}
