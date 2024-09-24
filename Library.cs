using GestionLibraire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLibraire
{
    internal class Library
    {
        private List<Media> medias = new List<Media>();
        private List<Emprunt> emprunts = new List<Emprunt>();
        public Media? this[int numeroDeReference]
        {
            get { return medias.FirstOrDefault(objet => objet.NumeroDeReference == numeroDeReference); }
        }


        // Ajouter un média à la bibliothèque
        public void AjouterMedia(Media media)
        {
            Media media1 = this[media.NumeroDeReference]!;
            if (media1 != null)
            {
                media1.NbExemplairesDisponibles++;
            }
            else
            {
                medias.Add(media);
            }
        }

        // Retirer un média de la bibliothèque
        public void RetirerMedia(Media media)
        {
            Media media1 = this[media.NumeroDeReference]!;
            if (media1 != null && media1.NbExemplairesDisponibles > 1)
            {
                media1.NbExemplairesDisponibles--;
            }
            else if (media1 != null && media1.NbExemplairesDisponibles == 1)
            {
                medias.Remove(media1);
            }
            else
            {
                Console.WriteLine("Le média n'existe pas.");
            }
        }

        // Emprunter un média
        public void EmprunterMedia(Media media, string nomUtilisateur)
        {
            Media media1 = this[media.NumeroDeReference]!;
            if (media1 != null && media1.NbExemplairesDisponibles > 0)
            {
                RetirerMedia(media);
                Emprunt emprunt = new Emprunt(media.NumeroDeReference, nomUtilisateur);
                emprunts.Add(emprunt);
                Console.WriteLine($"Le média '{media.Titre}' a été emprunté par {nomUtilisateur}.");
            }
            else
            {
                Console.WriteLine($"Le média '{media.Titre}' n'est pas disponible.");
            }
        }

        // Rendre un média
        public void RendreMedia(Media media, string nomUtilisateur)
        {
            Emprunt emprunt = emprunts.FirstOrDefault(e => e.NumeroDeReference == media.NumeroDeReference && e.NomUtilisateur == nomUtilisateur && e.DateRetour == null);
            if (emprunt != null)
            {
                emprunt.Retourner();
                AjouterMedia(media);
                Console.WriteLine($"Le média '{media.Titre}' a été retourné par {nomUtilisateur}.");
            }
            else
            {
                Console.WriteLine("Aucun emprunt trouvé pour ce média.");
            }
        }

        // Rechercher un média
        public List<Media> RechercherMedia(string critere)
        {
            var resultats = medias.Where(m =>
                m.Titre.Contains(critere, StringComparison.OrdinalIgnoreCase) ||
                (m is Livre livre && livre.Auteur.Contains(critere, StringComparison.OrdinalIgnoreCase)) ||
                (m is CD cd && cd.Artiste.Contains(critere, StringComparison.OrdinalIgnoreCase)) ||
                (m is DVD dvd && dvd.Titre.Contains(critere, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            if (resultats.Any())
            {
                Console.WriteLine($"Résultats de la recherche pour '{critere}':");
                foreach (var media in resultats)
                {
                    media.AfficherInfos();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Aucun résultat trouvé pour '{critere}'.");
            }

            return resultats;
        }

        // Lister les médias empruntés par un utilisateur
        public void ListerEmpruntsParUtilisateur(string nomUtilisateur)
        {
            var empruntsUtilisateur = emprunts.Where(e => e.NomUtilisateur == nomUtilisateur && e.DateRetour == null).ToList();
            if (empruntsUtilisateur.Any())
            {
                Console.WriteLine($"Médias empruntés par {nomUtilisateur}:");
                foreach (var emprunt in empruntsUtilisateur)
                {
                    Media media = this[emprunt.NumeroDeReference]!;
                    media?.AfficherInfos();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Aucun média emprunté par {nomUtilisateur}.");
            }
        }

        // Afficher les statistiques de la bibliothèque
        public void AfficherStatistiques()
        {
            int totalMedias = medias.Count;
            int totalEmpruntes = emprunts.Count(e => e.DateRetour == null);
            int totalDisponibles = medias.Sum(m => m.NbExemplairesDisponibles);

            Console.WriteLine("Statistiques de la bibliothèque:");
            Console.WriteLine($"Nombre total de médias: {totalMedias}");
            Console.WriteLine($"Nombre d'exemplaires empruntés: {totalEmpruntes}");
            Console.WriteLine($"Nombre d'exemplaires disponibles: {totalDisponibles}");
        }
    }
}
