using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLibraire
{
    internal class Livre : Media
    {
        private string auteur;

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Auteur: " + auteur);
        }
    }
}
