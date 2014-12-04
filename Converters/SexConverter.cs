using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Szpadelek.Converters
{
    public class SexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string sex = value as string;
            if(sex=="male")
            {
                return "#328efe";
            }
            else if(sex=="female")
            {
                return "#F246D0";
            }
            else
            {
                return "#FF0F0F0F";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
