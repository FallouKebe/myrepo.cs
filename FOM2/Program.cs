using System;

class Programme
{
    static void Main()
    {
        // Demande à l'utilisateur de saisir un nombre
        Console.Write("Entrez un nombre pour calculer sa factorielle: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Calcul de la factorielle
        long factorielle = 1;
        for (int i = 1; i <= n; i++)
        {
            factorielle *= i;
        }

        // Affichage du résultat
        Console.WriteLine("La factorielle de " + n + " est: " + factorielle);
    }
}
