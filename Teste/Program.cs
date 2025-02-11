class Program
{
    static void Main()
    {
        // Console.Clear();
        string usuario = Environment.UserName;
        Console.WriteLine($"Usuário logado: {usuario}");

        string newPath = Path.Combine(@$"C:\users\{usuario}\Documents\TicketTracker");
        Console.WriteLine($"{newPath}");
        Console.WriteLine($"{Path.Combine(newPath + @"\TicketTracker.txt")}");

        if (Path.Exists(newPath) != true)
        {
            Console.WriteLine($"Diretório Criado meu cria!");
            Directory.CreateDirectory(newPath);

        }
        if (File.Exists(Path.Combine(newPath + @"\TicketTracker.txt")) != true)
        {
            Console.WriteLine($"Arquivo não existe, criando!!!!");
            File.Create(Path.Combine(newPath + @"\TicketTracker.txt"));
        }
        else
        {
            Console.WriteLine($"Diretório Já existe!");
            Console.WriteLine($"{newPath}");
        }
    }
}