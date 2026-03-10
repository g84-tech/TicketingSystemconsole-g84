# TicketingSystemconsole-g84

## Ticketing System – C# Konsolenanwendung



# Inhaltsverzeichnis

1. Projektbeschreibung  

2. Ziel des Projekts  

3. Projektplanung  

4. Zeitplanung  

5. Projektstruktur  

6. Implementierung  

7. Flowchart  

8. Probleme und Lösungen  

9. Architekturentscheidungen  

10. Screenshots  

11. Quellen  



# 1. Projektbeschreibung

Im Rahmen des AE-Grundlagen-Abschlussprojekts wurde ein Ticketing-System als Konsolenanwendung mit der Programmiersprache C# entwickelt.

Das System ermöglicht es Benutzern, Tickets zu erstellen, anzuzeigen und zu verwalten.  

Die Anwendung wurde objektorientiert umgesetzt und verwendet eine einfache Datenpersistenz über JSON-Dateien.

Das Projekt umfasst folgende Bestandteile:

- Planung des Projekts

- Entwicklung der Software

- Versionierung über GitHub

- Dokumentation der einzelnen Arbeitsschritte

- Vorbereitung einer Präsentation

Die Anwendung wurde bewusst als **Console Application** umgesetzt, um den Fokus auf die Programmlogik und die objektorientierte Struktur zu legen.



# 2. Ziel des Projekts

Ziel des Projekts war es, grundlegende Konzepte der Softwareentwicklung praktisch anzuwenden.

Dabei standen folgende Aspekte im Vordergrund:

- Objektorientierte Programmierung (Klassen, Methoden, Konstruktoren)

- Strukturierte Projektentwicklung

- Versionskontrolle mit Git und GitHub

- Einfache Datenpersistenz über JSON

- Dokumentation des Entwicklungsprozesses

- Planung und Umsetzung innerhalb eines festen Zeitrahmens

Zusätzlich sollte das Projekt zeigen, wie eine einfache Verwaltungssoftware strukturiert aufgebaut werden kann.



# 3. Projektplanung

Das Projekt wurde zunächst geplant und strukturiert.

Folgende Hauptfunktionen wurden definiert:

- Erstellung von Tickets

- Anzeige aller Tickets

- Speicherung der Tickets in einer Datei

- Löschen von Tickets (nur Admin)

- einfache Rollenstruktur (Admin / User)

Die Planung wurde in Form eines Backlogs umgesetzt.  

Dieses Backlog enthält einzelne Aufgaben, die während der Entwicklung Schritt für Schritt umgesetzt wurden.



# 4. Zeitplanung

Die Entwicklung des Projekts erfolgte innerhalb von sieben Tagen.

| Tag | Tätigkeit |

|----|----|

| Tag 1 | Projektplanung und Projektantrag |

| Tag 2 | Grundstruktur des Projekts erstellt |

| Tag 3 | Implementierung der Klassenstruktur |

| Tag 4 | JSON-Persistenz implementiert |

| Tag 5 | Dokumentation erweitert |

| Tag 6 | Tests und Bugfixing |

| Tag 7 | Präsentation des Projekts |



# 5. Projektstruktur

Das Projekt wurde in mehrere Ordner aufgeteilt, um eine übersichtliche Struktur zu schaffen.
 
docs/ → Tagesberichte, Projektplanung, Backlog, Entscheidungen

/screenshots/ → Screenshots der Anwendung

/src/ → Quellcode

README.md → Projektdokumentation
 
Diese Struktur erleichtert die Wartung und Erweiterung des Projekts.



# 6. Implementierung

Die Anwendung basiert auf mehreren Klassen.

Wichtige Komponenten:

**Program.cs**

Diese Datei enthält das Hauptmenü der Anwendung und steuert den Programmablauf.

**Ticket.cs**

Diese Klasse repräsentiert ein einzelnes Ticket.  

Ein Ticket enthält beispielsweise:

- ID

- Titel

- Beschreibung

- Status

**TicketService.cs**

Diese Klasse enthält die Geschäftslogik zur Verwaltung der Tickets.

Dazu gehören:

- Ticket erstellen

- Ticket anzeigen

- Ticket löschen

**Database.cs**

Diese Klasse übernimmt das Speichern und Laden der Tickets aus einer JSON-Datei.



# 7. Flowchart

Der grundlegende Ablauf der Anwendung kann wie folgt dargestellt werden:
 
Programmstart

↓

Menü anzeigen

↓

Benutzer wählt Option

1 → Ticket erstellen

2 → Tickets anzeigen

3 → Ticket löschen

0 → Programm beenden

↓

Aktion wird ausgeführt

↓

Rückkehr zum Menü
 
Dieser Ablauf wiederholt sich, bis der Benutzer das Programm beendet.



# 8. Probleme und Lösungen

Während der Entwicklung traten mehrere kleinere Probleme auf.

### Problem 1 – JSON Datei existiert nicht

Beim ersten Start der Anwendung konnte die Datei mit den Tickets nicht geladen werden.

**Lösung**

Es wurde eine Prüfung implementiert, die überprüft, ob die Datei existiert.  

Falls nicht, wird automatisch eine neue Datei erstellt.



### Problem 2 – Menüstruktur

Zu Beginn war die Menülogik schwer zu erweitern.

**Lösung**

Die Menüstruktur wurde überarbeitet und in separate Methoden ausgelagert, um den Code übersichtlicher zu gestalten.



### Problem 3 – Objektstruktur

Die erste Version des Codes enthielt zu viel Logik in der `Program.cs`.

**Lösung**

Die Geschäftslogik wurde in die Klasse `TicketService` ausgelagert.



# 9. Architekturentscheidungen

Während der Entwicklung wurden mehrere technische Entscheidungen getroffen.

### Console Application

Die Anwendung wurde bewusst als Konsolenprogramm umgesetzt.

Gründe:

- Fokus auf die Logik der Anwendung

- geringere Komplexität

- gute Eignung für ein Lernprojekt



### Trennung von Logik und Daten

Die Geschäftslogik wurde in eine eigene Klasse (`TicketService`) ausgelagert.

Vorteile:

- bessere Wartbarkeit

- klarere Struktur

- einfachere Erweiterung



### JSON Speicherung

Tickets werden in einer JSON-Datei gespeichert.

Vorteile:

- einfache Implementierung

- keine externe Datenbank notwendig

- Daten bleiben nach Programmneustart erhalten



# 10. Screenshots

### Hauptmenü

![Menu](screenshots/menu.png)

### Ticket erstellen

![Create](screenshots/create.png)

### Ticketliste

![List](screenshots/list.png)



# 11. Quellen

Microsoft Learn – C# Dokumentation  
https://learn.microsoft.com

JSON Serialization in C#  
https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json

Git Dokumentation  
https://git-scm.com/docs

ChatGPT (OpenAI) – Unterstützung bei Debugging, Strukturierung und Dokumentation des Projekts
Microsoft Learn: Build skills that open doors in your career
Gain technical skills through documentation and training, earn certifications and connect with the community
 