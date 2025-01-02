using System;
using System.Collections.Generic;

namespace Exo13Salaire.NET
{
    internal class IHM
    {
        public static void AfficherIHM()
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

        private static void AjouterEmploye()
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
                case 0:
                    Console.Clear();
                    break;
                default:
                    AfficherErreur("Erreur, vous n'êtes pas autorisé à effectuer cette saisie !");
                    break;
            }
        }

        private static void AjouterSalarie()
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
        }

        private static void AjouterCommercial()
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
        }

        private static void AfficherErreur(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
