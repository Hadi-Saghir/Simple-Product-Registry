using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2 {
    class ShoppingItem {

        private String[] alcoholic;
        private String[] cold;
        private String[] hot;
        private String[] milkshake;
        private String[] soft;

        //Constructor
        public ShoppingItem() {

            this.alcoholic = new String[] { "Beer", "Wine", "Cider", "Cocktail",
                "Tequila", "Martini", "Vodka", "Jagermeister", "Margarita", "Rum" };


            this.cold = new String[] { "Lemonade", "Orange Juice", "Strawberry Juice", "Apple Juice", "Smoothie",
                "Milkshake", "Ice tea", "Iced Latte", "Iced Coffee", "" };

            this.hot = new String[] { "Coffee", "Cappuccino", "Espresso", "Latte", "Hot Chocolate",
                "Earl Grey", "English Breakfast", "Mocha", "Chai Latte", "Americano" };

            this.milkshake = new String[]  {"Strawberry Milkshake","Vanilla Milkshake","Mango Milshake",
                "Passion Fruit Milkshake", "Chocolate Milkshake","Caramel Milkshake","Oreo Milkshake",
                "Cinnamon Milshake","Pineapple Milkshake","Kit-Kat Milkshake", "Twix Milkshake"};

            this.soft = new String[] { "Coke", "Diet Coke", "Fanta", "Sprite", "Dr.Pepper",
                "Mountain Dew", "Pepsi", "Diet Pepsi", "Sparkling Water", "Monster", "Redbull" };

        }

        public String[] GetBrews() {
            return this.alcoholic;
        }

        public String GetBrewsAt(int x) {
            return this.alcoholic[x];
        }

        public String[] GetCold() {
            return this.cold;
        }

        public String GetColdAt(int x) {
            return this.cold[x];
        }

        public String[] GetHot() {
            return this.hot;
        }

        public String GetHotAt(int x) {
            return this.hot[x];
        }

        public String[] GetMilkshake() {
            return this.milkshake;
        }

        public String GetMilkshakeAt(int x) {
            return this.milkshake[x];
        }

        public String[] GetSoft() {
            return this.soft;
        }

        public String GetSoftAt(int x) {
            return this.soft[x];
        }
    }
}
