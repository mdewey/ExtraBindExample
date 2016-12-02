using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prep_Footbal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Counter { get; set; } = 0;

        public List<Player> MyTeam { get; set; } = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();

            MyTeam.Add(new Player { Name = "Betty" , Rating= 10, Position = "QB"});

            MyTeam.Add(new Player { Name = "Sue", Rating = 7 , Position = "Center" });

            MyTeam.Add(new Player { Name = "Amanda", Rating = 4, Position = "Wing" });

            this.Roster.ItemsSource = MyTeam;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var game = button.DataContext as Player;
            MyTeam.Remove(MyTeam.First(f => f.Id == game.Id));
            this.Roster.ItemsSource = MyTeam;
            this.Roster.Items.Refresh();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var game = button.DataContext as Player;
            this.NameLabel.Content = game.Name;
            this.RatingLabel.Content = game.Rating;

        }
    }
}
