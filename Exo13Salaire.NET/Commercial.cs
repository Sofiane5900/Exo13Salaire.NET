using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo11Salaire.NET;

namespace Exo13Salaire.NET
{
    // Je déclare que Commercial hérite de la classe Salarie
    internal class Commercial : Salarie
    {
        
        // Je déclare un constructeur, "base" appelle tout les paramétres du constructeur Salarie
        public Commercial(int Matricule, string Service, string Nom, int Salaire) : base(Matricule, Service, Nom, Salaire)
        {
        }
    }
}
