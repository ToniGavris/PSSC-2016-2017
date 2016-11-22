using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        public Grade(decimal value)
        {
            if(_value > 10 || _value < 1)
                throw new InvalidGradeValue("Illegal grade");
            _value = value;
        }
        public override bool Equals(object obj)
        {
            return this._value.Equals((obj as Grade).Value);
        }
        public override string ToString()
        {
            return "Nota este: " + _value;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    } 
}
