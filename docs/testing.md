# Testing

### Verbindungsuchen

Vorbedingung: Die Applikation wurde gestartet und der Computer verfügt über eine aktive Internetverbindung.

Anforderung: A001 & A002

| Schritt | Aktivität | Erwartetes Resultat |
| :--- | :--- | :--- |
| 1 | Ich gebe "Luzern, Bahnhof" in die "From TextBox" ein. | Die Combobox zeigt mir die Station "Luzern, Bahnhof an" |
| 2 | Ich gebe "Stans, Bahnhof" in die "To Textbox" ein | Die Combobox zeigt mir die Station "Stans, Bahnhof an" |
| 3 | Ich klicke auf den Button "Search Connecton" | Ich erhalte eine Liste mit den vier nächsten Verbindungen von Luzern nach Stans |

### Stationsvorschläge

Vorbedingung: Die Applikation wurde gestartet und der Computer verfügt über eine aktive Internetverbindung.

Anforderung: A003

| Schritt | Aktivität | Erwartetes Resultat |
| :--- | :--- | :--- |
| 1 | Ich gebe "Lu" in die "From TextBox" ein. | Das Dropdown menü Zeigt mir alle Stationen welche mit "Lu" beginnen an. |
| 2 | Ich gebe "Lu" in die "To TextBox" ein. | Das Dropdown menü Zeigt mir alle Stationen welche mit "Lu" beginnen an. |
| 3 | Ich gebe "Lu" in die "Station TextBox" ein. | Das Dropdown menü Zeigt mir alle Stationen welche mit "Lu" beginnen an. |

### Stationabfahrtstafel

Vorbedingung: Die Applikation wurde gestartet und der Computer verfügt über eine aktive Internetverbindung.

Anforderung: A004

| Schritt | Aktivität | Erwartetes Resultat |
| :--- | :--- | :--- |
| 1 | Ich gebe "Luzern, Bahnhof" in die "Station TextBox" ein. | Das Dropdown menü Zeigt mir alle Stationen welche mit "Lu" beginnen an. |
| 2 | Ich bestätige den "Open Stationboard" button | Ich erhalte eine List mit allen ausgehenden Verbindungen von Luzern, Bahnhof |

### Verbindungssuche nach Zeit und Datum

Vorbedingung: Die Applikation wurde gestartet und der Computer verfügt über eine aktive Internetverbindung.

Anforderung: A005

| Schritt | Aktivität | Erwartetes Resultat |
| :--- | :--- | :--- |
| 1 | Ich gebe "Luzern, Bahnhof" in die "From TextBox" ein. | Die Combobox Zeigt mir die Station "Luzern, Bahnhof" an. |
| 2 | Ich gebe "Stans, Bahnhof" in die "To Textbox" ein | Die Combobox zeigt mir die Station "Stans, Bahnhof" an. |
| 3 | Ich wähle das Datum "01/04/2021" in der "Datums eingabebox" aus | Die "Datums eingabebox" zeigt mir das Datum "01/04/2021" an. |
| 4 | Ich gebe die Uhrzeit "13:30" in die "Zeit eingabebox" ein. | Die "Zeit eingabebox" zeigt mir die Zeit "13:30" an. |
| 5 | Ich betätige den Button "Search Connection" | Ich erhalte eine Liste mit den vier nächsten Verbindungen von Luzern, Bahnhof nach Stans, Bahnhof |

### Stationsstandort anzeige

Vorbedingung: Die Applikation wurde gestartet und der Computer verfügt über eine aktive Internetverbindung.

Anforderung: A006

| Schritt | Aktivität | Erwartetes Resultat |
| :--- | :--- | :--- |
| 1 | Ich gebe "Luzern, Bahnhof" in die "From TextBox" ein. | Die Combobox Zeigt mir die Station "Luzern, Bahnhof" an. |
| 2 | Ich betätige den kleinen Knopf mit dem Location Icon rechts der Textbox | Es öffnet sich ein Browser fenster in welchem ich die Position der Station sehe. |

### Verbindung E-Mail weiterleitung

Vorbedingung: Die Applikation wurde gestartet und der Computer verfügt über eine aktive Internetverbindung.

Anforderung: A008

| Schritt | Aktivität | Erwartetes Resultat |
| :--- | :--- | :--- |
| 1 | Ich gebe "Luzern, Bahnhof" in die "From TextBox" ein. | Die Combobox Zeigt mir die Station "Luzern, Bahnhof" an. |
| 2 | Ich gebe "Stans, Bahnhof" in die "To Textbox" ein | Die Combobox zeigt mir die Station "Stans, Bahnhof" an. |
| 3 | Ich wähle das Datum "01/04/2021" in der "Datums eingabebox" aus | Die "Datums eingabebox" zeigt mir das Datum "01/04/2021" an. |
| 4 | Ich gebe die Uhrzeit "13:30" in die "Zeit eingabebox" ein. | Die "Zeit eingabebox" zeigt mir die Zeit "13:30" an. |
| 5 | Ich betätige den Button "Search Connection" | Ich erhalte eine Liste mit den vier nächsten Verbindungen von Luzern, Bahnhof nach Stans, Bahnhof. |
| 6 | Ich betätige den Button mit dem Share icon auf der ersten Verbindung | Es öffnet sich ein weiteres Fenster. |
| 7 | Ich gebe meine Emai Addresse in die "Email Textbox" ein. | Die Textbox zeigt meine Email adresse an. |
| 8 | Ich betätige den "Add button" | Ich sehe meine Email adresse in der Liste mit dem grauen Hintergrund. |
| 9 | Ich betätige den Button "Send" | Das Fenster schliesst sich und ich erhalte eine Email mit meiner verbindung. |

### Verbindung Ausdrucken

Vorbedingung: Die Applikation wurde gestartet und der Computer verfügt über eine aktive Internetverbindung.

Anforderung: A009

| Schritt | Aktivität | Erwartetes Resultat |
| :--- | :--- | :--- |
| 1 | Ich gebe "Luzern, Bahnhof" in die "From TextBox" ein. | Die Combobox Zeigt mir die Station "Luzern, Bahnhof" an. |
| 2 | Ich gebe "Stans, Bahnhof" in die "To Textbox" ein | Die Combobox zeigt mir die Station "Stans, Bahnhof" an. |
| 3 | Ich wähle das Datum "01/04/2021" in der "Datums eingabebox" aus | Die "Datums eingabebox" zeigt mir das Datum "01/04/2021" an. |
| 4 | Ich gebe die Uhrzeit "13:30" in die "Zeit eingabebox" ein. | Die "Zeit eingabebox" zeigt mir die Zeit "13:30" an. |
| 5 | Ich betätige den Button "Search Connection" | Ich erhalte eine Liste mit den vier nächsten Verbindungen von Luzern, Bahnhof nach Stans, Bahnhof. |
| 6 | Ich betätige den Button mit dem Drucker icon auf der ersten Verbindung | Es öffnet sich ein Druck vorschau Fenster. |
| 7 | Ich wähle meinen bevorzugten Drucker aus und Drucke das Dokument | Das Dokument wird an meinem Drucker ausgedruckt. |

