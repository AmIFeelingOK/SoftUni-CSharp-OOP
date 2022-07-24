using _03.Telephony.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        { 
            return $"Dialing... {number}";
        }

        private bool ValidateNumber(string number)
        {
            foreach (char digit in number)
            {
                if (char.IsDigit(digit))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
