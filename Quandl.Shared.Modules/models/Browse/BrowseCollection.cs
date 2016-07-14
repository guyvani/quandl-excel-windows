﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Quandl.Shared.Models.Browse
{
    public class BrowseCollection
    {
        
        public string Name { get; set; }
        public List<BrowseCollection> Items { get; set; }

        public List<OrderedResourceIds> OrderedResourceIds { get; set; }
    }

    /*public class Category 
    {
        public string Description { get; set; }
        public List<SubCategory> Items { get; set; }
        public string Name { get; set; }

    }

    public class SubCategory 
    {
        public List<LeafCategory> Items { get; set; }
        public string Name { get; set; }
    }

    public class LeafCategory
    {
        public List<OrderedResourceIds> OrderedResourceIds { get; set; }
        public string Name { get; set; }
    }*/

    public class OrderedResourceIds
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}