public class PriceHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }
        public virtual Product Product { get; set; }
    }