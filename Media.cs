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

        protected int nombreExemplairesDispobibles;

        public virtual void AfficherInfos()
        {
            Console.WriteLine("Titre: " + titre);
            Console.WriteLine("Numero de reference: " + numeroDeReference);
            Console.WriteLine("Nombre d'exemplaires disponibles: " + nombreExemplairesDispobibles);
        }
    }
}
