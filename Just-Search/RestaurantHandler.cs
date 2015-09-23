using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Search {
    public class RestaurantHandler
    {
        private Dictionary<string, Restaurant> restaurants;

        public RestaurantHandler()
        {
            restaurants = new Dictionary<string, Restaurant>();
        }
    }
}
