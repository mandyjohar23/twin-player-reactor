using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using System.Windows.Media;
using System.IO.IsolatedStorage;
using System.Windows.Media.Imaging;

namespace _2_Player_Reactor
{

    public partial class Page10 : PhoneApplicationPage
    {
        private IsolatedStorageSettings appsettings = IsolatedStorageSettings.ApplicationSettings;

        int[] roundsPlayed = new int[10];
        Random rd1 = new Random();
        int temp1;
        int finalCheck;
        bool b = true;

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Random rnd = new Random();
        Boolean answer;
        int temp;
        int n1 = 0, n2 = 0, navigateCheck = 0, navigateCheck2 = 0;
        //ImageBrush brush = new ImageBrush();

        public Page10()
        {
            InitializeComponent();
            score1.Foreground = new SolidColorBrush(Colors.White);
            score2.Foreground = new SolidColorBrush(Colors.White);
            l1.Foreground = new SolidColorBrush(Colors.White);
            l2.Foreground = new SolidColorBrush(Colors.White);
            textblocknew.Foreground = new SolidColorBrush(Colors.White);
            textblocknew2.Foreground = new SolidColorBrush(Colors.White);
            if (appsettings.Contains("s1"))
            {
                string sc1 = appsettings["s1"].ToString();
                score1.Text = sc1;
                n1 = Convert.ToInt32(sc1);
            }
            if (appsettings.Contains("s2"))
            {
                string sc2 = appsettings["s2"].ToString();
                score2.Text = sc2;
                n2 = Convert.ToInt32(sc2);
            }
            if (appsettings.Contains("array"))
            {
                roundsPlayed = (int[])appsettings["array"];
            }
            if (appsettings.Contains("FinalCheck"))
            {
                finalCheck = (int)appsettings["FinalCheck"];
                fcheck.Text = finalCheck.ToString();
            }
            startline1_1.Content = "Challenge " + finalCheck + " of 10!";
            startline2_1.Content = "Challenge " + finalCheck + " of 10!";

            //brush.ImageSource = new BitmapImage(new Uri("/button2.jpg", UriKind.Relative));
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_tick);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_tick(object sender, EventArgs e)
        {
            PlayButton1.IsEnabled = true;
            PlayButton2.IsEnabled = true;
            p1green.Visibility = System.Windows.Visibility.Collapsed;
            p2green.Visibility = System.Windows.Visibility.Collapsed;
            p1red.Visibility = System.Windows.Visibility.Collapsed;
            p2red.Visibility = System.Windows.Visibility.Collapsed;
            textblock1.Visibility = System.Windows.Visibility.Collapsed;
            textblock2.Visibility = System.Windows.Visibility.Collapsed;
            textblocknew.TextAlignment = TextAlignment.Center;
            textblocknew2.TextAlignment = TextAlignment.Center;
            temp = rnd.Next(20);
            switch (temp)
            {
                case 0:
                    Uri uri = new Uri("Logos/lexus.png", UriKind.Relative);
                    BitmapImage imagesource = new BitmapImage(uri);
                    imagebox1.Source = imagebox2.Source = imagesource;
                    textblocknew.Text = textblocknew2.Text = "Mercedes";
                    answer = false;
                    break;
                case 1:
                    Uri uri1 = new Uri("Logos/lexus.png", UriKind.Relative);
                    BitmapImage imagesource1 = new BitmapImage(uri1);
                    imagebox1.Source = imagebox2.Source = imagesource1;
                    textblocknew.Text = textblocknew2.Text = "Lexus";
                    answer = true;
                    break;
                case 2:
                    Uri uri2 = new Uri("Logos/Piaggio.png", UriKind.Relative);
                    BitmapImage imagesource2 = new BitmapImage(uri2);
                    imagebox1.Source = imagebox2.Source = imagesource2;
                    textblocknew.Text = textblocknew2.Text = "Volkswagen";
                    answer = false;
                    break;
                case 3:
                    Uri uri3 = new Uri("Logos/Piaggio.png", UriKind.Relative);
                    BitmapImage imagesource3 = new BitmapImage(uri3);
                    imagebox1.Source = imagebox2.Source = imagesource3;
                    textblocknew.Text = textblocknew2.Text = "Piaggio";
                    answer = true;
                    break;
                case 4:
                    Uri uri4 = new Uri("Logos/Michelin.png", UriKind.Relative);
                    BitmapImage imagesource4 = new BitmapImage(uri4);
                    imagebox1.Source = imagebox2.Source = imagesource4;
                    textblocknew.Text = textblocknew2.Text = "Michelin";
                    answer = true;
                    break;
                case 5:
                    Uri uri5 = new Uri("Logos/Michelin.png", UriKind.Relative);
                    BitmapImage imagesource5 = new BitmapImage(uri5);
                    imagebox1.Source = imagebox2.Source = imagesource5;
                    textblocknew.Text = textblocknew2.Text = "Snowday";
                    answer = false;
                    break;

                case 6:
                    Uri uri6 = new Uri("Logos/Timberland.png", UriKind.Relative);
                    BitmapImage imagesource6 = new BitmapImage(uri6);
                    imagebox1.Source = imagebox2.Source = imagesource6;
                    textblocknew.Text = textblocknew2.Text = "Timberland";
                    answer = true;
                    break;
                case 7:
                    Uri uri7 = new Uri("Logos/Timberland.png", UriKind.Relative);
                    BitmapImage imagesource7 = new BitmapImage(uri7);
                    imagebox1.Source = imagebox2.Source = imagesource7;
                    textblocknew.Text = textblocknew2.Text = "Woodland";
                    answer = false;
                    break;
                case 8:
                    Uri uri8 = new Uri("Logos/Jaguar.png", UriKind.Relative);
                    BitmapImage imagesource8 = new BitmapImage(uri8);
                    imagebox1.Source = imagebox2.Source = imagesource8;
                    textblocknew.Text = textblocknew2.Text = "Jaguar";
                    answer = true;
                    break;
                case 9:
                    Uri uri9 = new Uri("Logos/Jaguar.png", UriKind.Relative);
                    BitmapImage imagesource9 = new BitmapImage(uri9);
                    imagebox1.Source = imagebox2.Source = imagesource9;
                    textblocknew.Text = textblocknew2.Text = "Puma";
                    answer = false;
                    break;
                case 10:
                    Uri uri10 = new Uri("Logos/ck.png", UriKind.Relative);
                    BitmapImage imagesource10 = new BitmapImage(uri10);
                    imagebox1.Source = imagebox2.Source = imagesource10;
                    textblocknew.Text = textblocknew2.Text = "Charles&Keith";
                    answer = false;
                    break;
                case 11:
                    Uri uri11 = new Uri("Logos/ck.png", UriKind.Relative);
                    BitmapImage imagesource11 = new BitmapImage(uri11);
                    imagebox1.Source = imagebox2.Source = imagesource11;
                    textblocknew.Text = textblocknew2.Text = "Calvin Klein";
                    answer = true;
                    break;
                case 12:
                    Uri uri12 = new Uri("Logos/who.png", UriKind.Relative);
                    BitmapImage imagesource12 = new BitmapImage(uri12);
                    imagebox1.Source = imagebox2.Source = imagesource12;
                    textblocknew.Text = textblocknew2.Text = "W.H.O";
                    answer = true;
                    break;
                case 13:
                    Uri uri13 = new Uri("Logos/who.png", UriKind.Relative);
                    BitmapImage imagesource13 = new BitmapImage(uri13);
                    imagebox1.Source = imagebox2.Source = imagesource13;
                    textblocknew.Text = textblocknew2.Text = "U.N";
                    answer = false;
                    break;
                case 14:
                    Uri uri14 = new Uri("Logos/real.png", UriKind.Relative);
                    BitmapImage imagesource14 = new BitmapImage(uri14);
                    imagebox1.Source = imagebox2.Source = imagesource14;
                    textblocknew.Text = textblocknew2.Text = "Real Madrid";
                    answer = true;
                    break;
                case 15:
                    Uri uri15 = new Uri("Logos/real.png", UriKind.Relative);
                    BitmapImage imagesource15 = new BitmapImage(uri15);
                    imagebox1.Source = imagebox2.Source = imagesource15;
                    textblocknew.Text = textblocknew2.Text = "Real Betis";
                    answer = false;
                    break;
                case 16:
                    Uri uri16 = new Uri("Logos/bolton.png", UriKind.Relative);
                    BitmapImage imagesource16 = new BitmapImage(uri16);
                    imagebox1.Source = imagebox2.Source = imagesource16;
                    textblocknew.Text = textblocknew2.Text = "Bolton";
                    answer = true;
                    break;
                case 17:
                    Uri uri17 = new Uri("Logos/bolton.png", UriKind.Relative);
                    BitmapImage imagesource17 = new BitmapImage(uri17);
                    imagebox1.Source = imagebox2.Source = imagesource17;
                    textblocknew.Text = textblocknew2.Text = "Totenham";
                    answer = false;
                    break;
                case 18:
                    Uri uri18 = new Uri("Logos/ralph.png", UriKind.Relative);
                    BitmapImage imagesource18 = new BitmapImage(uri18);
                    imagebox1.Source = imagebox2.Source = imagesource18;
                    textblocknew.Text = textblocknew2.Text = "USPA";
                    answer = false;
                    break;
                case 19:
                    Uri uri19 = new Uri("Logos/ralph.png", UriKind.Relative);
                    BitmapImage imagesource19 = new BitmapImage(uri19);
                    imagebox1.Source = imagebox2.Source = imagesource19;
                    textblocknew.Text = textblocknew2.Text = "Ralph Lauren";
                    answer = true;
                    break;
            }
        }

        private void PlayButton1_Click(object sender, RoutedEventArgs e)
        {
            if (answer == true)
            {
                dispatcherTimer.Stop();
                PlayButton1.IsEnabled = false;
                PlayButton2.IsEnabled = false;
                p1green.Visibility = System.Windows.Visibility.Visible;
                score1.Text = Convert.ToString(++n1);
                dispatcherTimer.Start();
                if (++navigateCheck == 5)
                {
                    dispatcherTimer.Stop();
                    if (finalCheck == 10)
                    {
                        store();
                        NavigationService.Navigate(new Uri("/Final.xaml", UriKind.Relative));
                    }
                    else
                    {
                        switchfn();
                    }
                }
            }
            else
            {
                dispatcherTimer.Stop();
                PlayButton1.IsEnabled = false;
                PlayButton2.IsEnabled = false;
                p1red.Visibility = System.Windows.Visibility.Visible;
                score1.Text = Convert.ToString(--n1);
                dispatcherTimer.Start();
                if (--navigateCheck2 == -3)
                {
                    dispatcherTimer.Stop();
                    if (finalCheck == 10)
                    {
                        store();
                        NavigationService.Navigate(new Uri("/Final.xaml", UriKind.Relative));
                    }
                    else
                    {
                        switchfn();
                    }
                }
            }
        }

        private void PlayButton2_Click(object sender, RoutedEventArgs e)
        {
            if (answer == true)
            {
                dispatcherTimer.Stop();
                PlayButton1.IsEnabled = false;
                PlayButton2.IsEnabled = false;
                p2green.Visibility = System.Windows.Visibility.Visible;
                score2.Text = Convert.ToString(++n2);
                dispatcherTimer.Start();
                if (++navigateCheck == 5)
                {
                    dispatcherTimer.Stop();
                    if (finalCheck == 10)
                    {
                        store();
                        NavigationService.Navigate(new Uri("/Final.xaml", UriKind.Relative));
                    }
                    else
                    {
                        switchfn();
                    }
                }
            }
            else
            {
                dispatcherTimer.Stop();
                PlayButton1.IsEnabled = false;
                PlayButton2.IsEnabled = false;
                p2red.Visibility = System.Windows.Visibility.Visible;
                score2.Text = Convert.ToString(--n2);
                dispatcherTimer.Start();
                if (--navigateCheck2 == -3)
                {
                    dispatcherTimer.Stop();
                    if (finalCheck == 10)
                    {
                        store();
                        NavigationService.Navigate(new Uri("/Final.xaml", UriKind.Relative));
                    }
                    else
                    {
                        switchfn();
                    }
                }
            }
        }

        private void switchfn()
        {
            while (b == true)
            {
                temp1 = rd1.Next(10);
                switch (temp1)
                {
                    case 0:
                        if (roundsPlayed[0] == 0)
                        {
                            roundsPlayed[0] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/Alphabets.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                    case 1:
                        if (roundsPlayed[1] == 0)
                        {
                            roundsPlayed[1] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/Area.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                    case 2:
                        if (roundsPlayed[2] == 0)
                        {
                            roundsPlayed[2] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/Capital.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                    case 3:
                        if (roundsPlayed[3] == 0)
                        {
                            roundsPlayed[3] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/ColorNames.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                    case 4:
                        if (roundsPlayed[4] == 0)
                        {
                            roundsPlayed[4] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/Equations.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                    case 5:
                        if (roundsPlayed[5] == 0)
                        {
                            roundsPlayed[5] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/MouseCheese.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                    case 6:
                        if (roundsPlayed[6] == 0)
                        {
                            roundsPlayed[6] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/Population.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                    case 7:
                        if (roundsPlayed[7] == 0)
                        {
                            roundsPlayed[7] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/White.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                    case 8:
                        if (roundsPlayed[8] == 0)
                        {
                            roundsPlayed[8] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/Logos.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                    case 9:
                        if (roundsPlayed[9] == 0)
                        {
                            roundsPlayed[9] = 1;
                            store();
                            NavigationService.Navigate(new Uri("/SadSmiley.xaml", UriKind.Relative));
                            b = false;
                        }
                        break;
                }
                if (finalCheck == 10)
                {
                    b = false;
                }
            }
        }

        private void store()
        {
            if (appsettings.Contains("s1"))
            {
                appsettings.Remove("s1");
                appsettings.Add("s1", score1.Text);
            }
            else
            {
                appsettings.Add("s1", score1.Text);
            }
            if (appsettings.Contains("s2"))
            {
                appsettings.Remove("s2");
                appsettings.Add("s2", score2.Text);
            }
            else
            {
                appsettings.Add("s2", score2.Text);
            }
            if (appsettings.Contains("array"))
            {
                appsettings.Remove("array");
                appsettings.Add("array", roundsPlayed);
            }
            else
            {
                appsettings.Add("array", roundsPlayed);
            }
            if (appsettings.Contains("FinalCheck"))
            {
                appsettings.Remove("FinalCheck");
                appsettings.Add("FinalCheck", ++finalCheck);
            }
            else
            {
                appsettings.Add("FinalCheck", ++finalCheck);
            }
        }

        private void startline2_1_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard1.Begin();
        }


    }
}