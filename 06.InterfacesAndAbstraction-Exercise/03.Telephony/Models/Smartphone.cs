using _03.Telephony.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string BrowseURL(string url)
        {
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            return $"Calling... {number}";
        }
    }
}
