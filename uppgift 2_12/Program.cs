using System;
namespace uppgift2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej du kan hyra ett bill för 300 kronor som start avgift och 1kr för varje km Den kör?." +
                " Den kostar 500 kr för extra dagar");
            Console.WriteLine("Vill du hyra billen?");
            Console.ReadLine();
            Console.WriteLine("För hur mycket kilometer kommer du och hyra den?");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket dager kommer du och hyra den?");
            int dag = int.Parse(Console.ReadLine());
            int resultat = 500(dag-1)+km+300;
            Console.WriteLine("Kostnaden är " + resultat + ".");
        }
    }
}
