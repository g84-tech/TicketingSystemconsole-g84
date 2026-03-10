using System;
using System.Collections.Generic;

namespace TicketingSystemConsole
{
    // Hauptklasse Program mit Main() Methode
    // Diese Klasse startet das Programm und steuert das Menü
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            TicketService ticketService = new TicketService(database);

            Console.Write("Benutzername eingeben: ");
            string username = Console.ReadLine() ?? "";

            User currentUser = new User(username);

            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine("===== Ticket System =====");
                Console.WriteLine("1 - Ticket erstellen");
                Console.WriteLine("2 - Tickets anzeigen");

                if (currentUser.IsAdmin())
                {
                    Console.WriteLine("3 - Ticket löschen");
                }

                Console.WriteLine("0 - Beenden");

                Console.Write("Auswahl: ");
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        CreateTicket(ticketService);
                        break;

                    case "2":
                        ListTickets(ticketService);
                        break;

                    case "3":
                        if (currentUser.IsAdmin())
                        {
                            DeleteTicket(ticketService);
                        }
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ungültige Auswahl.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // Neues Ticket erstellen
        static void CreateTicket(TicketService ticketService)
        {
            Console.Clear();

            Console.Write("Titel des Tickets: ");
            string title = Console.ReadLine() ?? "";

            Console.Write("Beschreibung: ");
            string description = Console.ReadLine() ?? "";

            ticketService.CreateTicket(title, description);

            Console.WriteLine("Ticket erfolgreich erstellt.");
            Console.WriteLine("Enter drücken...");
            Console.ReadLine();
        }

        // Alle Tickets anzeigen
        static void ListTickets(TicketService ticketService)
        {
            Console.Clear();

            List<Ticket> tickets = ticketService.GetTickets();

            if (tickets.Count == 0)
            {
                Console.WriteLine("Keine Tickets vorhanden.");
            }
            else
            {
                foreach (Ticket t in tickets)
                {
                    Console.WriteLine($"ID: {t.Id}");
                    Console.WriteLine($"Titel: {t.Title}");
                    Console.WriteLine($"Status: {t.Status}");
                    Console.WriteLine($"Beschreibung: {t.Description}");
                    Console.WriteLine("-----------------------------");
                }
            }

            Console.WriteLine("Enter drücken...");
            Console.ReadLine();
        }

        // Ticket löschen mit Fehlerbehandlung
        static void DeleteTicket(TicketService ticketService)
        {
            Console.Clear();

            try
            {
                Console.Write("Ticket ID eingeben: ");

                int id = int.Parse(Console.ReadLine() ?? "0");

                ticketService.DeleteTicket(id);

                Console.WriteLine("Ticket wurde gelöscht.");
            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.");
            }

            Console.WriteLine("Enter drücken...");
            Console.ReadLine();
        }
    }
}





