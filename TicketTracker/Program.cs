
using System.IO.Enumeration;
using Ticket.Entities;
using TicketTracker.Entities;

public class Program
{
    static void Main()
    {
        // FileManager path = new FileManager(@"C:\DevProjects\TicketTracker\ticketTracker.txt");
        string pathTeste = @"C:\DevProjects\TicketTracker\newFolder\ticketTracker.txt";
        FileManager path = new FileManager(pathTeste);
        // path.PathValidation(pathTeste);


        List<JiraTicket> tickets = new List<JiraTicket>();

        Console.WriteLine($"Insira o número do chamado: ");
        int idTicket = int.Parse(Console.ReadLine());

        Console.WriteLine($"Iniciando programa! ");
        DateTime dataInicial = DateTime.Now;

        Cronometro cronometro = new Cronometro();
        cronometro.TicTac();



        DateTime dataFinal = DateTime.Now;
        tickets.Add(new JiraTicket(idTicket, dataFinal, dataInicial));


        foreach (JiraTicket ticket in tickets)
        {

            path.GetFile(pathTeste, ticket.GetTxt());
        }

    }
}
