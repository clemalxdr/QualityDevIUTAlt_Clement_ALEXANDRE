using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLibraire
{
    internal class CD : Media
    {
        private string artiste;

        // Constructeur
        public CD(string titre, int numeroDeReference, int nombreExemplairesDisponibles, string artiste) : base(titre, numeroDeReference, nombreExemplairesDisponibles)
        {
            this.artiste = artiste;
        }

        // Afficher les informations du CD

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Artiste: " + artiste);
        }

        // Getters et setters

        public string Artiste
        {
            get => artiste;
        }
    }
}
