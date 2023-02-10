namespace Bricksmagic.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PropertyId { get; set; } 
        public double  Amount { get; set; }   
        public string PaymentType { get; set; } 
        public string TransactionDate { get; set; }
    }
}
