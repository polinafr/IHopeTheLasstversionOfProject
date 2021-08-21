using DAL.Enums;

namespace BL.Entities
{
    public class Good
    {
        public Good() { }

        public Good(float price, string shop, float quantity, GoodType type, string name,
            int? id = null, int? bucketId = null, string picture = null, string description = null)
        {
            this.Id = id ?? 0;
            this.Price = price;
            this.Shop = shop;
            this.Quantity = quantity;
            this.Picture = picture;
            this.Description = description;
            this.Type = type;
            this.Name = name;
            this.BucketId = bucketId;
        }

        public int Id { get; private set; }
        public float Price { get; private set; }
        public string Shop { get; private set; }
        public float Quantity { get; private set; }
        public string Picture { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public GoodType Type { get; private set; }
        public int? BucketId { get; private set; }


        public bool HasPicture() => !string.IsNullOrWhiteSpace(this.Picture);
        public bool HasDescription() => !string.IsNullOrWhiteSpace(this.Picture);

        public void ChangePrice(float price)
        {
            this.Price = price;
        }

        public void ChangeQuantity(int qty)
        {
            this.Quantity = qty;
        }

        public void ChangeName(string name)
        {
            this.Name = name;
        }

        public void AddToBucket(int bucketId)
        {
            this.BucketId = bucketId;
        }
    }
}
