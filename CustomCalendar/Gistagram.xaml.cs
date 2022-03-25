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

namespace CustomCalendar
{
    /// <summary>
    /// Логика взаимодействия для Gistagram.xaml
    /// </summary>
    public partial class Gistagram : Window
    {
        public int MaxValue { get; set; } = 40;
        public int Frequency { get; set; } = 5;

        public List<ItemGistogram> ListItemGistogram { get; set; }
        private int NumberOfColumns 
        { 
            get 
            {

                return MaxValue / Frequency;
            } 
        }
        public Gistagram()
        {
            InitializeComponent();
            ListItemGistogram = new List<ItemGistogram>();
            ListItemGistogram.Add(new ItemGistogram {Name="Сектор 1", Value=30, Color=Brushes.LightSteelBlue });
            ListItemGistogram.Add(new ItemGistogram {Name="Сектор 2", Value=40, Color=Brushes.LightSteelBlue });
            ListItemGistogram.Add(new ItemGistogram {Name="Сектор 3", Value=10, Color=Brushes.LightSteelBlue });


            int contentcount =0;
            for (int i = 0; i <= NumberOfColumns; i++)
            {
                GraphGist.ColumnDefinitions.Add(new ColumnDefinition());
                Label label = new Label() { Content = contentcount };
                contentcount += Frequency;
                Grid.SetRow(label,0);
                Grid.SetColumn(label,i);
                Border border = new Border { BorderBrush = Brushes.Gray, BorderThickness = new Thickness(1,0,0,0) };
                Grid.SetColumn(border, i);
                Grid.SetRow(border,1);
                GraphGist.Children.Add(label);
                GraphGist.Children.Add(border);
            }
            int MarginTop = 15;
            int MarginNameTop = 10;
            int Height = 15;
            int HeightName = 25;
            for (int i = 0; i < ListItemGistogram.Count; i++)
            {
                Label label = new Label() { VerticalAlignment= VerticalAlignment.Top, Height=Height,Margin=new Thickness(0, MarginTop, 0,0)};
                label.Background = ListItemGistogram[i].Color;
                Grid.SetRow(label,1);
                Grid.SetColumn(label,0);
                Grid.SetColumnSpan(label, ListItemGistogram[i].Value/ Frequency);
                Label label1 = new Label { VerticalAlignment = VerticalAlignment.Top, Height = HeightName, Margin = new Thickness(0, MarginNameTop, 0, 0) };
                label1.Content = ListItemGistogram[i].Name;
                Grid.SetRow(label1,1);
                GraphGist.Children.Add(label);
                Name.Children.Add(label1);
                MarginTop += 35;
                MarginNameTop += 30;
            }

        }
    }
   public class ItemGistogram
    {
        public int id { get; set; }

        public string Name { get; set; }

        public Brush Color { get; set; }

        public int Value { get; set; }
    }
}
