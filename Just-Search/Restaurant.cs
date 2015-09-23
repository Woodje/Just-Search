using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Just_Search {
    public class Restaurant {
        public Menu Menu { get; set; }
        public Address Address { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> FoodTypes { get; set; }
        public Delivery Delivery { get; set; }
        public IEnumerable<OpeningHour> OpeningHours  { get; set; }
    }
}
