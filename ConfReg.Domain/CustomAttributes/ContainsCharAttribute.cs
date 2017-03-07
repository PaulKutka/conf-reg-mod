using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ConfReg.Domain.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public sealed class ContainsCharAttribute : ValidationAttribute
    {
        private readonly char _requiredCharacter;

        public ContainsCharAttribute(char requiredCharacter)
        {
            _requiredCharacter = requiredCharacter;
        }

        public override bool IsValid(object value)
        {
            bool result = Convert.ToString(value).Contains(_requiredCharacter);
            return result;
        }
    }
}
