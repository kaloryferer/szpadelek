using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Szpadelek.Converters
{
    public class GroupConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            
            int? group = value as int?;
            switch (group)
            {
                case 0:
                    return "#339933";
                    break;
                case 1:
                    return "#FF5917";
                    break;
                case 2:
                    return "#BB0000";
                    break;
                case 5:
                    return "white";
                    break;
                case 1001:
                    return "#999999";
                    break;
                case 1002:
                    return "#999999";
                    break;
                case 2001:
                    return "#3F6FA0";
                    break;
                default:
                    return "white";
                    break;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
            
        }
    }
}
