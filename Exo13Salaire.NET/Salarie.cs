using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo11Salaire.NET
{
    internal class Salarie
    {
        private string _matricule;
        private string _categorie;
        private string _service;
        private string _nom;
        private int _salaire;

        public string Matricule
        {
            get => _matricule;
            set => _matricule = value;
        }
        public string Categorie
        {
            get => _categorie;
            set => _categorie = value;
        }
        public string Service
        {
            get => _service;
            set => _service = value;
        }
        public string Nom
        {
            get => _nom;
            set => _nom = value;
        }
        public int Salaire
        {
            get => _salaire;
            set
            {
                if (value < 0 || value > 1000000)
                {
                    throw new ArgumentOutOfRangeException("Veuillez entrer un salaire correct.");
                }
                _salaire = value;
            }
        }

        public Salarie(string Matricule, string Categorie, string Service, string Nom, int Salaire)
        {
            _matricule = Matricule;
            _categorie = Categorie;
            _service = Service;
            _nom = Nom;
            this.Salaire = Salaire; // J'utilise this pour indiquer que je veux l'instance "Salaire" a la place du paramétre du constructeur.
        }

        public virtual void AfficherSalaire()
        {
            Console.WriteLine(
                $"Le salaire avec commision de {Nom} est de Salaire} euros."
            );
        }
    }
}
