# Architekturentscheidungen
## Entscheidung: Console Application
Die Anwendung wurde bewusst als Console Application entwickelt.
Gründe:
- Fokus auf die Programmlogik
- einfache Entwicklung
- geeignet für ein Lernprojekt

## Entscheidung: Service Layer
Die Geschäftslogik wurde in die Klasse `TicketService` ausgelagert.
Vorteile:
- klare Trennung von UI und Logik
- bessere Wartbarkeit
- einfachere Erweiterbarkeit
Architektur:
Program ? TicketService ? Database

## Entscheidung: JSON Speicherung
Tickets werden in einer JSON-Datei gespeichert.
Vorteile:
- einfache Implementierung
- keine externe Datenbank erforderlich
- Daten bleiben beim Neustart erhalten

## Entscheidung: Rollenverwaltung
Das System verwendet zwei Rollen:
User  
Admin
Nur Administratoren dürfen Tickets löschen.