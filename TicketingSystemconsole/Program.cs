using System;
using System.Collections.Generic;
namespace TicketingSystemConsole
{
    // Hauptklasse Program mit Main() Methode
    class Program
    {
        static void Main(string[] args)
        {
            // Datenbank initialisieren
            Database db = new Database();
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Ticketing System ===");
                Console.WriteLine("1. Tickets anzeigen");
                Console.WriteLine("2. Ticket hinzufügen");
                Console.WriteLine("3. Ticket bearbeiten");
                Console.WriteLine("4. Ticket löschen");
                Console.WriteLine("0. Beenden");
                Console.Write("Option wählen: ");
                string choice = Console.ReadLine() ?? "";
                switch (choice)
                {
                    case "1":
                        ListTickets(db);
                        break;
                    case "2":
                        AddTicket(db);
                        break;
                    case "3":
                        UpdateTicket(db);
                        break;
                    case "4":
                        DeleteTicket(db);
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Enter drücken...");
                        Console.ReadLine();
                        break;
                }
            }
        }
        // Methode: Alle Tickets anzeigen
        static void ListTickets(Database db)
        {
            var tickets = db.GetTickets();
            Console.WriteLine("--- Tickets ---");
            foreach (var t in tickets)
                Console.WriteLine($"{t.Id}: {t.Title} [{t.Status}] - {t.Description}");
            Console.WriteLine("Enter drücken...");
            Console.ReadLine();
        }
        // Methode: Neues Ticket hinzufügen
        static void AddTicket(Database db)
        {
            Console.Write("Titel: ");
            string title = Console.ReadLine() ?? "";
            Console.Write("Beschreibung: ");
            string desc = Console.ReadLine() ?? "";
            db.AddTicket(new Ticket { Title = title, Description = desc });
            Console.WriteLine("Ticket hinzugefügt. Enter drücken...");
            Console.ReadLine();
        }
        // Methode: Ticket bearbeiten
        static void UpdateTicket(Database db)
        {
            Console.Write("Ticket-ID zum Bearbeiten: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var ticket = db.GetTickets().Find(t => t.Id == id);
                if (ticket != null)
                {
                    Console.Write("Neuer Titel: ");
                    string newTitle = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newTitle)) ticket.Title = newTitle;
                    Console.Write("Neue Beschreibung: ");
                    string newDesc = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newDesc)) ticket.Description = newDesc;
                    Console.Write("Neuer Status (Open/InProgress/Closed): ");
                    string newStatus = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newStatus)) ticket.Status = newStatus;
                    db.UpdateTicket(ticket);
                    Console.WriteLine("Ticket aktualisiert. Enter drücken...");
                }
                else
                {
                    Console.WriteLine("Ticket nicht gefunden. Enter drücken...");
                }
            }
            else
            {
                Console.WriteLine("Ungültige ID. Enter drücken...");
            }
            Console.ReadLine();
        }
        // Methode: Ticket löschen
        static void DeleteTicket(Database db)
        {
            Console.Write("Ticket-ID zum Löschen: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                db.DeleteTicket(id);
                Console.WriteLine("Ticket gelöscht (falls vorhanden). Enter drücken...");
            }
            else
            {
                Console.WriteLine("Ungültige ID. Enter drücken...");
            }
            Console.ReadLine();
        }
    }
    // Klasse Ticket
    class Ticket
    {
        private static int _nextId = 1; // Automatische ID-Vergabe
        public int Id { get; private set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Status { get; set; } = "Open";
        public Ticket()
        {
            Id = _nextId++;
        }
    }
    // "Datenbank" - speichert Tickets in einer Liste
    class Database
    {
        private List<Ticket> tickets = new List<Ticket>();
        public List<Ticket> GetTickets()
        {
            return tickets;
        }
        public void AddTicket(Ticket t)
        {
            tickets.Add(t);
        }
        public void UpdateTicket(Ticket t)
        {
            // Referenzobjekt wird aktualisiert, daher kein weiterer Code nötig
        }
        public void DeleteTicket(int id)
        {
            tickets.RemoveAll(t => t.Id == id);
        }
    }
}