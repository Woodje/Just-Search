using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Just_Search {
    public class MenuItem {
        public string Category { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
