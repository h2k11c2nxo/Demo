using FunitureExample.Data;
using FunitureExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FunitureExample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCategory : ContentView
    {
        public ListCategory()
        {
            InitializeComponent();
            SelectCategoryCommand = new Command<Category>((category) => ExecuteSelectGroupCommand(category));
        }

        public Command SelectCategoryCommand { get; }
        public static readonly BindableProperty BackgroundContainerProperty = BindableProperty.Create
          (
          nameof(BackgroundContainer),
          typeof(Color),
          typeof(ListCategory),
          Color.White,
          BindingMode.TwoWay
          );
        public Color BackgroundContainer
        {
            get => (Color)GetValue(BackgroundContainerProperty);
            set { SetValue(BackgroundContainerProperty, value); }
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == BackgroundContainerProperty.PropertyName)
            {
                container.BackgroundColor = BackgroundContainer;
            }
           

        }


        private void ExecuteSelectGroupCommand(Category category)
        {
            var index = GetData.Categoriess.ToList().FindIndex(p => p.Name == category.Name);

            if (index > -1)
            {
                UnselectedGroupItem();
                GetData.Categoriess[index].Selected = true;
                GetData.Categoriess[index].BackgroundColorCate = "#F4C03E";
            }
        }

        private void UnselectedGroupItem()
        {
            GetData.Categoriess.ForEach((item) =>
            {
                item.Selected = false;
                item.BackgroundColorCate = "#EAEDF6";
            });
        }
    }

}