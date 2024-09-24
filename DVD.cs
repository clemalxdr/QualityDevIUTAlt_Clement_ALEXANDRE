using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLibraire
{
    internal class DVD : Media
    {
        private string duree;

        // Constructeur

        public DVD(string titre, int numeroDeReference, int nombreExemplairesDisponibles, string duree) : base(titre, numeroDeReference, nombreExemplairesDisponibles)
        {
            this.duree = duree;
        }
        
        // Afficher les informations du DVD

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Duree: " + duree);
        }
    }
}
