
BankAccount checkingAccount = new CheckingAccount(1000, 500);
BankAccount savingsAccount = new SavingsAccount(1000);

// Here, we're expecting the Liskov Substitution Principle to hold, but it doesn't:
checkingAccount.Withdraw(1200);  // This works for CheckingAccount, but not for SavingsAccount
savingsAccount.Withdraw(1200);   // This will fail for SavingsAccount, but should work for CheckingAccount

Console.WriteLine("Testing substitution with both types of accounts...");

// Using both accounts interchangeably may lead to unexpected results
TestWithdrawal(checkingAccount);
TestWithdrawal(savingsAccount);
	

static void TestWithdrawal(BankAccount account)
{
	// This should work correctly for a CheckingAccount but may not work correctly for a SavingsAccount
	account.Withdraw(500);
}
