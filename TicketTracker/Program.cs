
using System.IO.Enumeration;
using Ticket.Entities;
using TicketTracker.Entities;

public class Program
{
    // static void Main()
    // {
    //     // FileManager path = new FileManager(@"C:\DevProjects\TicketTracker\ticketTracker.txt");
    //     string pathTeste = @"C:\DevProjects\TicketTracker";
    //     FileManager path = new FileManager(pathTeste);
    //     path.PathValidation(pathTeste);


    //     List<JiraTicket> tickets = new List<JiraTicket>();

    //     Console.WriteLine($"Insira o número do chamado: ");
    //     int idTicket = int.Parse(Console.ReadLine());

    //     Console.WriteLine($"Iniciando programa! ");
    //     DateTime dataInicial = DateTime.Now;

    //     Cronometro cronometro = new Cronometro();
    //     cronometro.TicTac();



    //     DateTime dataFinal = DateTime.Now;
    //     tickets.Add(new JiraTicket(idTicket, dataFinal, dataInicial));


    //     foreach (JiraTicket ticket in tickets)
    //     {

    //         path.GetFile(pathTeste, ticket.GetTxt());
    //     }

    // }
    static void Main()
    {

        // FileManager path = new FileManager(@"C:\DevProjects\TicketTracker\ticketTracker.txt");
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
        tickets.Add(new JiraTicket(idTicket, dataFinal, dataInicial));
        Console.Clear();

        foreach (JiraTicket ticket in tickets)
        {

            // Console.WriteLine($"{ticket.GetTxt()}");
            file.Writer(ticket.GetTxt());

            // path.GetFile(pathTeste, ticket.GetTxt());
        }

    }
}
