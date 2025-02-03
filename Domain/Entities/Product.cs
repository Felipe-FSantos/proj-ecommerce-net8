using Ecommerce.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }

        public Product(Guid id, string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(id);
            ValidateDomain(name, description, price, stock, image);
        }

        public void Update(string name, string description, decimal price, int stock, string image, Guid categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;

            DateUpdated = DateTime.Now;
        }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainException.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required");

            DomainException.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characters");

            DomainException.When(string.IsNullOrEmpty(description),
                "Invalid description. Description is required");

            DomainException.When(description.Length < 5,
                "Invalid description, too short, minimum 5 characters");

            DomainException.When(price < 0, "Invalid price value");

            DomainException.When(stock < 0, "Invalid stock value");

            DomainException.When(image?.Length > 250,
                "Invalid image name, too long, maximum 250 characters");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;

        }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
