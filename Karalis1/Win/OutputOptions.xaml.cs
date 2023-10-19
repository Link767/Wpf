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
    /// <summary>
    /// Логика взаимодействия для OutputOptions.xaml
    /// </summary>
    public partial class OutputOptions : Window
    {
        public OutputOptions()
        {
            InitializeComponent();
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Avtorization_Click(object sender, RoutedEventArgs e)
        {
            WinAvto winAvto = new WinAvto();
            winAvto.Show();
            this.Close();
        }
    }
}
