using System.Runtime.CompilerServices;

namespace compte_library
{
    public class Compte
    {
        public int NumeroDeCompte;
        private string NomDuProprietaireDuCompte;
        private double SoldeDuCompte;
        private double DecouvertAutorise;

        public Compte(int numeroDeCompte, string nomDuProprietaireDuCompte, double soldeDuCompte, double decouvertAutorise)
        {
            NumeroDeCompte = numeroDeCompte;
            NomDuProprietaireDuCompte = nomDuProprietaireDuCompte;
            SoldeDuCompte = soldeDuCompte;
            DecouvertAutorise = decouvertAutorise;
        }

        public bool Crediter(double montant)
        {
            SoldeDuCompte += montant;
            return true;
        }

        public bool Debiter(double montant)
        {
            if (SoldeDuCompte-montant>=this.DecouvertAutorise && montant>=0)
            {
                SoldeDuCompte -= montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferer(Compte compteACrediter, double montant)
        {
            if (Debiter(montant))
            {
                compteACrediter.Crediter(montant);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "ce compte a pour numero " + this.NumeroDeCompte + " il appartien à " + this.NomDuProprietaireDuCompte + " sont solde est de " + this.SoldeDuCompte + " et sont découvert autoriser est de " + this.DecouvertAutorise;
        }
    }
}