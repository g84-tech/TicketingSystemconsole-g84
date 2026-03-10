# Product Backlog – Ticketing System
## User Stories
### US1 – Ticket erstellen
**Beschreibung:**  
Als Benutzer möchte ich ein Ticket erstellen, um ein Problem zu erfassen.
**Priorität:** Hoch
**Akzeptanzkriterien:**
- Benutzer kann Titel eingeben
- Benutzer kann Beschreibung eingeben
- Ticket wird gespeichert
- Ticket erhält automatisch eine ID
---
### US2 – Tickets anzeigen
**Beschreibung:**  
Als Benutzer möchte ich meine Tickets anzeigen können, um den Überblick über offene Probleme zu behalten.
**Priorität:** Hoch
**Akzeptanzkriterien:**
- Alle Tickets werden in der Konsole angezeigt
- ID, Titel, Beschreibung und Status werden dargestellt
---
### US3 – Ticket bearbeiten
**Beschreibung:**  
Als Benutzer möchte ich ein Ticket bearbeiten können, um Informationen zu aktualisieren.
**Priorität:** Mittel
**Akzeptanzkriterien:**
- Ticket kann über ID ausgewählt werden
- Titel kann geändert werden
- Beschreibung kann geändert werden
- Status kann geändert werden
---
### US4 – Ticket löschen
**Beschreibung:**  
Als Administrator möchte ich Tickets löschen können, um abgeschlossene Tickets zu entfernen.
**Priorität:** Mittel
**Akzeptanzkriterien:**
- Nur Admin darf Tickets löschen
- Ticket wird aus der Liste entfernt
---
### US5 – Tickets speichern und laden
**Beschreibung:**  
Als Benutzer möchte ich, dass Tickets gespeichert werden, damit sie beim Neustart der Anwendung erhalten bleiben.
**Priorität:** Hoch
**Akzeptanzkriterien:**
- Tickets werden in einer JSON-Datei gespeichert
- Tickets werden beim Programmstart geladen
---
### US6 – Rollenverwaltung
**Beschreibung:**  
Als Systemadministrator möchte ich unterschiedliche Benutzerrollen verwenden, damit bestimmte Aktionen nur von Admins durchgeführt werden können.
**Priorität:** Niedrig
**Akzeptanzkriterien:**
- Benutzerrolle wird beim Start festgelegt
- Nur Admin darf Tickets löschen