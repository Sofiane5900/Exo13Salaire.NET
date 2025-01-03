using Exo11Salaire.NET;

namespace Exo13Salaire.NET
{
    // Je déclare que Commercial hérite de la classe Salarie
    internal class Commercial : Salarie
    {
        private int _chiffreAffaire;
        private double _commission;
        private double _comissionPourcentage;
        private static List<Commercial> _commercials;
        private List<Salarie> _salaries;

        public int ChiffreAffaire
        {
            get => _chiffreAffaire;
            set => _chiffreAffaire = value;
        }
        public double Commission
        {
            get => _commission;
            set => _commission = value;
        }
        public double ComissionPourcentage
        {
            get => _comissionPourcentage;
            set => _comissionPourcentage = value;
        }
        public static List<Commercial> Commercials
        {
            get => _commercials;
            set => _commercials = value;
        }
        public List<Salarie> Salaries
        {
            get => _salaries;
            set => _salaries = value;
        }

        // Je déclare un constructeur, "base" appelle tout les attributs de la classe mere Salarie
        public Commercial(
            string Matricule,
            string Categorie,
            string Service,
            string Nom,
            int Salaire,
            int ChiffreAffaire
        )
            : base(Matricule, Categorie, Service, Nom, Salaire)
        {
            _chiffreAffaire = ChiffreAffaire;
            Commercials = new List<Commercial>();
        }

        public override void AfficherSalaire()
        {
            Console.WriteLine(
                $"Le salaire avec commision de {Nom} est de {Salaire + Commission} euros."
            );
        }
    }
}
