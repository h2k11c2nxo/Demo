using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using PropertyChanged;

namespace FunitureExample.Models
{
   public class Category : BaseModel
    {


        public string Image { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public bool Selected { get; set; }

        
        public string BackgroundColorCate { get; set; }

       
    }
}
