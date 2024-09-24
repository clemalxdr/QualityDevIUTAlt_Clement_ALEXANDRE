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

        public Media? this[int numeroDeReference]
        {
            get { return medias.FirstOrDefault(objet => objet.NumeroDeReference == numeroDeReference); }
        }

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

        public void EmprunterMedia(Media media)
        {
            RetirerMedia(media);
            // Enregistrer les détails de l'emprunt
        }

        public void RendreMedia(Media media)
        {
            AjouterMedia(media);
            // Mettre à jour les détails de l'emprunt
        }

    }
}
