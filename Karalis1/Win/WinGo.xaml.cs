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

namespace Karalis1.Win
{
    public partial class WinGo : Window
    {
        public WinGo()
        {
            InitializeComponent();
        }

        private void BOut_Click(object sender, RoutedEventArgs e)
        {
            OutputOptions outputOptions = new OutputOptions();
            outputOptions.Show();
            this.Close();
        }

        private void BResPas_Click(object sender, RoutedEventArgs e)
        {
            RewPas rewPas = new RewPas();
            rewPas.Show();
            this.Close();
        }

        private void BMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWin mainWin = new MainWin();
            mainWin.Show();
            this.Close();
        }
    }
}
