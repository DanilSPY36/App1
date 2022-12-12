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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            Random random = new Random();
            List<string> animals = new List<string>()
            {
                "\U0001f988","\U0001f988",
                "🐘","🐘",
                "🐒","🐒",
                "\U0001f987","\U0001f987",
                "🦖","\U0001f996",
                "\U0001f9a5","🦥",
                "🐢","🐢",
                "\U0001f99e","🦞",
            };
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int i = random.Next(animals.Count);
                string nextEmoji = animals[i];
                textBlock.Text = nextEmoji;
                animals.RemoveAt(i);
            }
        }
    }
}
