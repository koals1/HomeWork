using System;

class CreditCard
{
    public string CardNumber { get; private set; }
    public string HolderName { get; private set; }
    public string ExpiryDate { get; private set; }
    private string pin;
    public decimal CreditLimit { get; private set; }
    public decimal Balance { get; private set; }

    public event Action<decimal> AccountReplenished;
    public event Action<decimal> MoneySpent;
    public event Action CreditUsageStarted;
    public event Action<decimal> TargetBalanceReached;
    public event Action PinChanged;

    public CreditCard(string cardNumber, string holderName, string expiryDate, string pin, decimal creditLimit, decimal initialBalance)
    {
        CardNumber = cardNumber;
        HolderName = holderName;
        ExpiryDate = expiryDate;
        this.pin = pin;
        CreditLimit = creditLimit;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            if (AccountReplenished != null)
            {
                AccountReplenished(amount);
            }
        }
    }

    public void Spend(decimal amount)
    {
        if (amount > 0 && Balance + CreditLimit >= amount)
        {
            if (Balance < amount)
            {
                if (CreditUsageStarted != null)
                {
                    CreditUsageStarted();
                }
            }

            Balance -= amount;
            if (MoneySpent != null)
            {
                MoneySpent(amount);
            }
        }
    }

    public void CheckTargetBalance(decimal target)
    {
        if (Balance >= target)
        {
            if (TargetBalanceReached != null)
            {
                TargetBalanceReached(target);
            }
        }
    }

    public void ChangePin(string newPin)
    {
        if (!string.IsNullOrWhiteSpace(newPin) && newPin.Length == 4)
        {
            pin = newPin;
            if (PinChanged != null)
            {
                PinChanged();
            }
        }
    }
}

class CardEventHandler
{
    public static void OnAccountReplenished(decimal amount)
    {
        Console.WriteLine("Счет пополнен на: " + amount);
    }

    public static void OnMoneySpent(decimal amount)
    {
        Console.WriteLine("Потрачено: " + amount);
    }

    public static void OnCreditUsageStarted()
    {
        Console.WriteLine("Используются кредитные деньги!");
    }

    public static void OnTargetBalanceReached(decimal target)
    {
        Console.WriteLine("Баланс достиг: " + target);
    }

    public static void OnPinChanged()
    {
        Console.WriteLine("PIN-код успешно изменен!");
    }
}

class Program
{
    static void Main()
    {
        CreditCard card = new CreditCard("1234 5678 9012 3456", "Иван Иванов", "31.12.2028", "1234", 5000, 1000);

        card.AccountReplenished += new Action<decimal>(CardEventHandler.OnAccountReplenished);
        card.MoneySpent += new Action<decimal>(CardEventHandler.OnMoneySpent);
        card.CreditUsageStarted += new Action(CardEventHandler.OnCreditUsageStarted);
        card.TargetBalanceReached += new Action<decimal>(CardEventHandler.OnTargetBalanceReached);
        card.PinChanged += new Action(CardEventHandler.OnPinChanged);

        card.Deposit(500);
        card.Spend(2000);
        card.CheckTargetBalance(1500);
        card.ChangePin("4321");
    }
}
