using System;


namespace Ticket.Entities
{
    public class FileManager
    {
        // Propriedades
        public string PathName { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }

        // Construtor padrão
        public FileManager()
        {


        }

        // Construtor com parâmetros
        public FileManager(string pathName)
        {
            PathName = pathName;
        }

        public void GetFile(string pathName, string text)
        {
            using (StreamWriter writer = new StreamWriter(pathName, true)) // "false" para sobrescrever o arquivo
            {
                writer.WriteLine(text);  // Escreve uma linha no arquivo
            }
        }
        //Valida se o diretório do TXT existe, se não ele cria
        public void PathValidation(string pathName)
        {
            if (Path.Exists(pathName) != true)
            {
                Console.WriteLine($"Arquivo de chamados está em: {pathName}");
                Directory.CreateDirectory(pathName);

            }
            if (File.Exists(pathName) != true)
            {
                Console.WriteLine($"Arquivo não existe, criando!!!!");
                File.Create(Path.Combine(pathName + @"\TicketTracker.txt"));
            }
            else
            {
                Console.WriteLine($"Diretório Já existe!");
                Console.WriteLine($"{pathName}");

            }
        }
        public string GetUserName()
        {
            return UserName = Environment.UserName;
        }
    }
}
