using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace CustomCalendar
{
    public class DateTimeToDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.ToString()=="Пн")
            {
                return "Понедельник";
            }     
          else  if(value.ToString()=="Вт")
            {
                return "Вторник";
            }
            else if (value.ToString()=="Ср")
            {
                return "Среда";
            }
            else if (value.ToString()=="Чт")
            {
                return "Четверг";
            }
            else if (value.ToString()=="Пт")
            {
                return "Пятница";
            }
            else if (value.ToString()=="Сб")
            {
                return "Суббота";
            }
            else if (value.ToString()=="Вс")
            {
                return "Воскресенье";
            }    

            return (value).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
