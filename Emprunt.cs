using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLibraire
{
    internal class Emprunt
    {
        private string nomUtilisateur;

        public int numeroDeReference;

        private DateTime dateEmprunt;

        private DateTime? dateRetour;

        // Constructeur
        public Emprunt(int numeroDeReference, string nomUtilisateur)
        {
            this.nomUtilisateur = nomUtilisateur;
            this.numeroDeReference = numeroDeReference;
            this.dateEmprunt = DateTime.Now;
            this.dateRetour = null;
        }

        // Retourner un média

        public void Retourner()
        {
            dateRetour = DateTime.Now;
        }

        // Getters et setters

        public int NumeroDeReference
        {
            get => numeroDeReference;
        }

        public string NomUtilisateur
        {
            get => nomUtilisateur;
        }

        public DateTime DateEmprunt
        {
            get => dateEmprunt;
            set => dateEmprunt = value;
        }

        public DateTime? DateRetour
        {
            get => dateRetour;
            set => dateRetour = value;
        }

    }
}
