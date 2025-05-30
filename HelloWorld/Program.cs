

using HelloWorld;

//BadBankAccount badBankAccount=new BadBankAccount();

//badBankAccount.balance = -50;

//Console.WriteLine(badBankAccount.balance);



BankAccount bankacount=new BankAccount(200);


Console.WriteLine(bankacount.GetBalance());
bankacount.Deposit(100);

Console.WriteLine(bankacount.GetBalance());
