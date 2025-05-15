namespace Tournament.Model.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int TransactionCode { get; set; }
        public int RegisterId { get; set; }
        public Register? Register { get; set; }

    }
}
