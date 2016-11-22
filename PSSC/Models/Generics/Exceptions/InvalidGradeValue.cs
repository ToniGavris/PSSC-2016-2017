using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    class InvalidGradeValue : Exception
    {
        public InvalidGradeValue(String message) : base(message)
        {
            
        }

    }
}
