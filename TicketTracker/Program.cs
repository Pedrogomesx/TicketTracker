using Ticket.Entities;
using TicketTracker.Entities;

public class Program
{
    static void Main()
    {

        Console.Clear();
        // FileManager path = new FileManager(@"C:\DevProjects\TicketTracker\ticketTracker.txt");
        NewFileManager file = new NewFileManager();
        file.PathValidation();


        List<JiraTicket> tickets = new List<JiraTicket>();

        Console.WriteLine($"Insira o número do chamado: ");
        // int idTicket = int.Parse(Console.ReadLine());

        Console.WriteLine($"Iniciando programa! ");
        DateTime dataInicial = DateTime.Now;
        Console.WriteLine(dataInicial);

        Cronometro cronometro = new Cronometro();
        cronometro.TicTac();

        DateTime dataFinal = DateTime.Now;
        Console.WriteLine(dataFinal);

        tickets.Add(new JiraTicket(1234, dataInicial, dataFinal));
        Console.Clear();


        foreach (JiraTicket ticket in tickets)
        {

            Console.WriteLine($"{ticket.GetTxt()}");
            file.Writer(ticket.GetTxt());

            // path.GetFile(pathTeste, ticket.GetTxt());
        }

    }
}
