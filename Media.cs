using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLibraire
{
    internal class Media
    {
        protected string titre;

        protected int numeroDeReference;

        protected int nombreExemplairesDisponibles;

        // Constructeur

        public Media(string titre, int numeroDeReference, int nombreExemplairesDisponibles)
        {
            this.titre = titre;
            this.numeroDeReference = numeroDeReference;
            this.nombreExemplairesDisponibles = nombreExemplairesDisponibles;
        }

        // Afficher les informations du média

        public virtual void AfficherInfos()
        {
            Console.WriteLine("Titre: " + titre);
            Console.WriteLine("Numero de reference: " + numeroDeReference);
            Console.WriteLine("Nombre d'exemplaires disponibles: " + nombreExemplairesDisponibles);
        }

        // Getters et setters

        public string Titre
        {
            get => titre;
        }

        public int NumeroDeReference
        {
            get => numeroDeReference;
        }

        public int NbExemplairesDisponibles
        {
            get => nombreExemplairesDisponibles;
            set => nombreExemplairesDisponibles = value;
        }
    }
}
