using System.Diagnostics.Metrics;

Console.WriteLine("FINANZPLANER");
Console.WriteLine("------------------------------");
Console.WriteLine("Private Haushaltsplanung");
Console.WriteLine();

// Einnahmen
double gehaltBen = 0;
double gehaltJanett = 0;
double kindergeld = 0;
double wohngeld = 0;
double kinderzuschlag = 0;
double unterhalt = 0    ;
double sonstigeEinnahmen = 0;

gehaltBen = ZahlEinlesen("Bitte geben Sie das Gehalt von Ben ein: ");

gehaltJanett = ZahlEinlesen("Bitte geben Sie das Gehalt von Janett ein: ");

kindergeld = ZahlEinlesen("Bitte geben Sie das Kindergeld ein: ");

wohngeld = ZahlEinlesen("Bitte geben Sie das Wohngeld ein: ");

kinderzuschlag = ZahlEinlesen("Bitte geben Sie den Kinderzuschlag ein: ");

unterhalt = ZahlEinlesen("Bitte geben Sie den Unterhalt ein: ");

sonstigeEinnahmen = ZahlEinlesen("Bitte geben Sie die sonstigen Einnahmen ein: ");


// Berechnung der Gesamteinnahmen
 double geamteinnahmen = gehaltBen 
    + gehaltJanett 
    + kindergeld 
    + wohngeld 
    + kinderzuschlag 
    + unterhalt 
    + sonstigeEinnahmen;

// Ausgabe der Einnahmen
Console.WriteLine("MONATLICHE EINNAHMEN");
Console.WriteLine("------------------------------");
Console.WriteLine($"Gehalt Ben:        {gehaltBen,8:N2} Euro");
Console.WriteLine($"Gehalt Janett:     {gehaltJanett,8:N2} Euro");
Console.WriteLine($"Kindergeld:        {kindergeld,8:N2} Euro");
Console.WriteLine($"Unterhalt:         {unterhalt,8:N2} Euro");
Console.WriteLine($"Kindergzuschlag:   {kinderzuschlag,8:N2} Euro");
Console.WriteLine($"Wohngeld:          {wohngeld  ,8:N2} Euro");
Console.WriteLine($"sonstige Einnahmen:{sonstigeEinnahmen,8:N2} Euro");

Console.WriteLine("------------------------------");
Console.WriteLine($"Gesamteinnahmen:   {geamteinnahmen,8:N2} Euro");

//Ausgaben
double Miete = 1200;
double Strom = 0;
double Internet = 0;
double Handy = 0;
double Streaming = 0;
double Spotify = 0;
double Versicherungen = 0;
double Lebensmittel = 0 ;
double Drogerie = 0;
double Autoleasing = 0;
double Kindergarten = 0;
double sonstigeAusgaben = 0;

Miete = ZahlEinlesen("Bitte geben Sie die Miete ein: ");

Strom = ZahlEinlesen("Bitte geben Sie die Kosten für Strom ein: ");

Internet = ZahlEinlesen("Bitte geben Sie die Kosten für Internet ein: ");

Handy = ZahlEinlesen("Bitte geben Sie die Kosten für Handy ein: ");

Streaming = ZahlEinlesen("Bitte geben Sie die Kosten für Streaming ein: ");

Spotify = ZahlEinlesen("Bitte geben Sie die Kosten für Spotify ein: ");

Lebensmittel = ZahlEinlesen("Bitte geben Sie die Kosten für Lebensmittel ein: ");

Drogerie = ZahlEinlesen("Bitte geben Sie die Kosten für Drogerie ein: ");

Versicherungen = ZahlEinlesen("Bitte geben Sie die Kosten für Versicherungen ein: ");

Autoleasing = ZahlEinlesen("Bitte geben Sie die Kosten für Autoleasing ein: ");

Kindergarten = ZahlEinlesen("Bitte geben Sie die Kosten für den Kindegarten ein: ");

sonstigeAusgaben = ZahlEinlesen("Bitte geben Sie die Kosten für den sonstige Ausgaben ein: ");

// Berechnung der Gesamtausgaben

double gesamtAusgaben = Miete 
    + Strom 
    + Internet 
    + Handy 
    + Streaming 
    + Spotify 
    + Lebensmittel 
    + Drogerie
    + Autoleasing
    + Versicherungen
    + Kindergarten
    + sonstigeAusgaben;

// Ausgabe
Console.WriteLine("MONATLICHE Ausgaben");
Console.WriteLine("------------------------------");
Console.WriteLine($"Miete:             {Miete,8:N2} Euro");
Console.WriteLine($"Strom:             {Strom,8:N2} Euro");
Console.WriteLine($"Internet:          {Internet,8:N2} Euro");
Console.WriteLine($"Handy:             {Handy,8:N2} Euro");
Console.WriteLine($"Streaming:         {Streaming,8:N2} Euro");
Console.WriteLine($"Spotify:           {Spotify,8:N2} Euro");
Console.WriteLine($"Lebensmittel:      {Lebensmittel,8:N2} Euro");
Console.WriteLine($"Drogerie:          {Drogerie,8:N2} Euro");
Console.WriteLine($"Autoleasing:       {Autoleasing,8:N2} Euro");
Console.WriteLine($"Versicherungen:    {Versicherungen,8:N2} Euro");
Console.WriteLine($"Kindergarten:      {Kindergarten,8:N2} Euro");
Console.WriteLine($"sonstige Ausgaben: {sonstigeAusgaben,8:N2} Euro");
Console.WriteLine("------------------------------");
Console.WriteLine($"Gesamtausgaben:    {gesamtAusgaben,8:N2} Euro");

//Überschuss am Monatsende
double ueberschuss = geamteinnahmen - gesamtAusgaben;
if (ueberschuss > 0)
{
    Console.WriteLine("Der Haushalt hat diesen Monat einen Überschuss. Er ist wirtschaftlich gesund.");
}
else if (ueberschuss == 0)
{
    Console.WriteLine("Einnahmen und Ausgaben sind genau ausgeglichen.");
}
else
{
    Console.WriteLine("Achtung: Die Ausgaben sind höher als die Einnahmen. Auf dauer wird ein sehr großes Minus auflaufen");
}

Console.WriteLine();
Console.WriteLine("MONATLICHE AUSWERTUNG");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Gesamteinnahmen: {geamteinnahmen,8:N2} Euro");
Console.WriteLine($"Gesamtausgaben:  {gesamtAusgaben,8:N2} Euro");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Überschuss:      {ueberschuss,8:N2} Euro");


static double ZahlEinlesen(string text)
{
    bool gueltig;
    double zahl;

    do
    {
        Console.Write(text);

        string? eingabe = Console.ReadLine();

        gueltig = double.TryParse(eingabe, out zahl);

        if (!gueltig)
        {
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
        }
    }
    while (!gueltig);

    return zahl;
}

//Git Hub Test
Console.WriteLine("Finanzplaner v0.4");