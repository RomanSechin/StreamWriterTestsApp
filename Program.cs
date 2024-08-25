using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        StreamWriter sw = new StreamWriter("secret_plan.txt");
        sw.WriteLine("How do i defeat capitan amazing?");
        sw.WriteLine("Another genius secret plan by The Swindler");
        sw.WriteLine("I'll unleash my army of clones upon the citizens of Objectville.");
        string location = "the mall";

        for (int number = 1; number <= 5; number++)
        {
            sw.WriteLine("Clone #{0} attacks {1}", number, location);
            location = (location == "the mall") ? "downtown" : "the mall";
        }

        sw.Close();

        StreamReader sr = new StreamReader("secret_plan.txt");
        while (sr.EndOfStream == false) {            
            Console.WriteLine(sr.ReadLine());
        }
        
        sr.Close();
    }
}