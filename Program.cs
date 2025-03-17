using System.Linq.Expressions;

public class main
{
    static void Main(string[] args)
    {
        string[] nomes = new string[5];
        
        Console.WriteLine("Introduza 5 nomes :");

        for (int i = 0; i < nomes.Length; i++)
        {
            nomes[i] = Console.ReadLine();
        }
         
        Array.Sort(nomes);
        
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Numeros por ordem: ");
    
        foreach (var nome in nomes)
        {
            
            Console.WriteLine(nome);
        }
        
    }
}