using ClubArcada.Common.BusinessObjects.DataClasses;
using System.Windows;

namespace ClubArcada.PokerTimer.Win
{
    public partial class App : Application
    {
        public Tournament Tournament { get; set; }

        public TournamentCashout TournamentCashout { get; set; }

        public User User { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var loginWindow = new Dialogs.LoginDlg();
            loginWindow.Show();
        }
    }
}
