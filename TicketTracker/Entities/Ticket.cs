using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using TicketTracker.Entities;

namespace TicketTracker.Entities
{
    public class JiraTicket
    {
        // Propriedades
        public int Id { get; set; }
        // public string Name { get; set; }
        public DateTime InitialHour { get; set; }
        public DateTime FinalHour { get; set; }
        public List<JiraTicket> Tickets { get; set; } = new List<JiraTicket>();
        public Cronometro TempoDecorrido { get; set; }
        public string Txt { get; set; }

        public JiraTicket()
        {

        }
        public JiraTicket(int id, DateTime initialHour, DateTime finalHour, string txt)
        {
            Id = id;
            InitialHour = initialHour;
            FinalHour = finalHour;
            Txt = txt;
        }
        public JiraTicket(int id, DateTime initialHour, DateTime finalHour)
        {
            Id = id;
            InitialHour = initialHour;
            FinalHour = finalHour;

        }
        public TimeSpan GetDateTime(DateTime initialHour, DateTime finalHour)
        {
            TimeSpan workedTime = finalHour - initialHour;
            return workedTime;
        }
        public string GetTxt()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Tickets: {Id}-1\n");
            sb.AppendLine($"Iniciado em:   {InitialHour}");
            sb.AppendLine($"Finalizado em: {FinalHour}");
            // sb.AppendLine($"Tempo total trabalhado: {TempoDecorrido:hh\\:mm\\:ss}");
            return sb.ToString();
        }
    }
}