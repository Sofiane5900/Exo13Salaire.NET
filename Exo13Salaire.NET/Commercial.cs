
using Exo11Salaire.NET;

namespace Exo13Salaire.NET
{
    // Je déclare que Commercial hérite de la classe Salarie
    internal class Commercial : Salarie
    {
        private int _chiffreAffaire;
        private double _commission;
        private double _comissionPourcentage;
        private List<Commercial> _commercials;
        private List<Salarie> salaries;

        public int ChiffreAffaire { get => _chiffreAffaire; set => _chiffreAffaire = value; }
        public double Commission { get => _commission; set => _commission = value; }
        public double ComissionPourcentage { get => _comissionPourcentage; set => _comissionPourcentage = value; }
        public  List<Commercial> Commercials { get => _commercials; set => _commercials = value; }
        public List<Salarie> Salaries { get => _commercials; set => _commercials = value; }


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


        public void IHM()
        {
            while (true)
            {
                Console.WriteLine("=== Gestion des employées ===\n");
                Console.WriteLine("1-- Ajouter un employé");
                Console.WriteLine("2-- Afficher le salaire des employés");
                Console.WriteLine("3-- Rechercher un employé");
                Console.WriteLine("3-- Quitter");

                int choixMenu;
                bool successChoixMenu = int.TryParse(Console.ReadLine(), out choixMenu);
                if (!successChoixMenu)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erreur, vous n'étes pas autorisé a effectuer cette saisie !");
                    Console.ResetColor();
                }

                switch (choixMenu) {
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erreur, vous n'étes pas autorisé a effectuer cette saisie !");
                        Console.ResetColor();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:

                }
            }
        }
    }
}
