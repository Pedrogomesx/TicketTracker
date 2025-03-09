using System.Diagnostics;
using Ticket.Entities;
using TicketTracker.Entities;

public class Program
{
    static void Main()
    {
        ExecuteMenu();
    }

    public static void ExecuteMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Ticket Tracker System ===");
        Console.WriteLine("1. Create New Ticket");
        Console.WriteLine("2. View All Tickets");
        Console.WriteLine("3. Search Tickets By Id");
        Console.WriteLine("4. Delete Ticket");
        Console.WriteLine("5. Abrir Arquivo");
        Console.WriteLine("6. Fechar Arquivo");
        Console.WriteLine("7. Exit");
        Console.Write("\nSelect an option: ");
        NewFileManager file = new();
        file.PathValidation();

        bool continueRunning = true;
        while (continueRunning)
        {

            switch (Console.ReadLine())
            {
                case "1":
                    List<JiraTicket> tickets = new();
                    Console.WriteLine("Creating new ticket...");
                    Console.WriteLine($"Insira o número do chamado: ");
                    int idTicket = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Iniciando programa! ");
                    DateTime dataInicial = DateTime.Now;

                    Cronometro cronometro = new();
                    cronometro.TicTac();

                    DateTime dataFinal = DateTime.Now;

                    tickets.Add(new JiraTicket(idTicket, dataInicial, dataFinal));

                    foreach (JiraTicket ticket in tickets)
                    {
                        Console.WriteLine($"{ticket.GetTxt()}");
                        file.Writer(ticket.GetTxt());
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Displaying all tickets...");
                    file.ReadFile();
                    break;

                case "3":
                    Console.WriteLine("Enter ticket ID: ");
                    file.FindTicket();
                    break;

                case "4":
                    Console.WriteLine("Delete ticket");
                    file.DeleteTicket();
                    break;

                case "5":
                    Console.WriteLine("Abrindo Arquivo!");
                    Process.Start("Notepad.exe", file.filePath);
                    break;

                case "6":
                    Process[] processos = Process.GetProcessesByName("notepad");
                    foreach (var process in processos)
                    {
                        Process.GetProcessById(process.Id).Kill();
                    }
                    break;

                case "7":
                    continueRunning = false;
                    Console.WriteLine("Exiting system...");
                    break;
            }

            if (continueRunning)
            {
                Console.WriteLine("=== Ticket Tracker System ===");
                Console.WriteLine("1. Create New Ticket");
                Console.WriteLine("2. View All Tickets");
                Console.WriteLine("3. Search Tickets By Id");
                Console.WriteLine("4. Delete Ticket");
                Console.WriteLine("5. Abrir Arquivo");
                Console.WriteLine("6. Fechar Arquivo");
                Console.WriteLine("7. Exit");
                Console.Write("\nSelect an option: ");

            }
        }
    }
}
