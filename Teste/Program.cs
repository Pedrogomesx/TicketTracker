class Program
{
    static void Main()
    {
        Console.Clear();
        string usuario = Environment.UserName;
        Console.WriteLine($"Usuário logado: {usuario}");

        string newPath = Path.Combine(@$"C:\users\{usuario}\Documents\TicketTracker");
        Console.WriteLine($"{newPath}");


        if (Path.Exists(newPath) != true)
        {
            Console.WriteLine($"Diretório Criado meu cria!");

            Directory.CreateDirectory(newPath);
        }
        else
        {
            Console.WriteLine($"Diretório já existe, vamos seguir o baile!");

        }

    }
}