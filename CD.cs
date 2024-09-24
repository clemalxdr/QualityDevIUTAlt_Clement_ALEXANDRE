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

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Artiste: " + artiste);
        }
    }
}
