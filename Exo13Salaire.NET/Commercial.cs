
using Exo11Salaire.NET;

namespace Exo13Salaire.NET
{
    // Je déclare que Commercial hérite de la classe Salarie
    internal class Commercial : Salarie
    {
        private int _chiffreAffaire;
        private double _commission;
        private double _comissionPourcentage;

        public int ChiffreAffaire { get => _chiffreAffaire; set => _chiffreAffaire = value; }
        public double Commission { get => _commission; set => _commission = value; }
        public double ComissionPourcentage { get => _comissionPourcentage; set => _comissionPourcentage = value; }
        // Je déclare un constructeur, "base" appelle tout les attributs de la classe mere Salarie
        public Commercial(string Matricule, string Categorie, string Service, string Nom, int Salaire, double ComissionPourcentage) : base(Matricule, Categorie, Service, Nom, Salaire)
        {
            ChiffreAffaire = 7500000;
            _comissionPourcentage = ComissionPourcentage;
            // Comission = chiffre d'affraire * 3% / 100
            Commission = ChiffreAffaire * (ComissionPourcentage / 100);
        }


        public void AfficherSalaire(Salarie salarie)
        {
            Console.WriteLine($"Le salaire de {salarie.Nom} (matricule: {salarie.Matricule} & categorie: {salarie.Categorie}) est de {salarie.Salaire} euros.");
        }

        public void AfficherSalaire(Commercial commercial, double Comission)
        {
            Console.WriteLine($"Le salaire de {commercial.Nom} (matricule: {commercial.Matricule} & categorie: {commercial.Categorie}) est de {commercial.Salaire} incluant une commission de {commercial.Commission} euros.");
        }


        public void ToString(Commercial commercial)
        {
        }

    

    }
}
