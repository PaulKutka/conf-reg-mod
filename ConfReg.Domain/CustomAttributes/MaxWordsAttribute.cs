using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfReg.Domain.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class MaxWordsAttribute : ValidationAttribute
    {
        private readonly int _max;

        public MaxWordsAttribute(int max)
        {
            _max = max;
        }

        public override bool IsValid(object value)
        {
            bool result = true;
            result = Count(Convert.ToString(value), _max);
            return result;
        }

        private bool Count(string text, int max)
        {
            int counter = 0;
            text = text.Trim();

            if (text == "")
                return true;

            while (text.Contains("  "))
                text = text.Replace("  ", " ");

            foreach (string y in text.Split(' '))
                counter++;

            if (counter > max) return false;
            return true;
        }
    }
}
