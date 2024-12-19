using System;
class Programme
{
    static void Main()
    {
        // Demande à l'utilisateur de saisir le montant des dommages
        Console.Write("Entrez le montant des dommages: ");
        double montantDommages = Convert.ToDouble(Console.ReadLine());

        // Calcul de la franchise (10% du montant des dommages, mais limitée à 4000 cfa)
        double franchise = montantDommages * 0.10;
        if (franchise > 4000)
        {
            franchise = 4000;
        }

        double montantRembourse = montantDommages - franchise;

        Console.WriteLine("Montant remboursé: " + montantRembourse + " cfa");
        Console.WriteLine("Franchise: " + franchise + " cfa");
    }
}
