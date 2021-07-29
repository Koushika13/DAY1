using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_off
{
    class InvalidAmountException :ApplicationException
    {
        public InvalidAmountException(string Message) : base(Message)
        {

        }
    }

    class InsufficientFundException : ApplicationException
    {
        public InsufficientFundException(string Message) : base(Message)
        {

        }
    }
}
