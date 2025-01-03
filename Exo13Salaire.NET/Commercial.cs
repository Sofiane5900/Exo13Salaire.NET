using Exo11Salaire.NET;

namespace Exo13Salaire.NET
{
    // Je déclare que Commercial hérite de la classe Salarie
    internal class Commercial : Salarie
    {
        private int _chiffreAffaire;
        private double _commission;
        private double _comissionPourcentage;

        public int ChiffreAffaire
        {
            get => _chiffreAffaire;
            set => _chiffreAffaire = value;
        }

        public double CommissionPourcentage
        {
            get => _comissionPourcentage;
            set => _comissionPourcentage = value;
        }

        // Je déclare un constructeur, "base" appelle tout les attributs de la classe mere Salarie
        public Commercial(
            string Nom,
            string Matricule,
            string Categorie,
            string Service,
            int Salaire,
            int ChiffreAffaire,
            double CommissionPourcentage
        )
            : base(Nom, Matricule, Categorie, Service, Salaire)
        {
            this.ChiffreAffaire = ChiffreAffaire;
            this.CommissionPourcentage = CommissionPourcentage;
        }

        public double CalculerComission()
        {
            return ChiffreAffaire * (CommissionPourcentage / 100);
        }

        public override void AfficherSalaire()
        {
            double SalaireTotal = Salaire + CalculerComission();
            Console.WriteLine($"Le salaire avec commision de {Nom} est de {SalaireTotal} euros.");
        }
    }
}
