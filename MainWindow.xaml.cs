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

namespace byte_converter
{
    public partial class MainWindow : Window
    {

        public bool b1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tb_Checked(object sender, RoutedEventArgs e)
        {
            b1 = true;
        }

        private void bt_Checked(object sender, RoutedEventArgs e)
        {
            b1 = false;
        }

        private void mbutton_Click(object sender, RoutedEventArgs e)
        {
            if (b1)
            {
                byte[] byte_t = Encoding.Default.GetBytes(box.Text);
                string res = String.Join("", byte_t);

                ResWin rw = new ResWin();
                rw.Show();
                rw.rbox.Text = res;
            }
        }
    }
}
