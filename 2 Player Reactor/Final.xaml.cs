using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Tasks;
using System.Windows.Media;

namespace _2_Player_Reactor
{
    public partial class Page9 : PhoneApplicationPage
    {
        private IsolatedStorageSettings appsettings = IsolatedStorageSettings.ApplicationSettings;
        int n1, n2;
        public Page9()
        {
            InitializeComponent();
            textblock1.Foreground = new SolidColorBrush(Colors.White);
            textblock2.Foreground = new SolidColorBrush(Colors.White);
            
            if (appsettings.Contains("s1"))
            {
                string sc1 = appsettings["s1"].ToString();                
                n1 = Convert.ToInt32(sc1);
            }
            if (appsettings.Contains("s2"))
            {
                string sc2 = appsettings["s2"].ToString();                
                n2 = Convert.ToInt32(sc2);
            }
            textblock1.Text = "Player 1 score : " + n1 + "\nPlayer 2 score : " + n2 + "\n";
            if (n1 > n2)
            {
                textblock1.Text += "\nPlayer 1 WINS!";
            }
            else if (n1 < n2)
            {
                textblock1.Text += "\nPlayer 2 WINS!";
            }
            else
            {
                textblock1.Text += "\nIt's a DRAW!";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();

            marketplaceReviewTask.Show();
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