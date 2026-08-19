using System;
using System.Threading;
using System.Windows;

namespace Finanzplaner_Wpf
{
    public partial class App : Application
    {
        protected override void OnStartup(
            StartupEventArgs e)
        {
            base.OnStartup(e);

            // Startbild erstellen
            SplashScreen startbild = new SplashScreen(
                "Assets/Finanzplaner_Startbild.png");

            // Startbild anzeigen
            startbild.Show(false);

            // Startbild zwei Sekunden anzeigen
            Thread.Sleep(2000);

            // Hauptfenster erstellen
            MainWindow hauptfenster = new MainWindow();

            // Hauptfenster als Hauptfenster festlegen
            MainWindow = hauptfenster;

            // Hauptfenster anzeigen
            hauptfenster.Show();

            // Startbild weich ausblenden
            startbild.Close(
                TimeSpan.FromMilliseconds(500));
        }
    }
}