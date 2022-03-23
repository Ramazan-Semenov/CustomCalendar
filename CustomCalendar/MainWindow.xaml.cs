using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomCalendar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ControlTemplate df = Cal.Template;
            var f = df.FindName("",Cal);
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as Button).Content.ToString());
        }
      

        private void Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("Ok");
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            //StackPanel txt = (StackPanel)Cal.Template.FindName("PART_Root", Cal);
            //foreach (var item in txt.Children)
            //{
            //    foreach (var item2 in (item as Grid).Children)
            //    {
            //        Console.WriteLine(item2);
            //    } 
                
            //}
            //txt.MouseDown += new MouseButtonEventHandler(txt_MouseDown);
        }

        private void T_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(sender);
        }

        void txt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("sd");
        }

        private void ScrollViewer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("111");

        }

        private void UserControl1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show((sender as Button).Content.ToString());
        }

        private void Button_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            MessageBox.Show((sender).ToString());

        }
    }
}
