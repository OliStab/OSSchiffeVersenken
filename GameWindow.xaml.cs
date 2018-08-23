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
    /// Interaktionslogik für GameWindow.xaml
    /// </summary>
    /// 
    public partial class GameWindow : Window
    {
        Options gameOptions = new Options();
        Random rng = new Random();
        int turn;


        int[,] field1Own;
        int[,] field1Enemy;
        int[,] field2Own;
        int[,] field2Enemy;
        Button[,] buttons1Own;
        Button[,] buttons1Enemy;
        Button[,] buttons2Own;
        Button[,] buttons2Enemy;


        int ships1Left, ships2Left;


        public GameWindow(Options options, int[,] playerField)
        {
            InitializeComponent();

            gameOptions = options;

            field1Own = new int[gameOptions.fieldSize, gameOptions.fieldSize];
            field1Enemy = new int[gameOptions.fieldSize, gameOptions.fieldSize];
            field2Own = new int[gameOptions.fieldSize, gameOptions.fieldSize];
            field2Enemy = new int[gameOptions.fieldSize, gameOptions.fieldSize];
            buttons1Own = new Button[gameOptions.fieldSize, gameOptions.fieldSize];
            buttons1Enemy = new Button[gameOptions.fieldSize, gameOptions.fieldSize];
            buttons2Own = new Button[gameOptions.fieldSize, gameOptions.fieldSize];
            buttons2Enemy = new Button[gameOptions.fieldSize, gameOptions.fieldSize];

            turn = rng.Next(0, 2);

            ships1Left = gameOptions.totalShips;
            ships2Left = gameOptions.totalShips;





            switch (gameOptions.gameMode)
            {
                case 1:

                    for (int i = 0; i < gameOptions.fieldSize; i++)
                    {
                        for (int j = 0; j < gameOptions.fieldSize; j++)
                        {
                            buttons1Enemy[i, j] = new Button()
                            {
                                Name = "BTN_PE_" + i + j,
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
                            buttons1Enemy[i, j].Click += new RoutedEventHandler(Shoot);
                            Grid.Children.Add(buttons1Enemy[i, j]);

                            buttons1Own[i, j] = new Button()
                            {
                                Name = "BTN_PO_" + i + j,
                                Content = gameOptions.charWater,
                                VerticalAlignment = VerticalAlignment.Bottom,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Margin = new Thickness(20 + 26 * i, 0, 0, (60 + 26 * gameOptions.fieldSize) - 26 * j),
                                Width = 25,
                                Height = 25,
                                BorderThickness = new Thickness(1, 1, 1, 1),
                                Visibility = Visibility.Visible,
                            };
                            Grid.Children.Add(buttons1Own[i, j]);
                        }
                    }

                    Label message = new Label()
                    {

                    };

                    Width = 55 + 26 * gameOptions.fieldSize;
                    Height = 150 + 26 * 2 * gameOptions.fieldSize;
                    ResizeMode = ResizeMode.CanMinimize;


                    field1Enemy = SetupField();
                    field2Enemy = SetupField();
                    field1Own = playerField;
                    field2Own = SetupShips();

                    UpdateButtons1();



                    break;
                case 2:

                    for (int i = 0; i < gameOptions.fieldSize; i++)
                    {
                        for (int j = 0; j < gameOptions.fieldSize; j++)
                        {
                            buttons1Own[i, j] = new Button()
                            {
                                Name = "B1O_" + i + "_" + j,
                                VerticalAlignment = VerticalAlignment.Bottom,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Margin = new Thickness(10 + 26 * i, 0, 0, (60 + 26 * (gameOptions.fieldSize - 1)) - 26 * j),
                                Width = 25,
                                Height = 25,
                                BorderThickness = new Thickness(1, 1, 1, 1),
                                Visibility = Visibility.Visible,
                            };
                            Grid.Children.Add(buttons1Own[i, j]);

                            buttons2Own[i, j] = new Button()
                            {
                                Name = "B2O_" + i + "_" + j,
                                VerticalAlignment = VerticalAlignment.Bottom,
                                HorizontalAlignment = HorizontalAlignment.Right,
                                Margin = new Thickness(0, 0, (10 + 26 * (gameOptions.fieldSize - 1)) - 26 * i, (60 + 26 * (gameOptions.fieldSize - 1)) - 26 * j),
                                Width = 25,
                                Height = 25,
                                BorderThickness = new Thickness(1, 1, 1, 1),
                                Visibility = Visibility.Visible,
                            };
                            Grid.Children.Add(buttons2Own[i, j]);

                        }
                    }

                    Button nextTurn = new Button()
                    {
                        Name = "B_Next",
                        Content = "Next",
                        VerticalAlignment = VerticalAlignment.Bottom,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        Margin = new Thickness(0, 0, 0, 15),
                        Width = 60,
                        Height = 30,
                    };
                    nextTurn.Click += new RoutedEventHandler(Shoot);
                    Grid.Children.Add(nextTurn);

                    Width = 50 + 26 * 2 * gameOptions.fieldSize;
                    Height = 100 + 26 * gameOptions.fieldSize;
                    ResizeMode = ResizeMode.CanMinimize;


                    field1Enemy = SetupField();
                    field2Enemy = SetupField();
                    field1Own = SetupShips();
                    field2Own = SetupShips();

                    UpdateButtons2();

                    break;
                default:
                    break;
            }
            if (turn % 2 == 1) P2Shoot(0, 0);

        }

        private void UpdateButtons1()
        {
            for (int i = 0; i < gameOptions.fieldSize; i++)
            {
                for (int j = 0; j < gameOptions.fieldSize; j++)
                {
                    buttons1Enemy[i, j].Content = Tile(field1Enemy[i, j]);
                    buttons1Own[i, j].Content = Tile(field1Own[i, j]);
                }
            }
        }

        private void UpdateButtons2()
        {
            for (int i = 0; i < gameOptions.fieldSize; i++)
            {
                for (int j = 0; j < gameOptions.fieldSize; j++)
                {
                    buttons1Own[i, j].Content = Tile(field1Own[i, j]);
                    buttons2Own[i, j].Content = Tile(field2Own[i, j]);
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

        private int[,] SetupShips()
        {
            int[,] field = new int[gameOptions.fieldSize, gameOptions.fieldSize];

            int coorX, coorY, direc;
            int setCarrier = 0, setBattleship = 0, setCruiser = 0, setSubmarine = 0, setDestroyer = 0;
            int size;
            int tries = 0;

            while (setCarrier < gameOptions.countCarrier)
            {
                coorX = rng.Next(0, gameOptions.fieldSize);
                coorY = rng.Next(0, gameOptions.fieldSize);
                direc = rng.Next(0, 4);
                size = gameOptions.sizeCarrier;

                if (ValidTile(coorX, coorY, direc, field, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setCarrier++;
                }
                tries++;
                if (tries >= 100000) break;
            }

            while (setBattleship < gameOptions.countBattleship)
            {
                coorX = rng.Next(0, gameOptions.fieldSize);
                coorY = rng.Next(0, gameOptions.fieldSize);
                direc = rng.Next(0, 4);
                size = gameOptions.sizeBattleship;

                if (ValidTile(coorX, coorY, direc, field, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setBattleship++;
                }
                tries++;
                if (tries >= 100000) break;
            }

            while (setCruiser < gameOptions.countCruiser)
            {
                coorX = rng.Next(0, gameOptions.fieldSize);
                coorY = rng.Next(0, gameOptions.fieldSize);
                direc = rng.Next(0, 4);
                size = gameOptions.sizeCruiser;

                if (ValidTile(coorX, coorY, direc, field, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setCruiser++;
                }
                tries++;
                if (tries >= 100000) break;
            }

            while (setSubmarine < gameOptions.countSubmarine)
            {
                coorX = rng.Next(0, gameOptions.fieldSize);
                coorY = rng.Next(0, gameOptions.fieldSize);
                direc = rng.Next(0, 4);
                size = gameOptions.sizeSubmarine;

                if (ValidTile(coorX, coorY, direc, field, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setSubmarine++;
                }
                tries++;
                if (tries >= 100000) break;
            }

            while (setDestroyer < gameOptions.countDestroyer)
            {
                coorX = rng.Next(0, gameOptions.fieldSize);
                coorY = rng.Next(0, gameOptions.fieldSize);
                direc = rng.Next(0, 4);
                size = gameOptions.sizeDestroyer;

                if (ValidTile(coorX, coorY, direc, field, size) == true)
                {

                    switch (direc)
                    {
                        case 0:
                            for (int i = coorX; i < coorX + size; i++)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 1:
                            for (int i = coorY; i < coorY + size; i++)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        case 2:
                            for (int i = coorX; i > coorX - size; i--)
                            {
                                field[i, coorY] = 2;
                            }
                            break;
                        case 3:
                            for (int i = coorY; i > coorY - size; i--)
                            {
                                field[coorX, i] = 2;
                            }
                            break;
                        default:
                            break;
                    }
                    setDestroyer++;
                }
                tries++;
                if (tries >= 100000) break;
            }

            if (tries >= 100000) AbortLoop();

            return field;
        }

        private void AbortLoop()
        {
            MessageBox.Show("Der Computer konnte nicht alle Schiffe setzen.\nBitte ein größeres Feld oder weniger Schiffe Auswächlen");

            //var mainMenue = new MainWindow();
            //mainMenue.Show();
            //this.Close();

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

        private void Shoot(object sender, RoutedEventArgs e)
        {
            int x = 0;
            int y = 0;

            if ((sender as Button).Tag != null)
            {
                x = Convert.ToInt32((sender as Button).Tag) / gameOptions.fieldSize;
                y = Convert.ToInt32((sender as Button).Tag) - (x * gameOptions.fieldSize);
            }

            if (turn % 2 == 0) P1Shoot(x, y);
            //else P2Shoot(x, y);

        }

        private void P1Shoot(int targetX, int targetY)
        {
            if (gameOptions.gameMode == 2)
            {
                do
                {
                    targetX = rng.Next(0, gameOptions.fieldSize);
                    targetY = rng.Next(0, gameOptions.fieldSize);
                } while (field1Enemy[targetX, targetY] != 0);
            }
            switch (field2Own[targetX, targetY])
            {
                case 0:
                    field1Enemy[targetX, targetY] = 1;
                    field2Own[targetX, targetY] = 1;
                    turn++;
                    P2Shoot(0, 0);
                    break;
                case 2:
                    field1Enemy[targetX, targetY] = 3;
                    field2Own[targetX, targetY] = 3;
                    ships2Left--;
                    break;
                default:
                    break;
            }

            if (gameOptions.gameMode == 1) UpdateButtons1();
            else UpdateButtons2();
            if (gameOptions.gameMode == 1) buttons1Enemy[targetX, targetY].IsEnabled = false;

            GameOver();
        }

        private void P2Shoot(int targetX, int targetY)
        {
            do
            {
                do
                {
                    targetX = rng.Next(0, gameOptions.fieldSize);
                    targetY = rng.Next(0, gameOptions.fieldSize);
                } while (field2Enemy[targetX, targetY] != 0);

                switch (field1Own[targetX, targetY])
                {
                    case 0:
                        field2Enemy[targetX, targetY] = 1;
                        field1Own[targetX, targetY] = 1;
                        turn++;
                        break;
                    case 2:
                        field2Enemy[targetX, targetY] = 3;
                        field1Own[targetX, targetY] = 3;
                        ships1Left--;
                        break;
                    default:
                        break;
                }
                GameOver();
            } while (field1Own[targetX, targetY] != 1);
            if (gameOptions.gameMode == 1) UpdateButtons1();
            else UpdateButtons2();
        }




        private void GameOver()
        {
            if (ships2Left == 0)
            {
                if (gameOptions.gameMode == 1) MessageBox.Show("Player has won!");
                else MessageBox.Show("CPU Player 1 has won!");

                var mainMenue = new MainWindow();
                mainMenue.Show();
                this.Close();

            }
            else if (ships1Left == 0)
            {
                if (gameOptions.gameMode == 1) MessageBox.Show("CPU has won!");
                else MessageBox.Show("CPU Player 2 has won!");

                var mainMenue = new MainWindow();
                mainMenue.Show();
                this.Close();

            }
        }
    }
}
