﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is Required.")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Description is Required.")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Price is Required.")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stock is Required.")]
        [Range(1, 9999)]
        [DisplayName("Stock")]
        public int Stock { get; set; }

        [MaxLength(250)]
        [DisplayName("Product Image")]
        public string? Image { get; set; }

        [JsonIgnore]
        public CategoryDTO? Category { get; set; }

        [DisplayName("Categories")]
        public int CategoryId { get; set; }

    }
}
