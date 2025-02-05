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
        public string Distance { get; internal set; }
        public string PromoText { get; internal set; }
        

        public Restaurant()
        {
            Categories = new List<string>();
        }
    }
}