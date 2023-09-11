using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTasks
{
    public class CreateErrorException : Exception
    {
        public CreateErrorException(string message) : base(message) 
        { }
    }
}
