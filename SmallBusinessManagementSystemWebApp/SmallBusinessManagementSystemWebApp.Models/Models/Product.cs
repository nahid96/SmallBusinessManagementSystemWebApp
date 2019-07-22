﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystemWebApp.Models.Models
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int ReorderLevel { get; set; }
        public string Description { get; set; }
    }
}
