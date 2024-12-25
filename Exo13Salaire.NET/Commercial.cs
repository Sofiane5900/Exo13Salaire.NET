
using Exo11Salaire.NET;

namespace Exo13Salaire.NET
{
    // Je déclare que Commercial hérite de la classe Salarie
    internal class Commercial : Salarie
    {
        private int _chiffreAffaire;
        private double _commission;
        

        public int ChiffreAffaire { get => _chiffreAffaire; set => _chiffreAffaire = value; }
        public double Commission { get => _commission; set => _commission = value; }

        // Je déclare un constructeur, "base" appelle tout les attributs de la classe mere Salarie
        public Commercial(string Matricule, string Service, string Nom, int Salaire) : base(Matricule, Service, Nom, Salaire)
        {
            ChiffreAffaire = 7500000;
            // Comission = chiffre d'affraire * 3% / 100
            Commission = ChiffreAffaire * (0.03 / 100);
        }


        public void AfficherSalaire(Commercial commercial)
        {
            Console.WriteLine($"Le salaire de {commercial.Nom} (matricule: {commercial.Matricule}) est de {commercial.Salaire + Commission} euros.");
        }

    

    }
}
