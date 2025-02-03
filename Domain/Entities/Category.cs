using Ecommerce.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities
{
    public sealed class Category : BaseEntity
    {
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(Guid id, string name)
        {
            ValidateDomain(id);
            ValidateDomain(name);
        }

        public void Update(string name)
        {
            ValidateDomain(name);

            DateUpdated = DateTime.Now;
        }

        public ICollection<Product> Products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required.");

            DomainException.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characters.");

            Name = name;
        }

    }
}
