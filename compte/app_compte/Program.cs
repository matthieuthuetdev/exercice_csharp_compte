using compte_library;

namespace app_compte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compte premierCompte = new Compte(1, "Matthieu THUET", 1000, -500);
            Console.WriteLine( premierCompte.ToString());
            Compte deuxiemeCompte = new Compte(2, "Quentin THUET", 1000, -500);
            Console.WriteLine( deuxiemeCompte.ToString());
            Compte troisiemeCompte = new Compte(3, "Emmanuel THUET", 1000, -500);
            Console.WriteLine( troisiemeCompte.ToString());
            if(premierCompte.Transferer(deuxiemeCompte, 900))
            {
                Console.WriteLine("virement réussi.");
            }
            else {
                Console.WriteLine("échèque du virment, le solde est insufisant sur le compte débiteur.");
                }
            Console.WriteLine( premierCompte.ToString());
            Console.WriteLine( deuxiemeCompte.ToString());


        }
    }
}