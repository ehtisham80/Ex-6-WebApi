﻿using System;
using System.Collections.Generic;

namespace Ex_6_WebApi.Models
{
    public partial class ProductCategories
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
