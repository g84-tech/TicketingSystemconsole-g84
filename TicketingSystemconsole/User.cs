namespace TicketingSystemConsole
{
    // Diese Klasse repräsentiert einen Benutzer im Ticket-System
    // Ein Benutzer wird über seinen Benutzernamen identifiziert
    class User
    {
        // Benutzername des aktuellen Users
        public string Username { get; set; }

        // Konstruktor der Klasse
        // Beim Erstellen eines neuen Users wird der Benutzername übergeben
        public User(string username)
        {
            Username = username;
        }

        // Diese Methode prüft, ob der Benutzer Administrator ist
        // Ein Administrator erkennt man am Präfix "adm." im Benutzernamen
        // Beispiel:
        // adm.john  -> Admin
        // mike      -> normaler User
        public bool IsAdmin()
        {
            return Username.StartsWith("adm.", System.StringComparison.OrdinalIgnoreCase);
        }
    }
}


