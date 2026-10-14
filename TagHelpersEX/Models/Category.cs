using System;
using System.Collections.Generic;

namespace TagHelpersEX.Models
{
    public class Category
    {
        public Int64    CategoryID { get; set; }
        public string CategoryName { get; set; }

        public static List<Category> GetCategories()
        {
            List<Category> lst = new List<Category>();
            lst.Add(new Category() { CategoryID = 1, CategoryName = "Platinum" });
            lst.Add(new Category() { CategoryID = 2, CategoryName = "Dimond" });
            lst.Add(new Category() { CategoryID = 3, CategoryName = "Gold" });

            lst.Add(new Category() { CategoryID =4, CategoryName = "Silver" });
            return lst;
        }
    }
}
