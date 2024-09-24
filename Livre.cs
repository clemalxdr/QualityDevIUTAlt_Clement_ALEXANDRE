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

        // Constructeur

        public Livre(string titre, int numeroDeReference, int nombreExemplairesDisponibles, string auteur) : base(titre, numeroDeReference, nombreExemplairesDisponibles)
        {
            this.auteur = auteur;
        }

        // Afficher les informations du livre

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Auteur: " + auteur);
        }

        // Getters et setters

        public string Auteur
        {
            get => auteur;
        }
    }
}
