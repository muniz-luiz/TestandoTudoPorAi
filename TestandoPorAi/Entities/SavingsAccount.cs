using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoPorAi.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }   
         
        
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void updateBalance ()
        {
            Balance += Balance * InterestRate;
        }
    }




}
