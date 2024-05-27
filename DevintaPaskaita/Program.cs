using DevintaPaskaita;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold various accounts
        List<IPaymentMethod> accounts = new List<IPaymentMethod>
        {
            new CreditAccount("Alice", 500.00),
            new DebitAccount("Bob", 300.00),
            new CreditAccount("Charlie", 1000.00),
            new DebitAccount("Dana", 50.00)
        };

        // Define some payment amounts to test
        double[] paymentAmounts = { 200.00, 50.00, 700.00, 30.00 };

        // Iterate through the list and try different payments
        foreach (var account in accounts)
        {
            foreach (var amount in paymentAmounts)
            {
                account.Pay(amount);
            }
            Console.WriteLine();
        }
    }
}