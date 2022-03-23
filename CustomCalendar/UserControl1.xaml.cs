using GalaSoft.MvvmLight.Command;
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

namespace CustomCalendar
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public object UCApps
        {
            get { return (object)GetValue(UCAppsProperty); }
            set { SetValue(UCAppsProperty, value); }
        }

        public static readonly DependencyProperty UCAppsProperty =
            DependencyProperty.Register("UCApps", typeof(object), typeof(UserControl1), new UIPropertyMetadata(null));        
        
        public new object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static readonly new DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(UserControl1), new UIPropertyMetadata(null)); 
        public int HeightContent
        {
            get { return (int)GetValue(HeightContentProperty); }
            set { SetValue(HeightContentProperty, value); }
        }

        public static readonly  DependencyProperty HeightContentProperty =
            DependencyProperty.Register("HeightContent", typeof(int), typeof(UserControl1), new UIPropertyMetadata(null));  
        public int WidthContent
        {
            get { return (int)GetValue(WidthContentProperty); }
            set { SetValue(WidthContentProperty, value); }
        }

        public static readonly new DependencyProperty WidthContentProperty =
            DependencyProperty.Register("WidthContentProperty", typeof(int), typeof(UserControl1), new UIPropertyMetadata(null));

        public UserControl1()
        {
            InitializeComponent();
            DataContext = this;
        }
        public static RelayCommand command
        {
            get
            {
                return new RelayCommand(()=> { MessageBox.Show("df"); });
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("df");
        }
    }
}
