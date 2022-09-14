using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MVVMApp.Converters
{
    public class AgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string s = "System.Windows.Controls.ComboBoxItem:";
            if (value == null)
            {
                return "";
            }
            else if(value.ToString() == s+" Below 10")
            {
                return "  Kid";
            }
            else if (value.ToString() == s + " 10-17")
            {
                return "  Teenage";
            }
            else if (value.ToString() == s + " 18-45")
            {
                return "  Adult";
            }
            else if (value.ToString() == s+" Above 45")
            {
                return "  Senior Adult";
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
