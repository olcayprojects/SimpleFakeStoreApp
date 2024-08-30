namespace SimpleFakeStoreApp.Models
{
    public class Product
    {
        public int id { get; set; }             // JSON'daki 'id' ile uyumlu
        public string title { get; set; }       // JSON'daki 'title' ile uyumlu
        public decimal price { get; set; }      // JSON'daki 'price' ile uyumlu (decimal tipinde)
        public string category { get; set; }    // JSON'daki 'category' ile uyumlu
        public string description { get; set; } // JSON'daki 'description' ile uyumlu
        public string image { get; set; }       // JSON'daki 'image' ile uyumlu
    }
}
