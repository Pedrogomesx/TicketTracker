using System.Diagnostics;
using TicketTracker.Entities;

public class Cronometro
{
    public JiraTicket Id { get; set; }
    public TimeSpan TempoDecorrido { get; set; }

    public Cronometro()
    {

    }
    public TimeSpan TicTac()
    {
        Stopwatch Cronometro = new Stopwatch();
        Cronometro.Start();

        while (true)
        {
            Console.WriteLine($"{Cronometro.Elapsed:hh\\:mm\\:ss}");
            Thread.Sleep(1000);
            Console.Clear();
            if (Console.KeyAvailable)
            {
                Console.ReadKey(true);
                break;
            }
            Console.Clear();
        }

        // TempoDecorrido = Cronometro.Elapsed;
        // Console.WriteLine($"{TempoDecorrido:hh\\:mm\\:ss}");
        return TempoDecorrido;

    }
}