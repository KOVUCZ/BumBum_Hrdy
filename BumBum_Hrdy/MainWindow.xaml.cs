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

namespace BumBum_Hrdy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bomb> bombs = new List<Bomb>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Random random = new Random();
            var bomb = new Bomb(random.Next(5, 15));
            bomb.Detonation += Bomb_Detonation;
            bombs.Add(bomb);
        }

        private void Bomb_Detonation()
        {
            label.Content += "Bomba vybuchla";
        }
    }
}
