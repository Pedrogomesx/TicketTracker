using static System.Console;


namespace Ticket.Entities
{
    public class NewFileManager
    {
        public string PathName;
        public string filePath;
        public string? Text { get; set; }

        // Construtor padrão
        public NewFileManager()
        {
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TicketTracker", "tickets.txt");
        }

        public void Writer(string content)
        {
            using StreamWriter writer = new(filePath, true);
            writer.WriteLine(content);
        }
        public string ReadFile()
        {
            string[] ticket = File.ReadAllLines(filePath);
            foreach (string line in ticket)
            {
                WriteLine(line);
            }
            return string.Join(Environment.NewLine, ticket);
        }
        // Valida se o diretório do TXT existe, se não ele cria
        public void PathValidation()
        {
            if (!Path.Exists(filePath))
            {
                WriteLine($"Arquivo de chamados está em: {filePath}");
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }
            else
            {
                WriteLine($"Diretório Já existe!");
                WriteLine($"{filePath}");
            }
        }
        public void FindTicket()
        {
            Console.Clear();
            int ticketNumber = int.Parse(Console.ReadLine());
            string[] lines = File.ReadAllLines(filePath);
            int ln = 0;

            foreach (string line in lines)
            {
                ln++;
                if (line.Contains(ticketNumber.ToString()))
                {
                    WriteLine(lines[ln - 1]);
                    WriteLine(lines[ln]);
                    WriteLine(lines[ln + 1]);
                    WriteLine(lines[ln + 2]);
                }
            }

        }
        public void DeleteTicket()
        {
            Console.WriteLine("Insira o Numero do Ticket que deseja Excluir: ");
            int ticketNumber = int.Parse(Console.ReadLine());
            string[] lines = File.ReadAllLines(filePath);
            int ln = 0;
            using StreamWriter writer = new(filePath, true);
            foreach (string line in lines)
            {
                ln++;
                if (line.Contains(ticketNumber.ToString()))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine(line);
                        writer.WriteLine(' ');
                    }
                }
            }

        }
    }
}
