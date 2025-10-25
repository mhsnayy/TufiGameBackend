
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TufiGame.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(String Message):base(Message)
        {

        }
        public ValidationException() : this("One or more validation errors occurred.")
        {

        }
        public ValidationException(Exception ex):this(ex.Message)
        {
            
        }
    }
}
