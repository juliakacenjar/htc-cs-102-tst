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
using static WpfApplication1.MainWindow;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int turn;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Game;
        }

        public object Game { get; private set; }
        public int Turn { get; private set; }

        public enum CurrentPlayer
        {
            X = 1,
            O
        }
        public void turnCounter()
        {
            {
                turn++;
            }
        }




        private void currentTurn()
        {
            if (turn == 1)
            {
                CurrentPlayer currentPlayer = CurrentPlayer.X;
            }
            else if (turn == 2)
            {
                CurrentPlayer currentPlayer = CurrentPlayer.O;
            }
            else if (turn == 3)
            {
                CurrentPlayer currentPlayer = CurrentPlayer.X;
            }
            else if (turn == 4)
            {
                CurrentPlayer currentPlayer = CurrentPlayer.O;
            }
            else if (turn == 5)
            {
                CurrentPlayer currentPlayer = CurrentPlayer.X;
            }
            else if (turn == 6)
            {
                CurrentPlayer currentPlayer = CurrentPlayer.O;
            }
            else if (turn == 7)
            {
                CurrentPlayer currentPlayer = CurrentPlayer.X;
            }
            else if (turn == 8)
            {
                CurrentPlayer currentPlayer = CurrentPlayer.O;
            }
            else if (turn == 9)
            {
                CurrentPlayer currentPlayer = CurrentPlayer.X;
            }
        }
        private Dictionary<string, int> board = new Dictionary<string, int>()
            {
                {"TopXLeft",0},
                {"TopXMiddle",0},
                {"TopXRight",0},
                {"CenterXLeft",0},
                {"CenterXMiddle",0},
                {"CenterXRight",0},
                {"BottomXLeft",0},
                {"BottomXMiddle",0},
                {"BottomXRight",0}
            };
    }














}

       

    

    
