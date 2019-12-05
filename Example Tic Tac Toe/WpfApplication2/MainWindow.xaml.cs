using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TicTacToc
{
    public partial class MainWindow : Window
    {
        public GameBoard MyGameBoard = new GameBoard();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = MyGameBoard;
        }

    

        

        public void Button_Click(object sender, RoutedEventArgs e)
        {//Updates UI and calls gameBoard update
            var clickedButton = sender as Button;

            if (MyGameBoard.currentPlayer == GameBoard.CurrentPlayer.X)
            {
                clickedButton.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#811717"));
            }
            else if (MyGameBoard.currentPlayer == GameBoard.CurrentPlayer.O)
            {
                clickedButton.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#126712"));
            }
            clickedButton.Background = Brushes.FloralWhite;
            clickedButton.Content = MyGameBoard.currentPlayer;
            clickedButton.IsHitTestVisible = false;

            MyGameBoard.UpdateBoard(clickedButton.Name);
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {//Restarts Game
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(MyGrid) - 1; i++) // This loop iterates through all the buttons/tiles in the grid and sets changed properties to default
            {
                var child = VisualTreeHelper.GetChild(MyGrid, i) as Button;
                child.Content = null;
                child.IsHitTestVisible = true;
                child.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD"));
            }
            MyGameBoard = new GameBoard();
            this.DataContext = MyGameBoard;
        }
    }

    public class GameBoard : INotifyPropertyChanged
    {
        //Variables to be used
        public enum CurrentPlayer
        {
            X = 1,
            O
        }

        private int turn = 1;
        public CurrentPlayer currentPlayer = CurrentPlayer.X;
        private bool hasWon = false;
        public bool HasWon
        {
            get { return hasWon; }
            set { hasWon = value; NotifyPropertyChanged("HasWon"); }
        }

        private Dictionary<string, int> board = new Dictionary<string, int>()
            {
                {"TopXLeft",0 },
                {"TopXMiddle",0 },
                {"TopXRight",0 },
                {"CenterXLeft",0 },
                {"CenterXMiddle",0 },
                {"CenterXRight",0 },
                {"BottomXLeft",0 },
                {"BottomXMiddle",0 },
                {"BottomXRight",0 }
            };

        public void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private bool CheckIfWon(string buttonName)
        {//Calls all methods that check if a game has been won
            if (WonInRow(buttonName))
            {
                return true;
            }
            else if (WonInColumn(buttonName))
            {
                return true;
            }
            else if (WonInDiagonal(buttonName))
            {
                return true;
            }
            else
                return false;
        }

        private bool WonInRow(string name)
        {//Checks to see if a player has just won through having three pieces in the tile's row
            string row = name.Substring(0, name.IndexOf('X') - 1);

            foreach (var element in board)
            {
                string keyName = element.Key;
                string rowOfElement = keyName.Substring(0, keyName.IndexOf('X') - 1);

                if (rowOfElement == row)
                {
                    if (element.Value != (int)currentPlayer)
                        return false;
                }
            }

            return true;
        }

        private bool WonInColumn(string name)
        {//Checks to see if player has jsut won thorugh having three pieces in the tile's column
            string column = name.Substring(name.IndexOf('X') + 1);

            foreach (var element in board)
            {
                string keyName = element.Key;
                string columnOfElement = keyName.Substring(keyName.IndexOf('X') + 1);

                if (columnOfElement == column)
                {
                    if (element.Value != (int)currentPlayer)
                        return false;
                }
            }

            return true;
        }

        private bool WonInDiagonal(string name)
        {//Checks to see if player has just won by having three pieces diagonally
            if (name == "TopXLeft" || name == "CenterXMiddle" || name == "BottomXRight")
            {
                if (board["CenterXMiddle"] == (int)currentPlayer && board["BottomXRight"] == (int)currentPlayer && board["TopXLeft"] == (int)currentPlayer)
                {
                    return true;
                }
                else
                    return false;
            }
            if (name == "TopXRight" || name == "CenterXMiddle" || name == "BottomXLeft")
            {
                if (board["CenterXMiddle"] == (int)currentPlayer && board["BottomXLeft"] == (int)currentPlayer && board["TopXRight"] == (int)currentPlayer)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        private void UpdateDictionary(string buttonName)
        {//Update the dictionary by changing the value of the selected tile(key) to the players value
            string tileName = buttonName;

            board[tileName] = (int)currentPlayer;
        }

        public void UpdateBoard(string buttonName)
        {//Handles logic of game by updating board and checking win conditions, called on tile click
            UpdateDictionary(buttonName);

            if (turn >= 5)//Earliest turn a player can win
            {
                if (CheckIfWon(buttonName))
                {
                    HasWon = true;
                }
            }

            turn++;

            if (currentPlayer == CurrentPlayer.X)
                currentPlayer = CurrentPlayer.O;

            else if (currentPlayer == CurrentPlayer.O)
                currentPlayer = CurrentPlayer.X;
        }
    }
}