namespace DoorDashClone.Models
{
    public class Restaurant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Rating { get; set; }
        public string DeliveryTime { get; set; }
        public string DeliveryFee { get; set; }
        public List<string> Categories { get; set; }

        public Restaurant()
        {
            Categories = new List<string>();
        }
    }
}