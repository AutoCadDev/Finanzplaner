using System.Diagnostics.Metrics;

string auswahlNeustart;

do
{
Console.Clear();

Console.WriteLine("FINANZPLANER");
Console.WriteLine("------------------------------");
Console.WriteLine("Private Haushaltsplanung");
Console.WriteLine();

#region Erste Situation wenn Ben weiter in der Erlas ist und Janett Elterngeld erhält.

// Situatiion 1: Ben weiter in der Erlas und Janett im Elterngeld.
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

    #region Ausgaben von Ben 

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

    Console.WriteLine("------------------------------");
    Console.WriteLine("Bitte gib nun die Ausgaben von Ben ein. ");

    //Ausgaben 
    double Miete = 0;
double Strom = 0;
double Internet = 0;
double Handy = 0;
double Spritgeld = 0;
double Spotify = 0;
double Versicherungen = 0;
double GEZ = 0;
double Lebensmittel = 0;
double Drogerie = 0;
double Autoleasing = 0;
double KindergartenLuca = 0;
double sonstigeAusgaben = 0;

Miete = ZahlEinlesen("Bitte geben Sie die Miete ein: ");

Strom = ZahlEinlesen("Bitte geben Sie die Kosten für Strom ein: ");

Internet = ZahlEinlesen("Bitte geben Sie die Kosten für Internet ein: ");

Handy = ZahlEinlesen("Bitte geben Sie die Kosten für Handy ein: ");

Spritgeld = ZahlEinlesen("Bitte geben Sie die Kosten für Spritgeld ein: ");

Spotify = ZahlEinlesen("Bitte geben Sie die Kosten für Spotify ein: ");

GEZ = ZahlEinlesen("Bitte geben Sie die Kosten für GEZ ein: ");

Lebensmittel = ZahlEinlesen("Bitte geben Sie die Kosten für Lebensmittel ein: ");

Drogerie = ZahlEinlesen("Bitte geben Sie die Kosten für Drogerie ein: ");

Versicherungen = ZahlEinlesen("Bitte geben Sie die Kosten für Versicherungen ein: ");

Autoleasing = ZahlEinlesen("Bitte geben Sie die Kosten für Autoleasing ein: ");

KindergartenLuca = ZahlEinlesen("Bitte geben Sie die Kosten für den Kindergarten von Luca ein: ");

sonstigeAusgaben = ZahlEinlesen("Bitte geben Sie die Kosten für den sonstige Ausgaben ein: ");

// Berechnung der Gesamtausgaben

double gesamtAusgabenBen = Miete 
    + Strom 
    + Internet 
    + Handy 
    + Spritgeld 
    + Spotify 
    + GEZ
    + Lebensmittel 
    + Drogerie
    + Autoleasing
    + Versicherungen
    + KindergartenLuca
    + sonstigeAusgaben;

// Ausgabe
Console.WriteLine("MONATLICHE Ausgaben");
Console.WriteLine("------------------------------");
Console.WriteLine($"Miete:             {Miete,8:N2} Euro");
Console.WriteLine($"Strom:             {Strom,8:N2} Euro");
Console.WriteLine($"Internet:          {Internet,8:N2} Euro");
Console.WriteLine($"Handy:             {Handy,8:N2} Euro");
Console.WriteLine($"Spritgeld:         {Spritgeld,8:N2} Euro");
Console.WriteLine($"Spotify:           {Spotify,8:N2} Euro");
Console.WriteLine($"GEZ:               {GEZ,8:N2} Euro");
Console.WriteLine($"Lebensmittel:      {Lebensmittel,8:N2} Euro");
Console.WriteLine($"Drogerie:          {Drogerie,8:N2} Euro");
Console.WriteLine($"Autoleasing:       {Autoleasing,8:N2} Euro");
Console.WriteLine($"Versicherungen:    {Versicherungen,8:N2} Euro");
Console.WriteLine($"KindergartenLuca:  {KindergartenLuca,8:N2} Euro");
Console.WriteLine($"sonstige Ausgaben: {sonstigeAusgaben,8:N2} Euro");
Console.WriteLine("------------------------------");
Console.WriteLine($"Gesamtausgaben:    {gesamtAusgabenBen,8:N2} Euro");

    #endregion

    Console.WriteLine("------------------------------");
    Console.WriteLine("Bitte gib nun die Ausgaben von Janett ein. ");

    #region Ausgaben von Janett

    //Ausgaben 
    double LebensmittelJanett = 0;
    double AutoleasingJanett = 0;
    double Kredit1 = 0;
    double Kredit2 = 0;
    double Tanken = 0;
    double KindergartenLilly = 0;
    double HandyJanett = 0;
    double Amazon = 0;
    double Netflix = 0;
    double Disney = 0;
    double Autoversicherung = 0;
    double Klarna = 0;
    double sonstigeAusgabenJanett = 0;

    LebensmittelJanett = ZahlEinlesen("Bitte geben Sie die Kosten für Lebensmittel ein: ");

    AutoleasingJanett = ZahlEinlesen("Bitte geben Sie die Kosten für Autoleasing ein: ");

    Kredit1 = ZahlEinlesen("Bitte geben Sie die Kosten für Kredit1 ein: ");

    Kredit2 = ZahlEinlesen("Bitte geben Sie die Kosten für Kredit2 ein: ");

    Tanken = ZahlEinlesen("Bitte geben Sie die Kosten für Tanken ein: ");

    KindergartenLilly = ZahlEinlesen("Bitte geben Sie die Kosten für den Kindergarten von Lilly ein: ");

    HandyJanett = ZahlEinlesen("Bitte geben Sie die Kosten für Handy ein: ");

    Amazon = ZahlEinlesen("Bitte geben Sie die Kosten für Amazon ein: ");

    Netflix = ZahlEinlesen("Bitte geben Sie die Kosten für Netflix ein: ");

    Disney = ZahlEinlesen("Bitte geben Sie die Kosten für Disney ein: ");

    Autoversicherung = ZahlEinlesen("Bitte geben Sie die Kosten für Autoversicherung ein: ");

    Klarna = ZahlEinlesen("Bitte geben Sie die Kosten für Klarna ein: ");

    sonstigeAusgabenJanett = ZahlEinlesen("Bitte geben Sie die Kosten für den sonstige Ausgaben ein: ");

    // Berechnung der Gesamtausgaben

    double gesamtAusgabenJanett = LebensmittelJanett
        + AutoleasingJanett
        + Kredit1
        + Kredit2
        + Tanken
        + HandyJanett
        + Amazon
        + Netflix
        + Disney
        + Autoversicherung
        + Klarna
        + sonstigeAusgaben;
       
    // Ausgabe
    Console.WriteLine("MONATLICHE Ausgaben");
    Console.WriteLine("------------------------------");
    Console.WriteLine($"LebensmittelJanett:{LebensmittelJanett,8:N2} Euro");
    Console.WriteLine($"AutoleasingJanett: {AutoleasingJanett,8:N2} Euro");
    Console.WriteLine($"Kredit1:           {Kredit1,8:N2} Euro");
    Console.WriteLine($"Kredit2:           {Kredit2,8:N2} Euro");
    Console.WriteLine($"Spritgeld:         {Spritgeld,8:N2} Euro");
    Console.WriteLine($"KindergartenLilly: {KindergartenLilly,8:N2} Euro");
    Console.WriteLine($"HandyJanett:       {HandyJanett,8:N2} Euro");
    Console.WriteLine($"Amazon:            {Amazon,8:N2} Euro");
    Console.WriteLine($"Netflix:           {Netflix,8:N2} Euro");
    Console.WriteLine($"Disney:            {Disney,8:N2} Euro");
    Console.WriteLine($"Autoversicherung:  {Autoversicherung,8:N2} Euro");
    Console.WriteLine($"Klarna:            {Klarna,8:N2} Euro");
    Console.WriteLine($"sonstige Ausgaben: {sonstigeAusgaben,8:N2} Euro");
    Console.WriteLine("------------------------------");
    Console.WriteLine($"Gesamtausgaben:    {gesamtAusgabenJanett,8:N2} Euro");
    #endregion

 double gesamtausgaben = gesamtAusgabenBen + gesamtAusgabenJanett;

    //Überschuss am Monatsende
    double ueberschuss = geamteinnahmen - gesamtausgaben;
if (ueberschuss > 0)
{
    Console.WriteLine($"Monatlicher Überschuss: {ueberschuss:N2} Euro");
    Console.WriteLine("Der Haushalt hat diesen Monat einen Überschuss. Er ist wirtschaftlich gesund.");
    Console.WriteLine($"Durch den Überschuss von {ueberschuss:N2} Euro kann der Haushalt Rücklagen bilden oder Schulden abbauen.");
    }
else if (ueberschuss == 0)
{
    Console.WriteLine("Monatlicher Restbetrag: 0.00 Euro");
    Console.WriteLine("Einnahmen und Ausgaben sind genau ausgeglichen. Es kann kein finanzieller Puffer aufgebaut werden");
}
else
{
    Console.WriteLine("Monatliches Defizit: {Math.Abs(ueberschuss):N2} Euro");
    Console.WriteLine("Achtung: Die Ausgaben sind höher als die Einnahmen. Auf dauer wird ein sehr großes Minus auflaufen");
}

Console.WriteLine();
Console.WriteLine("MONATLICHE AUSWERTUNG");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Gesamteinnahmen: {geamteinnahmen,8:N2} Euro");
Console.WriteLine($"Gesamtausgaben:  {gesamtausgaben,8:N2} Euro");
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

#endregion

#region Zweite Situation wenn Ben bei Erlas weiter arbeitet und Janett Elterngeld Plus bekommt.

// Zweite Situation wenn Ben bei Erlas weiter arbeitet und Janett Elterngeld Plus bekommt.
Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine("SITUATION 2 – wenn Ben bei Erlas weiter arbeitet und Janett Elterngeld Plus bekommt");
Console.WriteLine("Die Ausgaben bleiben unverändert.");
Console.WriteLine("================================");
Console.WriteLine();

// Neue Einnahmen einlesen
double neuesGehaltBen =
    ZahlEinlesen("Bitte geben Sie das neue Gehalt von Ben ein: ");

double neuesGehaltJanett =
    ZahlEinlesen("Bitte geben Sie das neue Gehalt von Janett ein: ");

double neuesKindergeld =
    ZahlEinlesen("Bitte geben Sie das neue Kindergeld ein: ");

double neuesWohngeld =
    ZahlEinlesen("Bitte geben Sie das neue Wohngeld ein: ");

double neuerKinderzuschlag =
    ZahlEinlesen("Bitte geben Sie den neuen Kinderzuschlag ein: ");

double neuerUnterhalt =
    ZahlEinlesen("Bitte geben Sie den neuen Unterhalt ein: ");

double neueSonstigeEinnahmen =
    ZahlEinlesen("Bitte geben Sie die neuen sonstigen Einnahmen ein: ");

// Neue Gesamteinnahmen berechnen
double neueGesamteinnahmen =
    neuesGehaltBen
    + neuesGehaltJanett
    + neuesKindergeld
    + neuesWohngeld
    + neuerKinderzuschlag
    + neuerUnterhalt
    + neueSonstigeEinnahmen;

    // Die vorhandenen Ausgaben werden erneut verwendet
    double gesamtAusgaben = gesamtAusgabenBen + gesamtAusgabenJanett;
    double neuerUeberschuss = neueGesamteinnahmen - gesamtAusgaben;

// Ausgabe der zweiten Situation
Console.WriteLine();
Console.WriteLine("AUSWERTUNG – NEUE SITUATION");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Neue Gesamteinnahmen: {neueGesamteinnahmen,10:N2} Euro");
Console.WriteLine($"Unveränderte Ausgaben: {gesamtAusgaben,9:N2} Euro");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Neuer Überschuss:      {neuerUeberschuss,9:N2} Euro");

// Bewertung der zweiten Situation
if (neuerUeberschuss > 0)
{
    Console.WriteLine(
        "Der Haushalt hat in der neuen Situation einen Überschuss.");
    Console.WriteLine($"Durch den Überschuss von {neuerUeberschuss:N2} Euro kann der Haushalt Rücklagen bilden oder Schulden abbauen.");
    }
else if (neuerUeberschuss == 0)
{
    Console.WriteLine(
        "Die neuen Einnahmen und die Ausgaben sind genau ausgeglichen.");
}
else
{
    Console.WriteLine(
        "Achtung: Auch in der neuen Situation sind die Ausgaben höher als die Einnahmen.");
}

// Vergleich beider Situationen
double unterschied = neuerUeberschuss - ueberschuss;

Console.WriteLine();
Console.WriteLine("VERGLEICH BEIDER SITUATIONEN");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Bisheriger Überschuss: {ueberschuss,10:N2} Euro");
Console.WriteLine($"Neuer Überschuss:      {neuerUeberschuss,10:N2} Euro");
Console.WriteLine($"Veränderung:           {unterschied,10:N2} Euro");

    if (unterschied > 0)
    {
        Console.WriteLine($"Die neue Situation ist monatlich um {unterschied:N2} Euro besser.");

        Console.WriteLine($"Durch den neuen Überschuss kann der Haushalt immernoch Rücklagen in Höhe von {neuerUeberschuss:N2} Euro bilden oder Schulden abbauen.");
    }
    else if (unterschied < 0)
    {
        Console.WriteLine(
            $"Die neue Situation ist monatlich um {Math.Abs(unterschied):N2} Euro schlechter.");
    }
    else
    {
        Console.WriteLine("Beide Situationen führen zum gleichen Ergebnis.");
    }

#endregion

#region Dritte Situation wenn Ben die Stelle bei Schmitt und Sohn unterschrieben hat.

// Dritte Situation wenn Ben die Stelle bei Schmitt und Sohn unterschrieben hat.
Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine("SITUATION 3 – wenn Ben die Stelle bei Schmitt und Sohn unterschrieben hat");
Console.WriteLine("Die Ausgaben bleiben unverändert.");
Console.WriteLine("================================");
Console.WriteLine();

// Neue Einnahmen einlesen
double neuesGehaltBen3 =
    ZahlEinlesen("Bitte geben Sie das neue Gehalt von Ben ein: ");

double neuesGehaltJanett3 =
    ZahlEinlesen("Bitte geben Sie das neue Gehalt von Janett ein: ");

double neuesKindergeld3 =
    ZahlEinlesen("Bitte geben Sie das neue Kindergeld ein: ");

double neuesWohngeld3 =
    ZahlEinlesen("Bitte geben Sie das neue Wohngeld ein: ");

double neuerKinderzuschlag3 =
    ZahlEinlesen("Bitte geben Sie den neuen Kinderzuschlag ein: ");

double neuerUnterhalt3 =
    ZahlEinlesen("Bitte geben Sie den neuen Unterhalt ein: ");

double neueSonstigeEinnahmen3 =
    ZahlEinlesen("Bitte geben Sie die neuen sonstigen Einnahmen ein: ");

// Neue Gesamteinnahmen berechnen
double neueGesamteinnahmen3 =
    neuesGehaltBen3
    + neuesGehaltJanett3
    + neuesKindergeld3
    + neuesWohngeld3
    + neuerKinderzuschlag3
    + neuerUnterhalt3
    + neueSonstigeEinnahmen3;

// Die vorhandenen Ausgaben werden erneut verwendet
double neuerUeberschuss3 = neueGesamteinnahmen3 - gesamtAusgaben;

// Ausgabe der dritten Situation
Console.WriteLine();
Console.WriteLine("AUSWERTUNG – NEUE SITUATION");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Neue Gesamteinnahmen: {neueGesamteinnahmen3,10:N2} Euro");
Console.WriteLine($"Unveränderte Ausgaben: {gesamtAusgaben,9:N2} Euro");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Neuer Überschuss:      {neuerUeberschuss3,9:N2} Euro");

// Bewertung der dritten Situation
if (neuerUeberschuss3 > 0)
{
    Console.WriteLine(
        "Der Haushalt hat in der neuen Situation einen Überschuss.");
        Console.WriteLine($"Durch den Überschuss von {neuerUeberschuss3:N2} Euro kann der Haushalt Rücklagen bilden oder Schulden abbauen.");
    }
else if (neuerUeberschuss3 == 0)
{
    Console.WriteLine(
        "Die neuen Einnahmen und die Ausgaben sind genau ausgeglichen.");
}
else
{
    Console.WriteLine(
        "Achtung: Auch in der neuen Situation sind die Ausgaben höher als die Einnahmen.");
}

// Vergleich beider Situationen
double unterschied3 = neuerUeberschuss3 - ueberschuss;

Console.WriteLine();
Console.WriteLine("VERGLEICH BEIDER SITUATIONEN");
Console.WriteLine("--------------------------------");
Console.WriteLine($"Bisheriger Überschuss: {ueberschuss,10:N2} Euro");
Console.WriteLine($"Neuer Überschuss:      {neuerUeberschuss3,10:N2} Euro");
Console.WriteLine($"Veränderung:           {unterschied,10:N2} Euro");

if (unterschied3 > 0)
{
    Console.WriteLine(
        $"Die dritte Situation ist monatlich um {unterschied3:N2} Euro besser.");
}
else if (unterschied3 < 0)
{
    Console.WriteLine(
        $"Die dritte Situation ist monatlich um {Math.Abs(unterschied3):N2} Euro schlechter.");
}
else
{
    Console.WriteLine("Beide Situationen führen zum gleichen Ergebnis.");
}

#endregion

#region Situation 2 mit Situation 3 vergleichen

Console.WriteLine();
Console.WriteLine("VERGLEICH SITUATION 2 UND 3");
Console.WriteLine("------------------------------");

double restbetrag2 = neuerUeberschuss;
double restbetrag3 = neuerUeberschuss3;
double unterschiedSituation2Und3 = restbetrag3 - restbetrag2;

Console.WriteLine($"Restbetrag Situation 2: {restbetrag2,10:N2} Euro");
Console.WriteLine($"Restbetrag Situation 3: {restbetrag3,10:N2} Euro");
Console.WriteLine($"Veränderung:            {unterschiedSituation2Und3,10:N2} Euro");

if (unterschiedSituation2Und3 > 0)
{
    Console.WriteLine(
        $"Situation 3 ist monatlich um {unterschiedSituation2Und3:N2} Euro besser als Situation 2.");
}
else if (unterschiedSituation2Und3 < 0)
{
    Console.WriteLine(
        $"Situation 3 ist monatlich um {Math.Abs(unterschiedSituation2Und3):N2} Euro schlechter als Situation 2.");
}
else
{
    Console.WriteLine("Situation 2 und Situation 3 sind finanziell gleich.");
}

#endregion

#region Gesamtauswertung aller drei Situationen

Console.WriteLine();
Console.WriteLine("GESAMTAUSWERTUNG");
Console.WriteLine("------------------------------");

double besterRestbetrag = Math.Max(
    ueberschuss,
    Math.Max(neuerUeberschuss, neuerUeberschuss3)
);

Console.WriteLine($"Höchster Restbetrag: {besterRestbetrag:N2} Euro");

    if (besterRestbetrag < 0)
    {
        Console.WriteLine();
        Console.WriteLine("WARNUNG: In allen Situationen sind die Ausgaben höher als die Einnahmen.");
    }
    else if (besterRestbetrag == 0)
    {
        Console.WriteLine();
        Console.WriteLine("Hinweis: In der besten Situation bleibt kein finanzieller Überschuss.");
    }

    if (ueberschuss == neuerUeberschuss &&
    neuerUeberschuss == neuerUeberschuss3)
{
    Console.WriteLine("Alle drei Situationen sind finanziell gleich.");
}
else if (ueberschuss == neuerUeberschuss &&
         ueberschuss == besterRestbetrag)
{
    Console.WriteLine("Situation 1 und Situation 2 sind finanziell am günstigsten.");
}
else if (ueberschuss == neuerUeberschuss3 &&
         ueberschuss == besterRestbetrag)
{
    Console.WriteLine("Situation 1 und Situation 3 sind finanziell am günstigsten.");
}
else if (neuerUeberschuss == neuerUeberschuss3 &&
         neuerUeberschuss == besterRestbetrag)
{
    Console.WriteLine("Situation 2 und Situation 3 sind finanziell am günstigsten.");
}
else if (besterRestbetrag == ueberschuss)
{
    Console.WriteLine("Situation 1 ist finanziell am günstigsten.");
}
else if (besterRestbetrag == neuerUeberschuss)
{
    Console.WriteLine("Situation 2 ist finanziell am günstigsten.");
}
else
{
    Console.WriteLine("Situation 3 ist finanziell am günstigsten.");
}


    #endregion

#region Programmende oder neue Berechnung starten
    do
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.WriteLine("Möchten Sie eine neue Berechnung durchführen?");
        Console.WriteLine("J = Programm neu starten");
        Console.WriteLine("N = Programm beenden");
        Console.Write("Ihre Auswahl: ");

        auswahlNeustart = Console.ReadLine()?.Trim().ToUpper() ?? "";

        if (auswahlNeustart != "J" && auswahlNeustart != "N")
        {
            Console.WriteLine();
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie J oder N ein.");
        }

    } while (auswahlNeustart != "J" && auswahlNeustart != "N");

} while (auswahlNeustart == "J");

#endregion

Console.WriteLine();
Console.WriteLine("------------------------------");
Console.WriteLine("Auswertung abgeschlossen.");
Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
Console.ReadKey();
