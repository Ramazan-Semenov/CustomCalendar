using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace CustomCalendar
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private DateTime DateDisplay;
        public string DateHeadContent { get; set; } = DateTime.Now.ToString("MMMM yyyy");
        public Window1()
        {
            InitializeComponent();
            // DataContext = this;
            DateHead.Content = DateHeadContent;

            DateDisplay = DateTime.Now;
            Init(DateDisplay);

        }

        private void Init(DateTime? dateTime=null)
        {
            PART_Day.Children.Clear();
            PART_WeekOfDay.Children.Clear();
            //PART_Day.RowDefinitions.Clear();
            //PART_WeekOfDay.RowDefinitions.Clear();
            //PART_WeekOfDay.ColumnDefinitions.Clear();
            if (dateTime == null)
            {
               // dateTime = DateTime.Now;
            }
            else
            {
              
                for (int i = 0; i < 6; i++)
                {
                    RowDefinition rowDefinition = new RowDefinition();
                    rowDefinition.Height = new GridLength();
                    PART_Day.RowDefinitions.Add(rowDefinition);

                }
                int daysCount = DateTime.DaysInMonth(dateTime.Value.Year, dateTime.Value.Month);
                //int daysCount = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                List<string> vs = new List<string> { "Пн", "Вт", "Ср","Чт", "Пт", "Сб", "Вс" };
                for (int i = 0; i < 7; i++)
                {

                    Button button = new Button
                    {
                        BorderThickness = new Thickness(0),
                        Background = Brushes.Transparent,
                        Content = vs[i]/* DateTime.Parse(DateTime.Parse(i + 1 + "." + dateTime.Value.ToString("MM.yyyy")).ToString()).ToString("dddd")*/
                    };

                        Grid.SetColumn(button, i);
                        Grid.SetRow(button, 0);
                        PART_WeekOfDay.Children.Add(button);
                     
                   
                }

                int count = 0;
                int start = 0;
                int countd = 0;
                if (DateTime.Parse(DateTime.Parse(1 + "." + dateTime.Value.ToString("MM.yyyy")).ToString()).ToString("ddd")=="Пн")
                {
                    start = 1;
                }
                else if (DateTime.Parse(DateTime.Parse(1 + "." + dateTime.Value.ToString("MM.yyyy")).ToString()).ToString("ddd")=="Вт")
                {
                    start = 2;
                }
               else if (DateTime.Parse(DateTime.Parse(1 + "." + dateTime.Value.ToString("MM.yyyy")).ToString()).ToString("ddd")=="Ср")
                {
                    start = 3;
                }
                else if (DateTime.Parse(DateTime.Parse(1 + "." + dateTime.Value.ToString("MM.yyyy")).ToString()).ToString("ddd")=="Чт")
                {
                    start = 4;
                }else if (DateTime.Parse(DateTime.Parse(1 + "." + dateTime.Value.ToString("MM.yyyy")).ToString()).ToString("ddd")=="Пт")
                {
                    start = 5;
                }else if (DateTime.Parse(DateTime.Parse(1 + "." + dateTime.Value.ToString("MM.yyyy")).ToString()).ToString("ddd")=="Сб")
                {
                    start = 6;
                }
                else if (DateTime.Parse(DateTime.Parse(1 + "." + dateTime.Value.ToString("MM.yyyy")).ToString()).ToString("ddd")=="Вс")
                {
                    start = 7;
                }
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        count++;   
                        if (countd <= daysCount)
                        {
                            if (count < start)
                            {
                                Button button = new Button { Content = "", Background = Brushes.Transparent, BorderThickness = new Thickness(0) };
                                Grid.SetColumn(button, j);
                                Grid.SetRow(button, i + 1);
                                PART_Day.Children.Add(button);
                            }
                            else
                            {
                                countd++;
                                if (countd <= daysCount)
                                {
                                    Button button = new Button { Content = countd };
                                    Grid.SetColumn(button, j);
                                    Grid.SetRow(button, i + 1);
                                    PART_Day.Children.Add(button);
                                }
                            }
                          

                          
                        }
                        
                    }
                }
            }
        }


        private void PART_PreviousButton_Click(object sender, RoutedEventArgs e)
        {
         
            DateDisplay=DateDisplay.AddMonths(-1);
            Console.WriteLine(DateDisplay);
            Init(DateDisplay);
            DateHeadContent = DateDisplay.ToString("MMMM yyyy"); ;
            DateHead.Content = "";
            DateHead.Content = DateHeadContent;
        }

        private void PART_NextButton_Click(object sender, RoutedEventArgs e)
        {
            DateDisplay = DateDisplay.AddMonths(1);
            Console.WriteLine(DateDisplay);
            Init(DateDisplay);
            DateHeadContent = DateDisplay.ToString("MMMM yyyy"); ;
            DateHead.Content = "";
            DateHead.Content = DateHeadContent;
        }

        private void DateHead_Click(object sender, RoutedEventArgs e)
        {
            popup1.IsOpen = true;
        }
    }
}
