using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WPF;
using SkiaSharp;

namespace Finanzplaner_Wpf
{
    public partial class MainWindow : Window
    {
        #region EinnahmeButton

        private TextBox gehaltBenEingabe = new TextBox();
        private TextBox gehaltJanettEingabe = new TextBox();
        private TextBox KindergeldEingabe = new TextBox();
        private TextBox WohngeldEingabe = new TextBox();
        private TextBox KinderzuschlagEingabe = new TextBox();
        private TextBox Unterhalt_LillyEingabe = new TextBox();
        private TextBox sonstige_EinnahmenEingabe = new TextBox();


        private double gesamtEinnahmen;

        private double gehaltBen;
        private double gehaltJanett;
        private double Kindergeld;
        private double Wohngeld;
        private double Kinderzuschlag;
        private double Unterhalt_Lilly;
        private double sonstige_Einnahmen;

        public MainWindow()
        {
            InitializeComponent();
        }



        private void EinnahmenButton_Click(object sender, RoutedEventArgs e)


        {
            InhaltsBereich.Children.Clear();

            StackPanel einnahmenSeite = new StackPanel();

            TextBlock ueberschrift = new TextBlock
            {
                Text = "Einnahmen",
                FontSize = 32,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(
                    Color.FromRgb(38, 50, 56))
            };

            TextBlock beschreibung = new TextBlock
            {
                Text = "Trage hier deine monatlichen Einnahmen ein.",
                FontSize = 16,
                Margin = new Thickness(0, 5, 0, 30),
                Foreground = new SolidColorBrush(
                    Color.FromRgb(96, 125, 139))
            };

            TextBlock gehaltBenText = new TextBlock
            {
                Text = "Gehalt Ben",
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 8)
            };

            gehaltBenEingabe = new TextBox
            {
                Text = gehaltBen.ToString("0.00"),
                Height = 40,
                Width = 300,
                FontSize = 16,
                Padding = new Thickness(10, 6, 10, 6),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 20)
            };

            TextBlock gehaltJanettText = new TextBlock
            {
                Text = "Gehalt Janett",
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 8)
            };

            gehaltJanettEingabe = new TextBox
            {
                Text = gehaltJanett.ToString("0.00"),
                Height = 40,
                Width = 300,
                FontSize = 16,
                Padding = new Thickness(10, 6, 10, 6),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 20)
            };

            TextBlock KindergeldText = new TextBlock
            {

                Text = "Kindergeld",
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 8)
            };

            KindergeldEingabe = new TextBox
            {
                Text = Kindergeld.ToString("0.00"),
                Height = 40,
                Width = 300,
                FontSize = 16,
                Padding = new Thickness(10, 6, 10, 6),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 20)
            };

            TextBlock Unterhalt_LillyText = new TextBlock
            {
                Text = "Unterhalt Lilly",
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 8)
            };

            Unterhalt_LillyEingabe = new TextBox
            {
                Text = Unterhalt_Lilly.ToString("0.00"),
                Height = 40,
                Width = 300,
                FontSize = 16,
                Padding = new Thickness(10, 6, 10, 6),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 20)
            };

            TextBlock KindergeldzuschlagText = new TextBlock
            {
                Text = "Kinderdzuschlag",
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 8)
            };

            KinderzuschlagEingabe = new TextBox
            {
                Text = Kinderzuschlag.ToString("0.00"),
                Height = 40,
                Width = 300,
                FontSize = 16,
                Padding = new Thickness(10, 6, 10, 6),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 20)
            };

            TextBlock WohngeldText = new TextBlock
            {
                Text = "Wohngeld",
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 8)
            };

            WohngeldEingabe = new TextBox
            {
                Text = Wohngeld.ToString("0.00"),
                Height = 40,
                Width = 300,
                FontSize = 16,
                Padding = new Thickness(10, 6, 10, 6),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 20)
            };

            TextBlock sonstige_EinnahmenText = new TextBlock
            {
                Text = "Sonstige Einnahmen",
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 8)
            };

            sonstige_EinnahmenEingabe = new TextBox
            {
                Text = sonstige_Einnahmen.ToString("0.00"),
                Height = 40,
                Width = 300,
                FontSize = 16,
                Padding = new Thickness(10, 6, 10, 6),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 20)
            };

            Button einnahmenSpeichernButton = new Button
            {
                Content = "Einnahmen speichern",
                Width = 220,
                Height = 45,
                FontSize = 16,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 10, 0, 30),
                Background = new SolidColorBrush(Color.FromRgb(46, 125, 50)),
                Foreground = Brushes.White
            };

            //
            einnahmenSpeichernButton.Click += EinnahmenSpeichernButton_Click;

            // Überschrift und Beschreibung hinzufügen
            einnahmenSeite.Children.Add(ueberschrift);
            einnahmenSeite.Children.Add(beschreibung);

            // Alle Beschriftungen und Eingabefelder hinzufügen
            einnahmenSeite.Children.Add(gehaltBenText);
            einnahmenSeite.Children.Add(gehaltBenEingabe);

            einnahmenSeite.Children.Add(gehaltJanettText);
            einnahmenSeite.Children.Add(gehaltJanettEingabe);

            einnahmenSeite.Children.Add(KindergeldText);
            einnahmenSeite.Children.Add(KindergeldEingabe);

            einnahmenSeite.Children.Add(Unterhalt_LillyText);
            einnahmenSeite.Children.Add(Unterhalt_LillyEingabe);

            einnahmenSeite.Children.Add(KindergeldzuschlagText);
            einnahmenSeite.Children.Add(KinderzuschlagEingabe);

            einnahmenSeite.Children.Add(WohngeldText);
            einnahmenSeite.Children.Add(WohngeldEingabe);

            einnahmenSeite.Children.Add(sonstige_EinnahmenText);
            einnahmenSeite.Children.Add(sonstige_EinnahmenEingabe);

            // Speichern-Button hinzufügen
            einnahmenSeite.Children.Add(einnahmenSpeichernButton);

            // Einnahmenseite scrollbar machen
            ScrollViewer scrollViewer = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled,
                Content = einnahmenSeite
            };

            InhaltsBereich.Children.Add(scrollViewer);

        } // Ende von EinnahmenButton_Click

    
        private void EinnahmenSpeichernButton_Click(object sender, RoutedEventArgs e)
        {
            gehaltBen = WertEinlesen(gehaltBenEingabe);
            gehaltJanett = WertEinlesen(gehaltJanettEingabe);
            Kindergeld = WertEinlesen(KindergeldEingabe);
            Unterhalt_Lilly = WertEinlesen(Unterhalt_LillyEingabe);
            Kinderzuschlag = WertEinlesen(KinderzuschlagEingabe);
            Wohngeld = WertEinlesen(WohngeldEingabe);
            sonstige_Einnahmen = WertEinlesen(sonstige_EinnahmenEingabe);

            gesamtEinnahmen =
                gehaltBen +
                gehaltJanett +
                Kindergeld +
                Unterhalt_Lilly +
                Kinderzuschlag +
                Wohngeld +
                sonstige_Einnahmen;

            MessageBox.Show(
                $"Gesamteinnahmen: {gesamtEinnahmen:N2} €",
                "Einnahmen gespeichert");
        }

        private double WertEinlesen(TextBox eingabefeld)
        {
            if (double.TryParse(eingabefeld.Text, out double wert))
            {
                return wert;
            }

            return 0;
        }

        #endregion

        #region AusgabenButton

        // Eingabefelder
        private TextBox Miete = new TextBox();
        private TextBox Strom = new TextBox();
        private TextBox Internet = new TextBox();
        private TextBox Handys = new TextBox();
        private TextBox Lebensmittel = new TextBox();
        private TextBox Drogerie = new TextBox();
        private TextBox Tanken = new TextBox();
        private TextBox Versicherungen = new TextBox();
        private TextBox Kredit1 = new TextBox();
        private TextBox DispoBank = new TextBox();
        private TextBox Amazon = new TextBox();
        private TextBox Netflix = new TextBox();
        private TextBox Disney = new TextBox();
        private TextBox Autoleasing = new TextBox();
        private TextBox Kindergarten = new TextBox();
        private TextBox Klarna = new TextBox();

        // Gespeicherte Ausgaben
        private double mieteWert;
        private double stromWert;
        private double internetWert;
        private double handysWert;
        private double lebensmittelWert;
        private double drogerieWert;
        private double versicherungenWert;
        private double tankenWert;
        private double kredit1Wert;
        private double dispoBankWert;
        private double amazonWert;
        private double netflixWert;
        private double disneyWert;
        private double autoleasingWert;
        private double kindergartenWert;
        private double klarnaWert;
        private double gesamtAusgaben;


        // Ausgabenseite öffnen
        private void AusgabenButton_Click(object sender, RoutedEventArgs e)
        {
            InhaltsBereich.Children.Clear();

            StackPanel ausgabenSeite = new StackPanel();

            TextBlock ueberschrift = new TextBlock
            {
                Text = "Ausgaben",
                FontSize = 32,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(
                    Color.FromRgb(38, 50, 56))
            };

            TextBlock beschreibung = new TextBlock
            {
                Text = "Trage hier deine monatlichen Ausgaben ein.",
                FontSize = 16,
                Margin = new Thickness(0, 5, 0, 30),
                Foreground = new SolidColorBrush(
                    Color.FromRgb(96, 125, 139))
            };

            ausgabenSeite.Children.Add(ueberschrift);
            ausgabenSeite.Children.Add(beschreibung);

            // Miete
            ausgabenSeite.Children.Add(NeueBeschriftung("Miete"));
            Miete = NeuesEingabefeld(mieteWert);
            ausgabenSeite.Children.Add(Miete);

            // Strom
            ausgabenSeite.Children.Add(NeueBeschriftung("Strom"));
            Strom = NeuesEingabefeld(stromWert);
            ausgabenSeite.Children.Add(Strom);

            // Internet
            ausgabenSeite.Children.Add(NeueBeschriftung("Internet"));
            Internet = NeuesEingabefeld(internetWert);
            ausgabenSeite.Children.Add(Internet);

            // Handys
            ausgabenSeite.Children.Add(NeueBeschriftung("Handys"));
            Handys = NeuesEingabefeld(handysWert);
            ausgabenSeite.Children.Add(Handys);

            // Lebensmittel
            ausgabenSeite.Children.Add(NeueBeschriftung("Lebensmittel"));
            Lebensmittel = NeuesEingabefeld(lebensmittelWert);
            ausgabenSeite.Children.Add(Lebensmittel);

            // Drogerie
            ausgabenSeite.Children.Add(NeueBeschriftung("Drogerie"));
            Drogerie = NeuesEingabefeld(drogerieWert);
            ausgabenSeite.Children.Add(Drogerie);

            // Tanken
            ausgabenSeite.Children.Add(NeueBeschriftung("Tanken"));
            Tanken = NeuesEingabefeld(tankenWert);
            ausgabenSeite.Children.Add(Tanken);

            // Versicherungen
            ausgabenSeite.Children.Add(NeueBeschriftung("Versicherungen"));
            Versicherungen = NeuesEingabefeld(versicherungenWert);
            ausgabenSeite.Children.Add(Versicherungen);

            // Kredit 1
            ausgabenSeite.Children.Add(NeueBeschriftung("Kredit 1"));
            Kredit1 = NeuesEingabefeld(kredit1Wert);
            ausgabenSeite.Children.Add(Kredit1);

            // Dispo Bank
            ausgabenSeite.Children.Add(NeueBeschriftung("Dispo Bank"));
            DispoBank = NeuesEingabefeld(dispoBankWert);
            ausgabenSeite.Children.Add(DispoBank);

            // Amazon
            ausgabenSeite.Children.Add(NeueBeschriftung("Amazon"));
            Amazon = NeuesEingabefeld(amazonWert);
            ausgabenSeite.Children.Add(Amazon);

            // Netflix
            ausgabenSeite.Children.Add(NeueBeschriftung("Netflix"));
            Netflix = NeuesEingabefeld(netflixWert);
            ausgabenSeite.Children.Add(Netflix);

            // Disney+
            ausgabenSeite.Children.Add(NeueBeschriftung("Disney+"));
            Disney = NeuesEingabefeld(disneyWert);
            ausgabenSeite.Children.Add(Disney);

            // Autoleasing
            ausgabenSeite.Children.Add(NeueBeschriftung("Autoleasing"));
            Autoleasing = NeuesEingabefeld(autoleasingWert);
            ausgabenSeite.Children.Add(Autoleasing);

            // Kindergarten
            ausgabenSeite.Children.Add(NeueBeschriftung("Kindergarten"));
            Kindergarten = NeuesEingabefeld(kindergartenWert);
            ausgabenSeite.Children.Add(Kindergarten);

            // Klarna
            ausgabenSeite.Children.Add(NeueBeschriftung("Klarna"));
            Klarna = NeuesEingabefeld(klarnaWert);
            ausgabenSeite.Children.Add(Klarna);

            // Speichern-Button
            Button ausgabenSpeichernButton = new Button
            {
                Content = "Ausgaben speichern",
                Width = 220,
                Height = 45,
                FontSize = 16,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 10, 0, 30),
                Background = new SolidColorBrush(
                    Color.FromRgb(198, 40, 40)),
                Foreground = Brushes.White
            };

            ausgabenSpeichernButton.Click += AusgabenSpeichernButton_Click;
            ausgabenSeite.Children.Add(ausgabenSpeichernButton);

            // Seite scrollbar machen
            ScrollViewer scrollViewer = new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled,
                Content = ausgabenSeite
            };

            InhaltsBereich.Children.Add(scrollViewer);
        }


        // Ausgaben speichern und Gesamtsumme berechnen
        private void AusgabenSpeichernButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            mieteWert = WertEinlesen(Miete);
            stromWert = WertEinlesen(Strom);
            internetWert = WertEinlesen(Internet);
            handysWert = WertEinlesen(Handys);
            lebensmittelWert = WertEinlesen(Lebensmittel);
            drogerieWert = WertEinlesen(Drogerie);
            versicherungenWert = WertEinlesen(Versicherungen);
            tankenWert = WertEinlesen(Tanken);
            kredit1Wert = WertEinlesen(Kredit1);
            dispoBankWert = WertEinlesen(DispoBank);
            amazonWert = WertEinlesen(Amazon);
            netflixWert = WertEinlesen(Netflix);
            disneyWert = WertEinlesen(Disney);
            autoleasingWert = WertEinlesen(Autoleasing);
            kindergartenWert = WertEinlesen(Kindergarten);
            klarnaWert = WertEinlesen(Klarna);

            gesamtAusgaben =
                mieteWert +
                stromWert +
                internetWert +
                handysWert +
                lebensmittelWert +
                drogerieWert +
                versicherungenWert +
                tankenWert +
                kredit1Wert +
                dispoBankWert +
                amazonWert +
                netflixWert +
                disneyWert +
                autoleasingWert +
                kindergartenWert +
                klarnaWert;

            MessageBox.Show(
                $"Gesamtausgaben: {gesamtAusgaben:N2} €",
                "Ausgaben gespeichert");
        }


        // Erstellt eine Beschriftung
        private TextBlock NeueBeschriftung(string text)
        {
            return new TextBlock
            {
                Text = text,
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 8)
            };
        }


        // Erstellt ein Eingabefeld
        private TextBox NeuesEingabefeld(double gespeicherterWert)
        {
            return new TextBox
            {
                Text = gespeicherterWert.ToString("0.00"),
                Height = 40,
                Width = 300,
                FontSize = 16,
                Padding = new Thickness(10, 6, 10, 6),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 20)
            };
        }

        #endregion

        #region DasboardButton

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            InhaltsBereich.Children.Clear();

            StackPanel dashboardSeite = new StackPanel();

            // Überschrift
            TextBlock ueberschrift = new TextBlock
            {
                Text = "Dashboard",
                FontSize = 32,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(
                    Color.FromRgb(38, 50, 56))
            };

            // Beschreibung
            TextBlock beschreibung = new TextBlock
            {
                Text = "Übersicht deiner aktuellen Finanzplanung",
                FontSize = 16,
                Margin = new Thickness(0, 5, 0, 20),
                Foreground = new SolidColorBrush(
                    Color.FromRgb(96, 125, 139))
            };

            // Button zum Zurücksetzen
            Button allesZuruecksetzenButton = new Button
            {
                Content = "Alle Werte zurücksetzen",
                Width = 220,
                Height = 45,
                FontSize = 16,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 25),
                Background = new SolidColorBrush(
                    Color.FromRgb(198, 40, 40)),
                Foreground = Brushes.White
            };

            allesZuruecksetzenButton.Click +=
                AllesZuruecksetzenButton_Click;

            // Gesamteinnahmen
            TextBlock einnahmenTitel = new TextBlock
            {
                Text = "Gesamteinnahmen",
                FontSize = 18,
                FontWeight = FontWeights.Bold
            };

            TextBlock einnahmenWert = new TextBlock
            {
                Text = $"{gesamtEinnahmen:N2} €",
                FontSize = 30,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(
                    Color.FromRgb(46, 125, 50)),
                Margin = new Thickness(0, 5, 0, 25)
            };

            // Gesamtausgaben
            TextBlock ausgabenTitel = new TextBlock
            {
                Text = "Gesamtausgaben",
                FontSize = 18,
                FontWeight = FontWeights.Bold
            };

            TextBlock ausgabenWert = new TextBlock
            {
                Text = $"{gesamtAusgaben:N2} €",
                FontSize = 30,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(
                    Color.FromRgb(198, 40, 40)),
                Margin = new Thickness(0, 5, 0, 25)
            };

            // Überschuss oder Fehlbetrag berechnen
            double ueberschuss =
                gesamtEinnahmen - gesamtAusgaben;

            TextBlock ergebnisTitel = new TextBlock
            {
                Text = "Verfügbarer Betrag am Monatsende",
                FontSize = 18,
                FontWeight = FontWeights.Bold
            };

            TextBlock ergebnisWert = new TextBlock
            {
                Text = $"{ueberschuss:N2} €",
                FontSize = 34,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 5, 0, 15)
            };

            TextBlock bewertung = new TextBlock
            {
                FontSize = 16,
                FontWeight = FontWeights.Bold,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 0, 0, 20)
            };

            // Ergebnis farblich bewerten
            if (ueberschuss > 0)
            {
                ergebnisWert.Foreground =
                    new SolidColorBrush(
                        Color.FromRgb(46, 125, 50));

                bewertung.Text =
                    "Dein Haushalt erzielt aktuell einen monatlichen Überschuss.";

                bewertung.Foreground =
                    new SolidColorBrush(
                        Color.FromRgb(46, 125, 50));
            }
            else if (ueberschuss == 0)
            {
                ergebnisWert.Foreground =
                    new SolidColorBrush(
                        Color.FromRgb(245, 124, 0));

                bewertung.Text =
                    "Einnahmen und Ausgaben sind genau ausgeglichen.";

                bewertung.Foreground =
                    new SolidColorBrush(
                        Color.FromRgb(245, 124, 0));
            }
            else
            {
                ergebnisWert.Foreground =
                    new SolidColorBrush(
                        Color.FromRgb(198, 40, 40));

                bewertung.Text =
                    "Achtung: Deine Ausgaben sind höher als deine Einnahmen.";

                bewertung.Foreground =
                    new SolidColorBrush(
                        Color.FromRgb(198, 40, 40));
            }

            // Überschrift Balkendiagramm
            TextBlock diagrammTitel = new TextBlock
            {
                Text = "Einnahmen gegen Ausgaben",
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 20, 0, 10)
            };

            // Balkendiagramm
            CartesianChart einnahmenAusgabenDiagramm =
                new CartesianChart
                {
                    Height = 350,

                    HorizontalAlignment =
                        HorizontalAlignment.Stretch,

                    Series = new ISeries[]
                    {
                new ColumnSeries<double?>
                {
                    Name = "Einnahmen",

                    Values = new double?[]
                    {
                        gesamtEinnahmen,
                        null
                    },

                    Fill = new SolidColorPaint(
                        new SKColor(46, 125, 50))
                },

                new ColumnSeries<double?>
                {
                    Name = "Ausgaben",

                    Values = new double?[]
                    {
                        null,
                        gesamtAusgaben
                    },

                    Fill = new SolidColorPaint(
                        new SKColor(198, 40, 40))
                }
                    },

                    XAxes = new Axis[]
                    {
                new Axis
                {
                    Labels = new string[]
                    {
                        "Einnahmen",
                        "Ausgaben"
                    },

                    ForceStepToMin = true,
                    MinStep = 1
                }
                    },

                    YAxes = new Axis[]
                    {
                new Axis
                {
                    Labeler = wert => $"{wert:N0} €",
                    MinLimit = 0
                }
                    }
                };

            // Überschrift Kreisdiagramm
            TextBlock kreisdiagrammTitel = new TextBlock
            {
                Text = "Verteilung der Ausgaben",
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 30, 0, 10)
            };

            // Kreisdiagramm
            PieChart ausgabenKreisdiagramm = new PieChart
            {
                Height = 400,

                HorizontalAlignment =
                    HorizontalAlignment.Stretch,

                Series = new ISeries[]
                {
            new PieSeries<double>
            {
                Name = "Miete",
                Values = new double[] { mieteWert }
            },

            new PieSeries<double>
            {
                Name = "Strom",
                Values = new double[] { stromWert }
            },

            new PieSeries<double>
            {
                Name = "Internet",
                Values = new double[] { internetWert }
            },

            new PieSeries<double>
            {
                Name = "Handys",
                Values = new double[] { handysWert }
            },

            new PieSeries<double>
            {
                Name = "Lebensmittel",
                Values = new double[] { lebensmittelWert }
            },

            new PieSeries<double>
            {
                Name = "Drogerie",
                Values = new double[] { drogerieWert }
            },

            new PieSeries<double>
            {
                Name = "Versicherungen",
                Values = new double[] { versicherungenWert }
            },

            new PieSeries<double>
            {
                Name = "Tanken",
                Values = new double[] { tankenWert }
            },

            new PieSeries<double>
            {
                Name = "Kredit 1",
                Values = new double[] { kredit1Wert }
            },

            new PieSeries<double>
            {
                Name = "Dispo Bank",
                Values = new double[] { dispoBankWert }
            },

            new PieSeries<double>
            {
                Name = "Amazon",
                Values = new double[] { amazonWert }
            },

            new PieSeries<double>
            {
                Name = "Netflix",
                Values = new double[] { netflixWert }
            },

            new PieSeries<double>
            {
                Name = "Disney+",
                Values = new double[] { disneyWert }
            },

            new PieSeries<double>
            {
                Name = "Autoleasing",
                Values = new double[] { autoleasingWert }
            },

            new PieSeries<double>
            {
                Name = "Kindergarten",
                Values = new double[] { kindergartenWert }
            },

            new PieSeries<double>
            {
                Name = "Klarna",
                Values = new double[] { klarnaWert }
            }
                },

                LegendPosition =
                    LiveChartsCore.Measure.LegendPosition.Right
            };

            // Alle Inhalte zum Dashboard hinzufügen
            dashboardSeite.Children.Add(ueberschrift);
            dashboardSeite.Children.Add(beschreibung);

            dashboardSeite.Children.Add(einnahmenTitel);
            dashboardSeite.Children.Add(einnahmenWert);

            dashboardSeite.Children.Add(ausgabenTitel);
            dashboardSeite.Children.Add(ausgabenWert);

            dashboardSeite.Children.Add(ergebnisTitel);
            dashboardSeite.Children.Add(ergebnisWert);
            dashboardSeite.Children.Add(bewertung);

            // Zurücksetzen-Button nach den Finanzwerten
            dashboardSeite.Children.Add(allesZuruecksetzenButton);

            // Balkendiagramm
            dashboardSeite.Children.Add(diagrammTitel);
            dashboardSeite.Children.Add(einnahmenAusgabenDiagramm);

            // Kreisdiagramm
            dashboardSeite.Children.Add(kreisdiagrammTitel);
            dashboardSeite.Children.Add(ausgabenKreisdiagramm);

            // Dashboard scrollbar machen
            ScrollViewer dashboardScrollViewer =
                new ScrollViewer
                {
                    VerticalScrollBarVisibility =
                        ScrollBarVisibility.Auto,

                    HorizontalScrollBarVisibility =
                        ScrollBarVisibility.Disabled,

                    Content = dashboardSeite
                };

            // Dashboard anzeigen
            InhaltsBereich.Children.Add(
                dashboardScrollViewer);
        }


        // Wird ausgeführt, wenn der Zurücksetzen-Button angeklickt wird
        private void AllesZuruecksetzenButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            MessageBoxResult ergebnis = MessageBox.Show(
                "Möchtest du wirklich alle Einnahmen und Ausgaben zurücksetzen?",
                "Alle Werte zurücksetzen",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            // Bei Nein wird nichts verändert
            if (ergebnis != MessageBoxResult.Yes)
            {
                return;
            }


            // Alle Einnahmen zurückstezen

            gehaltBen = 0;
            gehaltJanett = 0;
            Kindergeld = 0;
            Kinderzuschlag = 0;
            Unterhalt_Lilly = 0;
            Wohngeld = 0;
            sonstige_Einnahmen = 0;


            // Alle Ausgaben zurücksetzen
            mieteWert = 0;
            stromWert = 0;
            internetWert = 0;
            handysWert = 0;
            lebensmittelWert = 0;
            drogerieWert = 0;
            versicherungenWert = 0;
            tankenWert = 0;
            kredit1Wert = 0;
            dispoBankWert = 0;
            amazonWert = 0;
            netflixWert = 0;
            disneyWert = 0;
            autoleasingWert = 0;
            kindergartenWert = 0;
            klarnaWert = 0;

            // Gesamtsummen zurücksetzen
            gesamtAusgaben = 0;
            gesamtEinnahmen = 0;

            MessageBox.Show(
                "Die gespeicherten Werte wurden zurückgesetzt.",
                "Zurücksetzen abgeschlossen",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

            // Dashboard neu laden
            DashboardButton_Click(sender, e);
        }
        #endregion
    }
} // beendet den Namespace