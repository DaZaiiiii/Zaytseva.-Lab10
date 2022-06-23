using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Item
    {
        public string Name;      //название товара
        public int Price;        //цена товара
        public string Category;   //категория товара
        public int Amount;       //количество данных товаров в наличии

        public Item(string nm, int p, string c, int a)
        {
            Name = nm;
            Price = p;
            Category = c;
            Amount = a;
        }
    }
}
