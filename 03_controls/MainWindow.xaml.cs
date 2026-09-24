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

namespace _03_controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid PrimerGird = new Grid();
            this.Content = PrimerGird;

            Button bt = new Button();
            WrapPanel wrapPanel = new WrapPanel();

            TextBlock blocdetext1 = new TextBlock();
            blocdetext1.Text = "Antropolophilia y";
            wrapPanel.Children.Add(blocdetext1);

            TextBlock blocdetext2 = new TextBlock();
            blocdetext2.Text = " Blasfemia = ";
            wrapPanel.Children.Add(blocdetext2);

            TextBlock blocdetext3 = new TextBlock();
            blocdetext3.Text = " Najib";
            wrapPanel.Children.Add(blocdetext3);

            bt.Content = wrapPanel;

            PrimerGird.Children.Add(bt);

            bt.Width = 200;
            bt.Height = 100;

            bt.Foreground=Brushes.Peru;
            bt.Foreground = Brushes.DarkRed;
            blocdetext1.Foreground = Brushes.DarkRed;
            blocdetext2.Foreground = Brushes.DarkBlue;
            blocdetext3.Foreground = Brushes.Magenta;

        }
    }
}
