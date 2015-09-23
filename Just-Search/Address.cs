using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Just_Search {
    public class Address {
        private string street;

        public string Street
        {
            get { return street; }
            set
            {
                if(value.Contains("<")) throw new ArgumentException("Invalid character in argument");
                street = value;
            }
        }

        public string  HouseNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}
