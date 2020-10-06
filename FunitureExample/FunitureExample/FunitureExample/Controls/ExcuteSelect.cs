using FunitureExample.Data;
using FunitureExample.Models;
using Java.Lang.Reflect;
using NHibernate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FunitureExample.Controls
{
   public class ExcuteSelect 
    {
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
