using FunitureExample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Xamarin.Forms;
using static FunitureExample.Models.Product;
using MenuTitle = FunitureExample.Models.MenuTitle;

namespace FunitureExample.Data
{
    public class GetData
    {
        public static ObservableCollection<Product> Productss = new ObservableCollection<Product>();
        public static ObservableCollection<Category> Categoriess = new ObservableCollection<Category>();
        public static ObservableCollection<MenuTitle> Menuss = new ObservableCollection<MenuTitle>();


        public static ObservableCollection<MenuTitle> GetMenus()
        {
            return Menuss = new ObservableCollection<MenuTitle>
            {
                new MenuTitle { Title = "PROFILE" },
                new MenuTitle { Title = "FEED"},
                new MenuTitle { Title = "ACTIVITY" },
                new MenuTitle { Title = "SETTINGS" }
            };
        }
        public static ObservableCollection<Category> GetCategories()
        {

            return Categoriess = new ObservableCollection<Category>()
            {
                new Category()
                {
                    Name = "Chairs",
                    Quantity = 1000,
                    Image = "chair.png",
                        BackgroundColorCate = "#EAEDF6",
                },
                 new Category()
                {
                    Name = "lamp",
                    Quantity = 2340,
                    Image = "lamp.png",
                         BackgroundColorCate = "#EAEDF6",
                },
                  new Category()
                {
                    Name = "Office Chair",
                    Quantity = 1000,
                    Image = "officechair.png",
                         BackgroundColorCate = "#EAEDF6",
                },
                    new Category()
                {
                    Name = "Table",
                    Quantity = 1000,
                    Image = "table.png",
                         BackgroundColorCate = "#EAEDF6",
                }
            };

        }

        public static Product GetProductByName(int id)
        {
            Product item = new Product();
            item = Productss.FirstOrDefault(product => product.Id == id);
            return item;

        }


        public static ObservableCollection<Product> GetProducts()
        {
            return Productss = new ObservableCollection<Product>()
            {
              new Product()
                {
                  Id=1,
                    Name = "Chairs",
                    Rating = 5.5,
                   Review = 463,
                    OldPrice = 8152,
                    NewPrice = 6114,
                    Favorite = true,
                    Discount = 25,
                    Image = "chair22.png",
                    Overview = "Good Chair",
                    CreatedBy = "VietNam",
                    Colors=  new List<ColorProduct>()
                    {

                        new ColorProduct(){ color = "#9AADB0" },
                        new ColorProduct(){ color = "#54889A" },
                        new ColorProduct(){ color = "#3B3B3B", selected = true }
                    }
                },
                 new Product()
                {
                     Id=2,
                    Name = "Chairs",
                    Rating = 5.5,
                   Review = 463,
                    OldPrice = 8152,
                    NewPrice = 6114,
                    Favorite = true,
                    Discount = 25,
                    Image = "chair3.png",
                    Overview = "Good Chair",
                    CreatedBy = "VietNam",
                     Colors = new List<ColorProduct>()
                    {
                        new ColorProduct(){ color = "#9AADB0" },
                        new ColorProduct(){ color = "#54889A", selected = true },
                        new ColorProduct(){ color = "#C5BAA4" },
                        new ColorProduct(){ color = "#EFCBAF" },
                        new ColorProduct(){ color = "#3B3B3B" }
                    },
                },
                  new Product()
                {
                      Id=3,
                     Name = "Chairs",
                    Rating = 5.5,
                   Review = 463,
                    OldPrice = 8152,
                    NewPrice = 6114,
                    Favorite = true,
                    Discount = 25,
                    Image = "chair3.png",
                    Overview = "Good Chair",
                    CreatedBy = "VietNam",
                     Colors = new List<ColorProduct>()
                    {
                        new ColorProduct(){ color = "#9AADB0" },
                        new ColorProduct(){ color = "#54889A", selected = true },
                        new ColorProduct(){ color = "#C5BAA4" },
                        new ColorProduct(){ color = "#EFCBAF" },
                        new ColorProduct(){ color = "#3B3B3B" }
                    },

                },
                    new Product()
                {
                        Id=4,
                     Name = "Chairs",
                    Rating = 5.5,
                   Review = 463,
                    OldPrice = 8152,
                    NewPrice = 6114,
                    Favorite = true,
                    Discount = 25,
                    Image = "chair4.png",
                    Overview = "Good Chair",
                    CreatedBy = "VietNam",
                     Colors = new List<ColorProduct>()
                    {
                        new ColorProduct(){ color = "#9AADB0" },
                        new ColorProduct(){ color = "#54889A", selected = true },
                        new ColorProduct(){ color = "#C5BAA4" },
                        new ColorProduct(){ color = "#EFCBAF" },
                        new ColorProduct(){ color = "#3B3B3B" }
                    },
                },
                        new Product()
                {
                            Id=5,
                     Name = "Chairs",
                    Rating = 5.5,
                   Review = 463,
                    OldPrice = 8152,
                    NewPrice = 6114,
                    Favorite = true,
                    Discount = 25,
                    Image = "chair22.png",
                    Overview = "Good Chair",
                    CreatedBy = "VietNam",
                     Colors = new List<ColorProduct>()
                    {
                        new ColorProduct(){ color = "#9AADB0" },
                        new ColorProduct(){ color = "#54889A", selected = true },
                        new ColorProduct(){ color = "#C5BAA4" },
                        new ColorProduct(){ color = "#EFCBAF" },
                        new ColorProduct(){ color = "#3B3B3B" }
                    },
                },
                                  new Product()
                {
                                      Id=6,
                     Name = "Chairs",
                    Rating = 5.5,
                   Review = 463,
                    OldPrice = 8152,
                    NewPrice = 6114,
                    Favorite = true,
                    Discount = 25,
                    Image = "chair3.png",
                    Overview = "Good Chair",
                    CreatedBy = "VietNam",
                     Colors = new List<ColorProduct>()
                    {
                        new ColorProduct(){ color = "#9AADB0" },
                        new ColorProduct(){ color = "#54889A", selected = true },
                        new ColorProduct(){ color = "#C5BAA4" },
                        new ColorProduct(){ color = "#EFCBAF" },
                        new ColorProduct(){ color = "#3B3B3B" }
                    },
                },

            };

        }
    }
}
