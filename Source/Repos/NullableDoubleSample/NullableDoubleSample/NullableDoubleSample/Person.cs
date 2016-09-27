using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NullableDoubleSample
{
    public class Person: BindableObject
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public double? Marks { get; set; }

        private string marksString;
        public string MarksString
        {
            get { return Marks.ToString(); }
            set {
                marksString = value;
                double newValue;
                var result = double.TryParse(value, out newValue);
                if (result)
                {
                    Marks = newValue; 
                }
            }
        }
        
    }
}
