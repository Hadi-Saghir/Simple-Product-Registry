using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2 {

    class ItemManager {

        private List<String> drinks = new List<string>();
        private List<ShoppingItem> itemsList = new List<ShoppingItem>();

        public ItemManager() {
            itemsList.Add(new ShoppingItem());
        }

        public void SearchForDrinks(String Drink, String Category) {
            String[] str;
            drinks.Clear();

            switch (Category) {
                
                case "Haram":
                    str = itemsList[0].GetAlcoholic();
                    for (int i = str.Length - 1 ; i > -1; i++) {
                        if (str[i].ToLower().Contains(Drink.ToLower()))
                            drinks.Add(str[i]); 
                    }
                    break;

                case "Cold":
                    str = itemsList[0].GetCold();
                    for (int i = 0; i < str.Length; i++) {
                        if (str[i].ToLower().Contains(Drink.ToLower()))
                            drinks.Add(str[i]);
                    }
                    break;

                case "Hot":
                    str = itemsList[0].GetHot();
                    for (int i = 0; i < str.Length; i++) {
                        if (str[i].ToLower().Contains(Drink.ToLower()))
                            drinks.Add(str[i]);
                    }
                    break;

                case "Milkshakes":
                    str = itemsList[0].GetMilkshake();
                    for (int i = 0; i < str.Length; i++) {
                        if (str[i].ToLower().Contains(Drink.ToLower()))
                            drinks.Add(str[i]);
                    }
                    break;

                case "Soft":
                    str = itemsList[0].GetSoft();
                    for (int i = 0; i < str.Length; i++) {
                        if (str[i].ToLower().Contains(Drink.ToLower()))
                            drinks.Add(str[i]);
                    }
                    break;
            }

            

        }

        public List<String> GetDrinks() {
            return drinks;
        }

        public void SetDrinks(String Category) {
            String[] str;
            drinks.Clear();

            switch (Category) {

                case "Haram":
                    str = itemsList[0].GetAlcoholic();
                    for (int i = 0; i < str.Length; i++) {
                        drinks.Add(str[i]);
                    }
                    break;

                case "Cold":
                    str = itemsList[0].GetCold();
                    for (int i = 0; i < str.Length; i++) {
                        drinks.Add(str[i]);
                    }
                    break;

                case "Hot":
                    str = itemsList[0].GetHot();
                    for (int i = 0; i < str.Length; i++) {
                        drinks.Add(str[i]);
                    }
                    break;

                case "Milkshakes":
                    str = itemsList[0].GetMilkshake();
                    for (int i = 0; i < str.Length; i++) {
                        drinks.Add(str[i]);
                    }
                    break;

                case "Soft":
                    str = itemsList[0].GetSoft();
                    for (int i = 0; i < str.Length; i++) {
                        drinks.Add(str[i]);
                    }
                    break;
            }
        }

    }
}
