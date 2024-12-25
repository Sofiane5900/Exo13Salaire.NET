
using Exo11Salaire.NET;

namespace Exo13Salaire.NET
{
    // Je déclare que Commercial hérite de la classe Salarie
    internal class Commercial : Salarie
    {
        private int _chiffreAffaire;
        private int _commission;

        public int ChiffreAffaire { get => _chiffreAffaire; set => _chiffreAffaire = value; }
        public int Commission { get => _commission; set => _commission = value; }

        // Je déclare un constructeur, "base" appelle tout les paramétres du constructeur Salarie
        public Commercial(int Matricule, string Service, string Nom, int Salaire, int ChiffreAffaire, int Comission) : base(Matricule, Service, Nom, Salaire)
        {
        }

   
    }
}
