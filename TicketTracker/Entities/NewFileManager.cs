using System;


namespace Ticket.Entities
{
    public class NewFileManager
    {
        // Propriedades
        public string UserName = Environment.UserName;
        public string PathName;
        public string Text { get; set; }

        // Construtor padrão
        public NewFileManager()
        {
            PathName = @$"C:\Users\{Environment.UserName}\Documents\testepedro\TicketTracker";
            // PathName = @"C:\DevProjects\teste\TicketTracker";
        }

        // Construtor com parâmetros
        public NewFileManager(string text)
        {
            Text = text;
        }

        public void Writer(string pathName)
        {
            using (StreamWriter writer = new StreamWriter(pathName, true)) // "false" para sobrescrever o arquivo
            {
                writer.WriteLine(pathName);  // Escreve uma linha no arquivo
            }
        }
        //Valida se o diretório do TXT existe, se não ele cria
        public void PathValidation()
        {
            if (!Path.Exists(PathName))
            {
                Console.WriteLine($"Arquivo de chamados está em: {PathName}");
                Directory.CreateDirectory(PathName);

            }
            if (!File.Exists(PathName))
            {
                Console.WriteLine($"Arquivo não existe, criando!!!!");
                File.Create(Path.Combine(PathName + @"\TicketTracker.txt"));
            }
            else
            {
                Console.WriteLine($"Diretório Já existe!");
                Console.WriteLine($"{PathName}");

            }
        }
    }
}
