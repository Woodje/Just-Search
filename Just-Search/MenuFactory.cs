using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Just_Search {
    internal class MenuFactory {

        internal Menu CreateMenu(string html) {
            return new Menu();
        }

        private MenuItem CreateMenuItem() {
            return new MenuItem();
        }

        private void SetCategory() {

        }

        private void SetIngredients() {

        }

        private void SetPrice()
        {
            
        }

        private void SetDescription()
        {
            
        }

        private void SetName()
        {
            
        }
    }
}
