using drofustask1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drofustask1
{
    public class CreditService : ICreditService
    {
        public static int CurrentCredit { get; set; } = 0;

        public void InsertMoney(int amount)
        {
            CurrentCredit += amount;
            Console.WriteLine($"Current credit is {CurrentCredit}");
        }

        public void RecallMoney()
        {
            Console.WriteLine($"Giving out {CurrentCredit}");
            CurrentCredit = 0;
        }
    }
}
