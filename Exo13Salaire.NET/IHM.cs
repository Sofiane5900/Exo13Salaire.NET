using System;
using System.Collections.Generic;
using Exo11Salaire.NET;

namespace Exo13Salaire.NET
{
    internal class IHM
    {
        private List<Commercial> _commercials;
        private List<Salarie> _salaries;

        public IHM(List<Commercial> Commercials, List<Salarie> Salaries)
        {
            this.Commercials = Commercials;
            this.Salaries = Salaries;
        }

        public List<Commercial> Commercials
        {
            get => _commercials;
            set => _commercials = value;
        }
        public List<Salarie> Salaries
        {
            get => _salaries;
            set => _salaries = value;
        }

        public void AfficherIHM()
        {
            while (true)
            {
                Console.WriteLine("=== Gestion des employées ===\n");
                Console.WriteLine("1-- Ajouter un employé");
                Console.WriteLine("2-- Afficher le salaire des employés");
                Console.WriteLine("3-- Rechercher un employé");
                Console.WriteLine("4-- Quitter");
                Console.Write("Faites votre choix : ");
                if (!int.TryParse(Console.ReadLine(), out int choixMenu))
                {
                    AfficherErreur("Erreur, vous n'êtes pas autorisé à effectuer cette saisie !");
                    continue;
                }

                switch (choixMenu)
                {
                    case 1:
                        AjouterEmploye();
                        break;
                    case 2:
                        AfficherSalaire();
                        break;
                    case 3:
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        AfficherErreur(
                            "Erreur, vous n'êtes pas autorisé à effectuer cette saisie !"
                        );
                        break;
                }
            }
        }

        private void AjouterEmploye()
        {
            Console.Clear();
            Console.WriteLine("=== Ajouter un employé ===\n");
            Console.WriteLine("1-- Salarié");
            Console.WriteLine("2-- Commerciale");
            Console.WriteLine("0-- Retour");
            if (!int.TryParse(Console.ReadLine(), out int choixAjout))
            {
                AfficherErreur("Erreur, vous n'êtes pas autorisé à effectuer cette saisie !");
                return;
            }

            switch (choixAjout)
            {
                case 1:
                    AjouterSalarie();
                    break;
                case 2:
                    AjouterCommercial();
                    break;
                case 3:
                    RechercherEmploye();
                    break;
                case 0:
                    Console.Clear();
                    break;
                default:
                    AfficherErreur("Erreur, vous n'êtes pas autorisé à effectuer cette saisie !");
                    break;
            }
        }

        private void AjouterSalarie()
        {
            Console.Write("Merci de saisir le nom: ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le matricule: ");
            string matricule = Console.ReadLine();
            Console.Write("Merci de saisir le service: ");
            string service = Console.ReadLine();
            Console.Write("Merci de saisir la catégorie: ");
            string categorie = Console.ReadLine();
            Console.Write("Merci de saisir le salaire: ");
            if (!int.TryParse(Console.ReadLine(), out int salaire))
            {
                AfficherErreur("Erreur, veuillez entrer un salaire valide!");
                return;
            }
            Salarie ajoutSalarie = new Salarie(nom, matricule, service, categorie, salaire);
            Salaries.Add(ajoutSalarie);
        }

        private void AjouterCommercial()
        {
            Console.Write("Merci de saisir le nom: ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le matricule: ");
            string matricule = Console.ReadLine();
            Console.Write("Merci de saisir le service: ");
            string service = Console.ReadLine();
            Console.Write("Merci de saisir la catégorie: ");
            string categorie = Console.ReadLine();
            Console.Write("Merci de saisir le salaire: ");
            if (!int.TryParse(Console.ReadLine(), out int salaire))
            {
                AfficherErreur("Erreur, veuillez entrer un salaire valide!");
                return;
            }
            Console.Write("Merci de saisir le chiffre d'affaire: ");
            if (!int.TryParse(Console.ReadLine(), out int chiffreAffaire))
            {
                AfficherErreur("Erreur, veuillez entrer un chiffre d'affaire valide!");
                return;
            }
            Console.Write("Merci de saisir la commission: ");
            if (!int.TryParse(Console.ReadLine(), out int commission))
            {
                AfficherErreur("Erreur, veuillez entrer une commission valide!");
                return;
            }
            Commercial ajoutCommercial = new Commercial(
                nom,
                matricule,
                service,
                categorie,
                salaire,
                chiffreAffaire,
                commission
            );
            Commercials.Add(ajoutCommercial);
        }

        private void AfficherErreur(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private void AfficherSalaire()
        {
            Console.Clear();
            Console.WriteLine("=== Afficher le salaire des employés ===\n");
            foreach (Salarie salarie in Salaries)
            {
                salarie.AfficherSalaire();
            }
            foreach (Commercial commercial in Commercials)
            {
                commercial.AfficherSalaire();
            }
        }

        private void RechercherEmploye()
        {
            Console.Clear();
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();

            bool employeTrouver = false;

            foreach (Salarie salarie in Salaries)
            {
                if (salarie.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase))
                {
                    employeTrouver = true;
                    AfficherSalaire();
                }
            }

            foreach (Commercial commercial in Commercials)
            {
                if (commercial.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase))
                {
                    employeTrouver = true;
                    AfficherSalaire();
                }
            }
        }
    }
}
