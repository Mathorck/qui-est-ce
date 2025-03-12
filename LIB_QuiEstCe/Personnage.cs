using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LIB_QuiEstCe
{
    public class Personnage
    {
        private string nom;
        private string image;
        private List<Attribut> attributs;
        
        public string Nom
        {
            get { return nom; }
            private set { nom = value; }
        }
        public string Image
        {
            get { return image; }
            private set { image = value; }
        }
        public List<Attribut> Attributs
        {
            get { return Attributs; }
            private set { Attributs = value; }
        }

        public Personnage(string nom, string image, List<Attribut> attributs)
        {
            this.nom = nom;
            this.image = image;
            this.attributs = attributs;
        }

    }
}
