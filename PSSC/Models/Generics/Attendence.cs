using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    public class Attendance
    {
        private int _count;
        public int Count { get; internal set; }

        public Attendance(int count)
        {
            if(_count < 0)
                throw new InvalidAttendance("Invalid");
            _count = count;
        }
        public override bool Equals(object obj)
        {
            return this._count.Equals((obj as Attendance).Count); 
        }
        public override string ToString()
        {
            return "Numarul de prezente este: " + _count;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
