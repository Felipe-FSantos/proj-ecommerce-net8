﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Validation
{
    public class DomainException : Exception
    {
        public DomainException(string error) : base(error)
        {
            
        }

       public static void When(bool hasError, string error)
        {
            if (hasError)
            {
                throw new DomainException(error);
            }
        }

    }
}
