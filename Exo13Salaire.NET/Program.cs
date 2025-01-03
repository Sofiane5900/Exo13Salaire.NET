using Exo11Salaire.NET;
using Exo13Salaire.NET;

List<Commercial> commerciaux = new List<Commercial>();
List<Salarie> salaries = new List<Salarie>();
IHM IHM = new IHM(commerciaux, salaries);
IHM.AfficherIHM();
