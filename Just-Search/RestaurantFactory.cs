namespace Just_Search {
    public class RestaurantFactory {
        private Restaurant restaurant;
        private string html;
        public Restaurant CreateRestaurant(string html) {
            restaurant = new Restaurant { Menu = new MenuFactory().CreateMenu() };
            this.html = html;
            return restaurant;
        }

        #region Private Methods

        private void SetAddress() {

        }

        private void SetName() {

        }

        private void SetDescription() {

        }

        private void SetFoodTypes() {

        }

        private void SetDelivery() {

        }

        private void SetOpeningHours() {

        }

        #endregion

    }
}