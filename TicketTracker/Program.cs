using Ticket.Entities;
using TicketTracker.Entities;

public class Program
{
    static void Main()
    {

        Console.Clear();
        NewFileManager file = new NewFileManager();
        file.PathValidation();


        List<JiraTicket> tickets = new List<JiraTicket>();

        Console.WriteLine($"Insira o número do chamado: ");
        int idTicket = int.Parse(Console.ReadLine());

        Console.WriteLine($"Iniciando programa! ");
        DateTime dataInicial = DateTime.Now;

        Cronometro cronometro = new Cronometro();
        cronometro.TicTac();

        DateTime dataFinal = DateTime.Now;

        tickets.Add(new JiraTicket(idTicket, dataInicial, dataFinal));
        Console.Clear();


        foreach (JiraTicket ticket in tickets)
        {

            Console.WriteLine($"{ticket.GetTxt()}");
            file.Writer(ticket.GetTxt());

            // path.GetFile(pathTeste, ticket.GetTxt());
        }

    }
}
