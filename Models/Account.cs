using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Models
{
  public class Account
  {
    private int accountNumber;
    private object password1;

    public string FullName { get; set; }
    public string AccountNumber { get; set; }
    public string password { get; set; }
    public decimal Balance { get; set; }

    public Account(string fullName, string accountNumber, string password, decimal balance)
    {
      FullName = fullName;
      AccountNumber = accountNumber;
      this.password = password;
      Balance = balance;
    }

    public Account(string? fullName, int accountNumber, object password1, decimal balance)
    {
      FullName = fullName;
      this.accountNumber = accountNumber;
      this.password1 = password1;
      Balance = balance;
    }
  }
}
