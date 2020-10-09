using FunitureExample.Data;
using FunitureExample.Models;
using FunitureExample.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FunitureExample.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public Command NavigateToDetailPageCommand { get; set; }
        public ICommand AddCommand => new Command(AddCategory);
        public ICommand DeleteCommand => new Command<Category>(category =>
        {
            DeleteCategory(category);
        });
        //public ICommand CategoryDetail => new Command<Category>(async (category) => await SelectedCategory(category));
        public string Name { get; set; }
        public int Quantity { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<MenuTitle> Menus { get; set; }
        public Command SelectCategoryCommand { get; }
        public double ProductListHeight => (Products.Count + 1) / 2 * 285;

        public MainPageViewModel()
        {
            SelectCategoryCommand = new Command<Category>((category) => ExecuteSelectGroupCommand(category));

        }

        public override void Initialize()
        {
            base.Initialize();
            GetCategories();
            GetProducts();
            GetMenu();
            NavigateToDetailPageCommand = new Command<Product>(async (product) => await ExeccuteNavigateToDetailPageCommand(product));
        }
        
        void GetMenu()
        {
            Menus = new ObservableCollection<MenuTitle>(GetData.GetMenus());
        }

        void GetCategories()
        {
            Categories = new ObservableCollection<Category>(GetData.GetCategories());
        }

        void GetProducts()
        {
            Products = new ObservableCollection<Product>(GetData.GetProducts());
        }

        void AddCategory()
        {
            Category category = new Category();
            category.Name = Name;
            category.Quantity = Quantity;
            Categories.Add(category);
        }

        private void ExecuteSelectGroupCommand(Category category)
        {
            var index = Categories.ToList().FindIndex(p => p.Name == category.Name);

            if(index > -1)
            {
                UnselectedGroupItem();
                Categories[index].Selected = true;
                Categories[index].BackgroundColorCate = "#F4C03E";
            }
        }

        private void UnselectedGroupItem()
        {
            Categories.ForEach((item) =>
            {
                item.Selected = false;
                item.BackgroundColorCate = "#EAEDF6";
            });
        }

        public void DeleteCategory(Category category)
        {
            Categories.Remove(category);
        }

        private async Task ExeccuteNavigateToDetailPageCommand(Product product)
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetailPage(product));
        }
    }
}