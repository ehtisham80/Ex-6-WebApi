﻿using System;
using System.Collections.Generic;

namespace Ex_6_WebApi.Models
{
    public partial class Baskets
    {
        public Baskets()
        {
            BasketItems = new HashSet<BasketItems>();
        }

        public string Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual ICollection<BasketItems> BasketItems { get; set; }
    }
}
