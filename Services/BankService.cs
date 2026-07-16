using NovaPay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using NovaPay.Models;

namespace NovaPay.Services
{
  public class BankService
  {
    private Account account;

    public void CreateAccount()
    {
      Console.Clear();

      Console.WriteLine("===== Create Account =====");

      Console.Write("Full Name: ");
      string fullName = Console.ReadLine();

      Console.Write("Account Number: ");
      int accountNumber = Convert.ToInt32(Console.ReadLine());

      Console.Write("Password: ");
      string password = Console.ReadLine();

      Console.Write("Initial Balance: ");
      decimal balance = Convert.ToDecimal(Console.ReadLine());

      account = new Account(fullName, accountNumber, password, balance);

      Console.WriteLine();
      Console.WriteLine("Account Created Successfully.");
    }

    public void ShowAccountInfo()
    {
      Console.Clear();

      if (account == null)
      {
        Console.WriteLine("No account found.");
        return;
      }

      Console.WriteLine("===== Account Information =====");

      Console.WriteLine($"Name : {account.FullName}");
      Console.WriteLine($"Account Number : {account.AccountNumber}");
      Console.WriteLine($"Balance : {account.Balance} EGP");
    }
  }
}
