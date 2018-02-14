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

    public partial class Page11 : PhoneApplicationPage
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

        public Page11()
        {
            InitializeComponent();
            score1.Foreground = new SolidColorBrush(Colors.White);
            score2.Foreground = new SolidColorBrush(Colors.White);
            l1.Foreground = new SolidColorBrush(Colors.White);
            l2.Foreground = new SolidColorBrush(Colors.White);
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

            temp = rnd.Next(49);

            switch (temp)
            {
                case 0:
                    Uri uri = new Uri("smile/smile.png", UriKind.Relative);
                    BitmapImage imagesource = new BitmapImage(uri);
                    imagebox.Source = imagesource;

                    answer = false;
                    break;
                case 1:
                    Uri uri1 = new Uri("smile/smile2.png", UriKind.Relative);
                    BitmapImage imagesource1 = new BitmapImage(uri1);
                    imagebox.Source = imagesource1;

                    answer = true;
                    break;
                case 2:
                    Uri uri2 = new Uri("smile/smile3.png", UriKind.Relative);
                    BitmapImage imagesource2 = new BitmapImage(uri2);
                    imagebox.Source = imagesource2;

                    answer = true;
                    break;
                case 3:
                    Uri uri3 = new Uri("smile/smile4.png", UriKind.Relative);
                    BitmapImage imagesource3 = new BitmapImage(uri3);
                    imagebox.Source = imagesource3;

                    answer = false;
                    break;
                case 4:
                    Uri uri4 = new Uri("smile/smile5.png", UriKind.Relative);
                    BitmapImage imagesource4 = new BitmapImage(uri4);
                    imagebox.Source = imagesource4;

                    answer = false;
                    break;
                case 5:
                    Uri uri5 = new Uri("smile/smile6.png", UriKind.Relative);
                    BitmapImage imagesource5 = new BitmapImage(uri5);
                    imagebox.Source = imagesource5;

                    answer = false;
                    break;

                case 6:
                    Uri uri6 = new Uri("smile/smile7.png", UriKind.Relative);
                    BitmapImage imagesource6 = new BitmapImage(uri6);
                    imagebox.Source = imagesource6;

                    answer = false;
                    break;
                case 7:
                    Uri uri7 = new Uri("smile/smile8.png", UriKind.Relative);
                    BitmapImage imagesource7 = new BitmapImage(uri7);
                    imagebox.Source = imagesource7;

                    answer = false;
                    break;
                case 8:
                    Uri uri8 = new Uri("smile/smile9.png", UriKind.Relative);
                    BitmapImage imagesource8 = new BitmapImage(uri8);
                    imagebox.Source = imagesource8;

                    answer = false;
                    break;
                case 9:
                    Uri uri9 = new Uri("smile/smile10.png", UriKind.Relative);
                    BitmapImage imagesource9 = new BitmapImage(uri9);
                    imagebox.Source = imagesource9;

                    answer = true;
                    break;
                case 10:
                    Uri uri10 = new Uri("smile/smile11.png", UriKind.Relative);
                    BitmapImage imagesource10 = new BitmapImage(uri10);
                    imagebox.Source = imagesource10;

                    answer = true;
                    break;
                case 11:
                    Uri uri11 = new Uri("smile/smile12.png", UriKind.Relative);
                    BitmapImage imagesource11 = new BitmapImage(uri11);
                    imagebox.Source = imagesource11;

                    answer = false;
                    break;
                case 12:
                    Uri uri12 = new Uri("smile/smile13.png", UriKind.Relative);
                    BitmapImage imagesource12 = new BitmapImage(uri12);
                    imagebox.Source = imagesource12;

                    answer = false;
                    break;
                case 13:
                    Uri uri13 = new Uri("smile/smile14.png", UriKind.Relative);
                    BitmapImage imagesource13 = new BitmapImage(uri13);
                    imagebox.Source = imagesource13;

                    answer = true;
                    break;
                case 14:
                    Uri uri14 = new Uri("smile/smile15.png", UriKind.Relative);
                    BitmapImage imagesource14 = new BitmapImage(uri14);
                    imagebox.Source = imagesource14;

                    answer = false;
                    break;
                case 15:
                    Uri uri15 = new Uri("smile/smile16.png", UriKind.Relative);
                    BitmapImage imagesource15 = new BitmapImage(uri15);
                    imagebox.Source = imagesource15;

                    answer = true;
                    break;
                case 16:
                    Uri uri16 = new Uri("smile/smile17.png", UriKind.Relative);
                    BitmapImage imagesource16 = new BitmapImage(uri16);
                    imagebox.Source = imagesource16;

                    answer = false;
                    break;
                case 17:
                    Uri uri17 = new Uri("smile/smile18.png", UriKind.Relative);
                    BitmapImage imagesource17 = new BitmapImage(uri17);
                    imagebox.Source = imagesource17;

                    answer = false;
                    break;
                case 18:
                    Uri uri18 = new Uri("smile/smile19.png", UriKind.Relative);
                    BitmapImage imagesource18 = new BitmapImage(uri18);
                    imagebox.Source = imagesource18;

                    answer = false;
                    break;
                case 19:
                    Uri uri19 = new Uri("smile/smile20.png", UriKind.Relative);
                    BitmapImage imagesource19 = new BitmapImage(uri19);
                    imagebox.Source = imagesource19;

                    answer = true;
                    break;
                case 20:
                    Uri uri20 = new Uri("smile/smile21.png", UriKind.Relative);
                    BitmapImage imagesource20 = new BitmapImage(uri20);
                    imagebox.Source = imagesource20;

                    answer = false;
                    break;
                case 21:
                    Uri uri21 = new Uri("smile/smile22.png", UriKind.Relative);
                    BitmapImage imagesource21 = new BitmapImage(uri21);
                    imagebox.Source = imagesource21;

                    answer = true;
                    break;
                case 22:
                    Uri uri22 = new Uri("smile/smile23.png", UriKind.Relative);
                    BitmapImage imagesource22 = new BitmapImage(uri22);
                    imagebox.Source = imagesource22;

                    answer = true;
                    break;
                case 23:
                    Uri uri23 = new Uri("smile/smile24.png", UriKind.Relative);
                    BitmapImage imagesource23 = new BitmapImage(uri23);
                    imagebox.Source = imagesource23;

                    answer = false;
                    break;
                case 24:
                    Uri uri24 = new Uri("smile/smile25.png", UriKind.Relative);
                    BitmapImage imagesource24 = new BitmapImage(uri24);
                    imagebox.Source = imagesource24;

                    answer = true;
                    break;
                case 25:
                    Uri uri25 = new Uri("smile/smile26.png", UriKind.Relative);
                    BitmapImage imagesource25 = new BitmapImage(uri25);
                    imagebox.Source = imagesource25;

                    answer = false;
                    break;
                case 26:
                    Uri uri26 = new Uri("smile/smile27.png", UriKind.Relative);
                    BitmapImage imagesource26 = new BitmapImage(uri26);
                    imagebox.Source = imagesource26;

                    answer = true;
                    break;
                case 27:
                    Uri uri27 = new Uri("smile/smile28.png", UriKind.Relative);
                    BitmapImage imagesource27 = new BitmapImage(uri27);
                    imagebox.Source = imagesource27;

                    answer = true;
                    break;
                case 28:
                    Uri uri28 = new Uri("smile/smile29.png", UriKind.Relative);
                    BitmapImage imagesource28 = new BitmapImage(uri28);
                    imagebox.Source = imagesource28;

                    answer = true;
                    break;
                case 29:
                    Uri uri29 = new Uri("smile/smile30.png", UriKind.Relative);
                    BitmapImage imagesource29 = new BitmapImage(uri29);
                    imagebox.Source = imagesource29;

                    answer = false;
                    break;
                case 30:
                    Uri uri30 = new Uri("smile/smile31.png", UriKind.Relative);
                    BitmapImage imagesource30 = new BitmapImage(uri30);
                    imagebox.Source = imagesource30;

                    answer = true;
                    break;
                case 31:
                    Uri uri31 = new Uri("smile/smile32.png", UriKind.Relative);
                    BitmapImage imagesource31 = new BitmapImage(uri31);
                    imagebox.Source = imagesource31;

                    answer = true;
                    break;
                case 32:
                    Uri uri32 = new Uri("smile/smile33.png", UriKind.Relative);
                    BitmapImage imagesource32 = new BitmapImage(uri32);
                    imagebox.Source = imagesource32;
                    answer = false;
                    break;
                case 33:
                    Uri uri33 = new Uri("smile/smile34.png", UriKind.Relative);
                    BitmapImage imagesource33 = new BitmapImage(uri33);
                    imagebox.Source = imagesource33;

                    answer = true;
                    break;
                case 34:
                    Uri uri34 = new Uri("smile/smile35.png", UriKind.Relative);
                    BitmapImage imagesource34 = new BitmapImage(uri34);
                    imagebox.Source = imagesource34;

                    answer = false;
                    break;
                case 35:
                    Uri uri35 = new Uri("smile/smile36.png", UriKind.Relative);
                    BitmapImage imagesource35 = new BitmapImage(uri35);
                    imagebox.Source = imagesource35;

                    answer = false;
                    break;
                case 36:
                    Uri uri36 = new Uri("smile/smile37.png", UriKind.Relative);
                    BitmapImage imagesource36 = new BitmapImage(uri36);
                    imagebox.Source = imagesource36;

                    answer = true;
                    break;
                case 37:
                    Uri uri37 = new Uri("smile/smile38.png", UriKind.Relative);
                    BitmapImage imagesource37 = new BitmapImage(uri37);
                    imagebox.Source = imagesource37;

                    answer = true;
                    break;
                case 38:
                    Uri uri38 = new Uri("smile/smile39.png", UriKind.Relative);
                    BitmapImage imagesource38 = new BitmapImage(uri38);
                    imagebox.Source = imagesource38;

                    answer = true;
                    break;
                case 39:
                    Uri uri39 = new Uri("smile/smile40.png", UriKind.Relative);
                    BitmapImage imagesource39 = new BitmapImage(uri39);
                    imagebox.Source = imagesource39;

                    answer = true;
                    break;

                case 40:
                    Uri uri40 = new Uri("smile/smile41.png", UriKind.Relative);
                    BitmapImage imagesource40 = new BitmapImage(uri40);
                    imagebox.Source = imagesource40;

                    answer = false;
                    break;
                case 41:
                    Uri uri41 = new Uri("smile/smile42.png", UriKind.Relative);
                    BitmapImage imagesource41 = new BitmapImage(uri41);
                    imagebox.Source = imagesource41;

                    answer = true;
                    break;
                case 42:
                    Uri uri42 = new Uri("smile/smile43.png", UriKind.Relative);
                    BitmapImage imagesource42 = new BitmapImage(uri42);
                    imagebox.Source = imagesource42;

                    answer = true;
                    break;
                case 43:
                    Uri uri43 = new Uri("smile/smile44.png", UriKind.Relative);
                    BitmapImage imagesource43 = new BitmapImage(uri43);
                    imagebox.Source = imagesource43;

                    answer = false;
                    break;
                case 44:
                    Uri uri44 = new Uri("smile/smile45.png", UriKind.Relative);
                    BitmapImage imagesource44 = new BitmapImage(uri44);
                    imagebox.Source = imagesource44;

                    answer = false;
                    break;
                case 45:
                    Uri uri45 = new Uri("smile/smile46.png", UriKind.Relative);
                    BitmapImage imagesource45 = new BitmapImage(uri45);
                    imagebox.Source = imagesource45;

                    answer = false;
                    break;
                case 46:
                    Uri uri46 = new Uri("smile/smile47.png", UriKind.Relative);
                    BitmapImage imagesource46 = new BitmapImage(uri46);
                    imagebox.Source = imagesource46;

                    answer = true;
                    break;
                case 47:
                    Uri uri47 = new Uri("smile/smile48.png", UriKind.Relative);
                    BitmapImage imagesource47 = new BitmapImage(uri47);
                    imagebox.Source = imagesource47;

                    answer = true;
                    break;
                case 48:
                    Uri uri48 = new Uri("smile/smile49.png", UriKind.Relative);
                    BitmapImage imagesource48 = new BitmapImage(uri48);
                    imagebox.Source = imagesource48;

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