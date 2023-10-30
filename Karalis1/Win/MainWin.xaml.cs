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
    public partial class MainWin : Window
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void MIGo_Click(object sender, RoutedEventArgs e)
        {
            WinGo winGo = new WinGo();
            winGo.Show();
            this.Close();
        }

        private void StudList_Click(object sender, RoutedEventArgs e)
        {
           StudentList studentList = new StudentList(); 
           studentList.Show();
           this.Close();
        }

        private void TeashList_Click(object sender, RoutedEventArgs e)
        {
            TeachList teashList = new TeachList();
            teashList.Show();
            this.Close();
        }

        private void WorkList_Click(object sender, RoutedEventArgs e)
        {
            WorkList workList = new WorkList(); 
            workList.Show();
            this.Close();
        }
    }
}
