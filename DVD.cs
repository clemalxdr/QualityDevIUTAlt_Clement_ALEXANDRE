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

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Duree: " + duree);
        }
    }
}
