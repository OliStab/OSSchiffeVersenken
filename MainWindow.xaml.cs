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

namespace SchiffeVersenken
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Options options = new Options();
        int[,] field;

        public MainWindow()
        {
            InitializeComponent();

            TXTFieldSize.Text = Convert.ToString(options.fieldSize);
            TXTCarrierSize.Text = Convert.ToString(options.sizeCarrier);
            TXTCarrierCount.Text = Convert.ToString(options.countCarrier);
            TXTBattleshipSize.Text = Convert.ToString(options.sizeBattleship);
            TXTBattleshipCount.Text = Convert.ToString(options.countBattleship);
            TXTCruiserSize.Text = Convert.ToString(options.sizeCruiser);
            TXTCruiserCount.Text = Convert.ToString(options.countCruiser);
            TXTSubmarineSize.Text = Convert.ToString(options.sizeSubmarine);
            TXTSubmarineCount.Text = Convert.ToString(options.countSubmarine);
            TXTDestroyerSize.Text = Convert.ToString(options.sizeDestroyer);
            TXTDestroyerCount.Text = Convert.ToString(options.countDestroyer);
            options.totalShips = options.countCarrier * options.sizeCarrier + options.countBattleship * options.sizeBattleship + options.countCruiser * options.sizeCruiser + options.countSubmarine * options.sizeSubmarine + options.countDestroyer * options.sizeDestroyer;

        }

        private void BTNPvC_Click(object sender, RoutedEventArgs e)
        {
            options.fieldSize = Convert.ToInt32(TXTFieldSize.Text);
            options.sizeCarrier = Convert.ToInt32(TXTCarrierSize.Text);
            options.countCarrier = Convert.ToInt32(TXTCarrierCount.Text);
            options.sizeBattleship = Convert.ToInt32(TXTBattleshipSize.Text);
            options.countBattleship = Convert.ToInt32(TXTBattleshipCount.Text);
            options.sizeCruiser = Convert.ToInt32(TXTCruiserSize.Text);
            options.countCruiser = Convert.ToInt32(TXTCruiserCount.Text);
            options.sizeSubmarine = Convert.ToInt32(TXTSubmarineSize.Text);
            options.countSubmarine = Convert.ToInt32(TXTSubmarineCount.Text);
            options.sizeDestroyer = Convert.ToInt32(TXTDestroyerSize.Text);
            options.countDestroyer = Convert.ToInt32(TXTDestroyerCount.Text);
            options.totalShips = options.countCarrier * options.sizeCarrier + options.countBattleship * options.sizeBattleship + options.countCruiser * options.sizeCruiser + options.countSubmarine * options.sizeSubmarine + options.countDestroyer * options.sizeDestroyer;
            options.gameMode = 1;
            var Game = new PlayerShipSetup(options);
            Game.Show();
            this.Close();
        }

        private void BTNCvC_Click(object sender, RoutedEventArgs e)
        {
            options.fieldSize = Convert.ToInt32(TXTFieldSize.Text);
            options.sizeCarrier = Convert.ToInt32(TXTCarrierSize.Text);
            options.countCarrier = Convert.ToInt32(TXTCarrierCount.Text);
            options.sizeBattleship = Convert.ToInt32(TXTBattleshipSize.Text);
            options.countBattleship = Convert.ToInt32(TXTBattleshipCount.Text);
            options.sizeCruiser = Convert.ToInt32(TXTCruiserSize.Text);
            options.countCruiser = Convert.ToInt32(TXTCruiserCount.Text);
            options.sizeSubmarine = Convert.ToInt32(TXTSubmarineSize.Text);
            options.countSubmarine = Convert.ToInt32(TXTSubmarineCount.Text);
            options.sizeDestroyer = Convert.ToInt32(TXTDestroyerSize.Text);
            options.countDestroyer = Convert.ToInt32(TXTDestroyerCount.Text);
            options.totalShips = options.countCarrier * options.sizeCarrier + options.countBattleship * options.sizeBattleship + options.countCruiser * options.sizeCruiser + options.countSubmarine * options.sizeSubmarine + options.countDestroyer * options.sizeDestroyer;
            options.gameMode = 2;
            var Game = new GameWindow(options, field);
            Game.Show();
            this.Close();
        }
    }
}
