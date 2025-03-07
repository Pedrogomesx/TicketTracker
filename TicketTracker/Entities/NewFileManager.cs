using static System.Console;


namespace Ticket.Entities
{
    public class NewFileManager
    {
        public string PathName;
        public string? Text { get; set; }

        // Construtor padrão
        public NewFileManager()
        {
            PathName = @$"C:\Users\{Environment.UserName}\Documents\TicketTracker2";
        }



        public void Writer(string content)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TicketTracker2", "tickets.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            using StreamWriter writer = new(filePath, true);
            writer.WriteLine(content);
        }

        // Valida se o diretório do TXT existe, se não ele cria
        public void PathValidation()
        {
            if (!Path.Exists(PathName))
            {
                WriteLine($"Arquivo de chamados está em: {PathName}");
                Directory.CreateDirectory(PathName);
            }
            else
            {
                WriteLine($"Diretório Já existe!");
                WriteLine($"{PathName}");
            }
        }
    }
}
