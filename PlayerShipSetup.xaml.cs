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
using System.Windows.Shapes;

namespace SchiffeVersenken
{
    /// <summary>
    /// Interaction logic for PlayerShipSetup.xaml
    /// </summary>
    public partial class PlayerShipSetup : Window
    {
        Options gameOptions = new Options();

        int[,] field1Own;
        Button[,] buttons1Own;

        int selectX, selectY, selectDir;

        int setCarrier = 0, setBattleship = 0, setCruiser = 0, setSubmarine = 0, setDestroyer = 0;


        public PlayerShipSetup(Options options)
        {
            InitializeComponent();

            field1Own = SetupField();

            gameOptions = options;

            buttons1Own = new Button[gameOptions.fieldSize, gameOptions.fieldSize];


            for (int i = 0; i < gameOptions.fieldSize; i++)
            {

                for (int j = 0; j < gameOptions.fieldSize; j++)
                {


                    buttons1Own[i, j] = new Button()
                    {
                        Name = "BTN_PO_" + i + j,
                        Content = gameOptions.charWater,
                        VerticalAlignment = VerticalAlignment.Top,
                        HorizontalAlignment = HorizontalAlignment.Left,
                        Margin = new Thickness(20 + 26 * i, 10 + 26 * j, 0, 0),
                        Width = 25,
                        Height = 25,
                        BorderThickness = new Thickness(1, 1, 1, 1),
                        Visibility = Visibility.Visible,
                        Tag = i * gameOptions.fieldSize + j,
                    };
                    buttons1Own[i, j].Click += new RoutedEventHandler(Select);
                    Grid.Children.Add(buttons1Own[i, j]);
                }
            }

            Width = 60 + 26 * gameOptions.fieldSize;
            Height = 250 + 26 * gameOptions.fieldSize;
            ResizeMode = ResizeMode.CanMinimize;




        }

        private int[,] SetupField()
        {
            int[,] field = new int[gameOptions.fieldSize, gameOptions.fieldSize];
            for (int i = 0; i < gameOptions.fieldSize; i++)
            {
                for (int j = 0; j < gameOptions.fieldSize; j++)
                {
                    field[i, j] = 0;
                }
            }

            return field;
        }



        private void MainMenue_Click(object sender, RoutedEventArgs e)
        {
            var mainMenue = new MainWindow();
            mainMenue.Show();
            this.Close();
        }

        private void Select(object sender, RoutedEventArgs e)
        {
            selectX = Convert.ToInt32((sender as Button).Tag) / gameOptions.fieldSize;
            selectY = Convert.ToInt32((sender as Button).Tag) - (selectX * gameOptions.fieldSize);

        }

        private void PlayerSetupShips()
        {
            int coorX = selectX;
            int coorY = selectY;
            int direc = selectDir;
            int size;

            if (setCarrier < gameOptions.countCarrier)
            {
                size = gameOptions.sizeCarrier;

                if (ValidTile(coorX, coorY, direc, field1Own, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setCarrier++;
                }
            }

            else if (setBattleship < gameOptions.countBattleship)
            {
                size = gameOptions.sizeBattleship;

                if (ValidTile(coorX, coorY, direc, field1Own, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setBattleship++;
                }
            }

            else if (setCruiser < gameOptions.countCruiser)
            {
                size = gameOptions.sizeCruiser;

                if (ValidTile(coorX, coorY, direc, field1Own, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setCruiser++;
                }
            }

            else if (setSubmarine < gameOptions.countSubmarine)
            {
                size = gameOptions.sizeSubmarine;

                if (ValidTile(coorX, coorY, direc, field1Own, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setSubmarine++;
                }
            }

            else if (setDestroyer < gameOptions.countDestroyer)
            {
                size = gameOptions.sizeDestroyer;

                if (ValidTile(coorX, coorY, direc, field1Own, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field1Own[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field1Own[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setDestroyer++;
                }
            }
            if (setDestroyer == gameOptions.countDestroyer)
            {
                var Game = new GameWindow(gameOptions, field1Own);
                Game.Show();
                this.Close();
            }
            UpdateButtons();

        }

        private bool ValidTile(int coorX, int coorY, int direc, int[,] field, int shipSize)
        {
            bool valid = true;

            if (field[coorX, coorY] != 0) valid = false;
            else
            {
                if (direc == 0)
                {
                    if (coorX + shipSize > gameOptions.fieldSize) valid = false;
                    else for (int i = (coorX - 1 <= 0 ? 0 : coorX - 1); i <= (coorX + shipSize < gameOptions.fieldSize ? coorX + shipSize : gameOptions.fieldSize - 1); i++)
                        {
                            for (int j = (coorY - 1 <= 0 ? 0 : coorY - 1); j <= (coorY + 1 < gameOptions.fieldSize ? coorY + 1 : gameOptions.fieldSize - 1); j++)
                            {
                                if (field[i, j] != 0) valid = false;
                            }
                        }
                }
                else if (direc == 1)
                {
                    if (coorY + shipSize > gameOptions.fieldSize) valid = false;
                    else for (int i = (coorX - 1 <= 0 ? 0 : coorX - 1); i <= (coorX + 1 < gameOptions.fieldSize ? coorX + 1 : gameOptions.fieldSize - 1); i++)
                        {
                            for (int j = (coorY - 1 <= 0 ? 0 : coorY - 1); j <= (coorY + shipSize < gameOptions.fieldSize ? coorY + shipSize : gameOptions.fieldSize - 1); j++)
                            {
                                if (field[i, j] != 0) valid = false;
                            }
                        }
                }
                else if (direc == 2)
                {
                    if (coorX - shipSize < -1) valid = false;
                    else for (int i = (coorX - shipSize <= 0 ? 0 : coorX - shipSize); i <= (coorX + 1 < gameOptions.fieldSize ? coorX + 1 : gameOptions.fieldSize - 1); i++)
                        {
                            for (int j = (coorY - 1 < 0 ? 0 : coorY - 1); j <= (coorY + 1 < gameOptions.fieldSize ? coorY + 1 : gameOptions.fieldSize - 1); j++)
                            {
                                if (field[i, j] != 0) valid = false;
                            }
                        }
                }
                else if (direc == 3)
                {
                    if (coorY - shipSize < -1) valid = false;
                    else for (int i = (coorX - 1 < 0 ? 0 : coorX - 1); i <= (coorX + 1 < gameOptions.fieldSize ? coorX + 1 : gameOptions.fieldSize - 1); i++)
                        {
                            for (int j = (coorY - shipSize < 0 ? 0 : coorY - shipSize); j <= (coorY + 1 < gameOptions.fieldSize ? coorY + 1 : gameOptions.fieldSize - 1); j++)
                            {
                                if (field[i, j] != 0) valid = false;
                            }
                        }
                }
                else valid = false;
            }


            return valid;
        }

        private void UpdateButtons()
        {
            for (int i = 0; i < gameOptions.fieldSize; i++)
            {
                for (int j = 0; j < gameOptions.fieldSize; j++)
                {
                    buttons1Own[i, j].Content = Tile(field1Own[i, j]);
                }
            }
        }

        private string Tile(int id)
        {
            switch (id)
            {
                case 0:
                    return gameOptions.charWater;
                case 1:
                    return gameOptions.charMiss;
                case 2:
                    return gameOptions.charShip;
                case 3:
                    return gameOptions.charHit;
                default:
                    return "";
            }
        }


        private void BTN_Up_Click(object sender, RoutedEventArgs e)
        {
            selectDir = 3;
            PlayerSetupShips();
        }

        private void BTN_Down_Click(object sender, RoutedEventArgs e)
        {
            selectDir = 1;
            PlayerSetupShips();
        }

        private void BTN_Left_Click(object sender, RoutedEventArgs e)
        {
            selectDir = 2;
            PlayerSetupShips();
        }

        private void BTN_Right_Click(object sender, RoutedEventArgs e)
        {
            selectDir = 0;
            PlayerSetupShips();
        }
    }
}
