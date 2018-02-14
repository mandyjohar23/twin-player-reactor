using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Tasks;

namespace _2_Player_Reactor
{
    public partial class MainPage : PhoneApplicationPage
    {
        private IsolatedStorageSettings appsettings = IsolatedStorageSettings.ApplicationSettings;
        Random rd1=new Random();
        int temp1;
        int[] roundsPlayed = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int finalCheck = 0;
        bool b = true;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            while (b==true)
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
            }
        }

        private void store()
        {
            if (appsettings.Contains("s1"))
            {
                appsettings.Remove("s1");
                appsettings.Add("s1", 0);
            }
            else
            {
                appsettings.Add("s1", 0);
            }
            if (appsettings.Contains("s2"))
            {
                appsettings.Remove("s2");
                appsettings.Add("s2", 0);
            }
            else
            {
                appsettings.Add("s2", 0);
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

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {

            if (MessageBox.Show("Are you Sure You want to Exit?", "Exit", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

            }
            else
            {
                e.Cancel = true;
            }


        }

      
        
    }
}