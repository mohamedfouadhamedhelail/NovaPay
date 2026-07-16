
using NovaPay.Services;

BankService bank = new BankService();

while (true)
{
  Console.Clear();

  Console.WriteLine("=================================");
  Console.WriteLine("          NovaPay");
  Console.WriteLine("=================================");

  Console.WriteLine("1. Create Account");
  Console.WriteLine("2. Show Account");
  Console.WriteLine("3. Exit");

  Console.Write("Choose: ");

  int choice = Convert.ToInt32(Console.ReadLine());

  switch (choice)
  {
    case 1:
      bank.CreateAccount();
      break;

    case 2:
      bank.ShowAccountInfo();
      break;

    case 3:
      return;

    default:
      Console.WriteLine("Invalid Choice");
      break;
  }

  Console.WriteLine();
  Console.WriteLine("Press Any Key...");
  Console.ReadKey();
}
