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

namespace BT_WPF_8n12
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string name = " ";
            name = txtHodem.Text + " " + txtTen.Text;
            MessageBox.Show(name);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtHodem.Text = " ";
            txtTen.Text = " ";
        }
    }
}
