using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TicketingSystemConsole
{
    // Diese Klasse simuliert eine Datenbank
    // Die Tickets werden in einer JSON-Datei gespeichert
    class Database
    {
        // Liste aller Tickets im System
        private List<Ticket> tickets = new List<Ticket>();

        // Dateiname für die Speicherung
        private string filePath = "tickets.json";

        // Konstruktor der Klasse
        // Beim Start des Programms werden vorhandene Tickets geladen
        public Database()
        {
            LoadTickets();
        }

        // Methode gibt alle Tickets zurück
        public List<Ticket> GetTickets()
        {
            return tickets;
        }

        // Neues Ticket hinzufügen
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);

            // Nach jeder Änderung speichern wir die Datei
            SaveTickets();
        }

        // Ticket aktualisieren
        // Da wir Referenzen verwenden, reicht ein Speichern
        public void UpdateTicket(Ticket ticket)
        {
            SaveTickets();
        }

        // Ticket löschen
        public void DeleteTicket(int id)
        {
            tickets.RemoveAll(t => t.Id == id);

            // Nach dem Löschen speichern
            SaveTickets();
        }

        // Diese Methode speichert alle Tickets in einer JSON-Datei
        private void SaveTickets()
        {
            try
            {
                // Tickets in JSON umwandeln
                string json = JsonSerializer.Serialize(tickets, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                // JSON in Datei schreiben
                File.WriteAllText(filePath, json);
            }
            catch
            {
                Console.WriteLine("Fehler beim Speichern der Tickets.");
            }
        }

        // Diese Methode lädt Tickets aus der JSON-Datei
        private void LoadTickets()
        {
            try
            {
                // Prüfen ob Datei existiert
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);

                    // JSON wieder in Ticket-Liste umwandeln
                    tickets = JsonSerializer.Deserialize<List<Ticket>>(json)
                              ?? new List<Ticket>();
                }
            }
            catch
            {
                Console.WriteLine("Fehler beim Laden der Tickets.");
            }
        }
    }
}

