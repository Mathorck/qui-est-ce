using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_QuiEstCe
{
    public class Case
    {
        private Personnage personnage;
        private bool validee;

        public Personnage Personnage
        {
            get { return personnage; }
            private set { personnage = value; }
        }

        public Case(Personnage prs)
        {
            if (prs == null)
                throw new ArgumentNullException("Le personnage ne peut pas être null");
            Personnage = prs;
            validee = false;
        }

        public void Selectionner()
        {
            validee = !validee;
        }
    }
}
