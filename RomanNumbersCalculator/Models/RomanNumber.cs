using Avalonia.Animation.Animators;
using DynamicData.Aggregation;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumber : IComparable, ICloneable
    {
        private ushort number = 1;
        private string stringNumber = string.Empty;
        public RomanNumber(ushort number)
        {
            if (number < 1 || number > 3999) throw new RomanNumberException("#ERROR");
            string[] rim_numbers = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I", " " };
            ushort[] numbers_array = new ushort[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1, 0 };
            this.number = number;
            string word = string.Empty;
            int counter = 0;
            while (number > 0)
            {
                while (numbers_array[counter] <= number)
                {
                    word += rim_numbers[counter];
                    number -= numbers_array[counter];
                }
                counter++;
            }
            stringNumber = word;
        }
        private ushort GetUShortIndex(char numberr)
        {
            ushort result = 0;
            switch (numberr)
            {
                case 'I':
                    result = 1;
                    break;
                case 'V':
                    result = 5;
                    break;
                case 'X':
                    result = 10;
                    break;
                case 'L':
                    result = 50;
                    break;
                case 'C':
                    result = 100;
                    break;
                case 'D':
                    result = 500;
                    break;
                case 'M':
                    result = 1000;
                    break;
                default:
                    break;
            }
            return result;
        }
        public RomanNumber(string number)
        {
            stringNumber = number;
            if (number.Length == 1)
            {
                this.number = GetUShortIndex(number[0]);
            }
            else
            {
                ushort result = 0;
                int i = 0;
                while (i < number.Length - 1)
                {
                    if (GetUShortIndex(number[i]) < GetUShortIndex(number[i + 1]))
                    {
                        result += (ushort)(GetUShortIndex(number[i + 1]) - GetUShortIndex(number[i]));
                        i += 2;
                    }
                    else
                    {
                        result += GetUShortIndex(number[i]);
                        i++;
                        if (i == number.Length - 1)
                        {
                            result += GetUShortIndex(number[i]);
                        }
                    }
                }
                this.number = result;
            }
            if (number != new RomanNumber(this.number).ToString())
            {
                throw new RomanNumberException("#ERROR");
            }
            if (this.number < 1 || this.number > 3999)
            {
                throw new RomanNumberException("#ERROR");
            }
        }
        public override string ToString() => stringNumber;
        public ushort ToUInt16() => number;

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
