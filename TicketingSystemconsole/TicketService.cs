using System.Collections.Generic;

namespace TicketingSystemConsole
{
    // Diese Klasse enthält die Geschäftslogik für Tickets
    // Sie verbindet Program.cs mit der Database-Klasse
    internal class TicketService
    {
        // Referenz auf die Database-Klasse
        // Über dieses Objekt greifen wir auf die gespeicherten Tickets zu
        private Database database;

        // Konstruktor der Klasse
        // Beim Erstellen von TicketService wird ein Database-Objekt übergeben
        public TicketService(Database db)
        {
            database = db;
        }

        // Diese Methode gibt alle vorhandenen Tickets zurück
        // Program.cs nutzt diese Methode, um die Tickets anzuzeigen
        public List<Ticket> GetTickets()
        {
            return database.GetTickets();
        }

        // Methode zum Erstellen eines neuen Tickets
        public void CreateTicket(string title, string description)
        {
            // Neues Ticket-Objekt erstellen
            Ticket ticket = new Ticket
            {
                Title = title,
                Description = description,
                Status = "Open"
            };

            // Ticket in der "Datenbank" speichern
            database.AddTicket(ticket);
        }

        // Methode zum Löschen eines Tickets anhand der ID
        public void DeleteTicket(int id)
        {
            database.DeleteTicket(id);
        }

        // Methode zum Aktualisieren eines bestehenden Tickets
        // Wird verwendet, wenn ein Admin ein Ticket bearbeitet
        public void UpdateTicket(Ticket ticket)
        {
            database.UpdateTicket(ticket);
        }
    }
}
