namespace TicketingSystemConsole
{
    // Klasse repräsentiert ein Support-Ticket
    class Ticket
    {
        // Automatische ID-Vergabe
        private static int _nextId = 1;

        // Ticket-ID (nur lesbar von außen)
        public int Id { get; private set; }

        // Titel des Tickets
        public string Title { get; set; } = "";

        // Beschreibung des Problems
        public string Description { get; set; } = "";

        // Status des Tickets
        public string Status { get; set; } = "Open";

        // Konstruktor erzeugt automatisch eine neue ID
        public Ticket()
        {
            Id = _nextId++;
        }
    }
}
