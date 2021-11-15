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
using System.Runtime.InteropServices;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Screenshots
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        //static Random rnd = new Random();
        //char randomChar = (char)rnd.Next('a', 'z');
        //char randomChar2 = (char)rnd.Next('a', 'z');
        
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');
            char randomChar2 = (char)rnd.Next('a', 'z');

            System.Diagnostics.Process.Start("https://prnt.sc/"+randomChar+randomChar2+(GenerateRandomNo()));

        }

        private void SetForegroundWindow(object handle)
        {
            throw new NotImplementedException();
        }
    }
}
