﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is Required.")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }

    }
}
