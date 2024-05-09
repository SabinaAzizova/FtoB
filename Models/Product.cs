using System.ComponentModel;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CatagoryId { get; set; }
        public  Catagory? Catagory { get; set; }
        public string MainPhotoUrl { get; set; }
        public string PhotoUrl { get; set; }
    }
}
