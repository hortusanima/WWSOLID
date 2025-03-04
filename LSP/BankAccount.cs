using System;

public class BankAccount
{
	public decimal Balance { get; protected set; }

	public BankAccount(decimal initialBalance)
	{
		Balance = initialBalance;
	}

	// General withdrawal method for BankAccount
	public virtual void Withdraw(decimal amount)
	{
		if (Balance >= amount)
		{
			Balance -= amount;
			Console.WriteLine($"Withdrew {amount}, balance is now {Balance}");
		}
		else
		{
			Console.WriteLine("Insufficient funds!");
		}
	}
}

public class CheckingAccount : BankAccount
{
	public decimal OverdraftLimit { get; set; }

	public CheckingAccount(decimal initialBalance, decimal overdraftLimit)
		: base(initialBalance)
	{
		OverdraftLimit = overdraftLimit;
	}

	// CheckingAccount allows withdrawal beyond the balance, up to the overdraft limit
	public override void Withdraw(decimal amount)
	{
		if (Balance + OverdraftLimit >= amount)
		{
			Balance -= amount;
			Console.WriteLine($"Withdrew {amount}, balance is now {Balance} (within overdraft limit)");
		}
		else
		{
			Console.WriteLine("Exceeded overdraft limit!");
		}
	}
}

public class SavingsAccount : BankAccount
{
	public SavingsAccount(decimal initialBalance) : base(initialBalance)
	{
	}

	// SavingsAccount doesn't allow withdrawal beyond balance
	public override void Withdraw(decimal amount)
	{
		if (Balance >= amount)
		{
			Balance -= amount;
			Console.WriteLine($"Withdrew {amount}, balance is now {Balance}");
		}
		else
		{
			Console.WriteLine("Insufficient funds!");
		}
	}
}