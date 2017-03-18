using System.ComponentModel;
using System.Windows;

namespace ClubArcada.PokerTimer.Win
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
        }

        
    }
}
