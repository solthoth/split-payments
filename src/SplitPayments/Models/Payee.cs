namespace SplitPayments.Models
{
    public class Payee
    {
        public string NameOnAccount { get; set; }

        public BankAccountType AccountType { get; set; }

        public string RoutingNumber { get; set; }

        public string AccountNumber { get; set; }

        public SplitType SplitType { get; set; }

        public decimal Value { get; set; }
    }
    public enum BankAccountType:byte
    {
        Checking = 1,
        Savings
    }
    public enum SplitType : byte
    {
        Percentage = 1
    }
}
