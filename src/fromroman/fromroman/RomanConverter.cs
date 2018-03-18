using System;
using System.Linq;

namespace fromroman
{
    public class RomanConverter
    {
        public static int Convert(string roman) {
            var values = Parse(roman);
            values = Subtract(values);
            return values.Sum();
        }

        
        internal static int[] Parse(string roman) {
            var digits = roman.ToCharArray();
            return digits.Select(MapToValue).ToArray();

            int MapToValue(char digit) {
                switch (char.ToUpper(digit))
                {
                    case 'I': return 1;
                    case 'V': return 5;
                    case 'X': return 10;
                    case 'L': return 50;
                    case 'C': return 100;
                    case 'D': return 500;
                    case 'M': return 1000;
                    default: throw new InvalidOperationException($"Unknown digit: {digit}!");
                }
            }
        }

        
        public static int[] Subtract(int[] values)
        {
            return values;
        }
    }
}