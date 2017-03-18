using System;
using System.Windows;

namespace ClubArcada.PokerTimer.Win.Dialogs
{
    public partial class LoginDlg : Window
    {
        public LoginDlg()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
