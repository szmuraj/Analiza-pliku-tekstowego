using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Prosze podaj mi ścieżkę do pliku:");
        string path = Console.ReadLine();
        if (!path.EndsWith(".txt")) { Console.WriteLine("Niestety obsługuję tylko pliki .txt"); }

        else if (File.Exists(path))
        {
            string text = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine($"""
                {text}

                Analiza:
                Ilość zdań: {text.Split(new string[] { ". ", "! ", "? " }, StringSplitOptions.RemoveEmptyEntries).Length}
                Ilość słów: {text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length}
                Ilość znaków: {text.Length}
                """);
        }
        else
        {
            Console.WriteLine("Plik nie istnieje");
        }


    }
}