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

    public partial class Page4 : PhoneApplicationPage
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

        public Page4()
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
            temp = rnd.Next(10);
            switch (temp)
            {
                case 0:
                    textblock1.Text = textblock2.Text = "china > usa";
                    textblock1.Foreground = new SolidColorBrush(Colors.Red);
                    textblock2.Foreground = new SolidColorBrush(Colors.Red);
                    answer = true;
                    break;
                case 1:
                    textblock1.Text = textblock2.Text = "iran > india ";
                    textblock1.Foreground = new SolidColorBrush(Colors.Red);
                    textblock2.Foreground = new SolidColorBrush(Colors.Red);
                    answer = false;
                    break;
                case 2:
                    textblock1.Text = textblock2.Text = "spain > italy";
                    textblock1.Foreground = new SolidColorBrush(Colors.Cyan);
                    textblock2.Foreground = new SolidColorBrush(Colors.Cyan);
                    answer = false;
                    break;
                case 3:
                    textblock1.Text = textblock2.Text = "peru > iraq";
                    textblock1.Foreground = new SolidColorBrush(Colors.Yellow);
                    textblock2.Foreground = new SolidColorBrush(Colors.Yellow);
                    answer = false;
                    break;
                case 4:
                    textblock1.Text = textblock2.Text = "brazil > japan";
                    textblock1.Foreground = new SolidColorBrush(Colors.Yellow);
                    textblock2.Foreground = new SolidColorBrush(Colors.Yellow);
                    answer = true;
                    break;
                case 5:
                    textblock1.Text = textblock2.Text = "egypt > sydney";
                    textblock1.Foreground = new SolidColorBrush(Colors.Cyan);
                    textblock2.Foreground = new SolidColorBrush(Colors.Cyan);
                    answer = true;
                    break;
                case 6:
                    textblock1.Text = textblock2.Text = "sudan > delhi";
                    textblock1.Foreground = new SolidColorBrush(Colors.Orange);
                    textblock2.Foreground = new SolidColorBrush(Colors.Orange);
                    answer = true;
                    break;
                case 7:
                    textblock1.Text = textblock2.Text = "texas > sri lanka";
                    textblock1.Foreground = new SolidColorBrush(Colors.Orange);
                    textblock2.Foreground = new SolidColorBrush(Colors.Orange);
                    answer = false;
                    break;
                case 8:
                    textblock1.Text = textblock2.Text = "syria > cuba";
                    textblock1.Foreground = new SolidColorBrush(Colors.Magenta);
                    textblock2.Foreground = new SolidColorBrush(Colors.Magenta);
                    answer = true;
                    break;
                case 9:
                    textblock1.Text = textblock2.Text = "turkey > russia";
                    textblock1.Foreground = new SolidColorBrush(Colors.Magenta);
                    textblock2.Foreground = new SolidColorBrush(Colors.Magenta);
                    answer = false;
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