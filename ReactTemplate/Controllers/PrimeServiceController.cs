using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ReactTemplate.Controllers
{
    public class PrimeServiceController : Controller
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }

        public static bool isMagicSquare(List<List<decimal>> matrix)
        {
            return true;
        }
    }
}
