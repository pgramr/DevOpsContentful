namespace DevOpsContentful.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string IBAN { get; set; } = string.Empty;
        public string VTA { get; set; } = string.Empty;

    }
}
