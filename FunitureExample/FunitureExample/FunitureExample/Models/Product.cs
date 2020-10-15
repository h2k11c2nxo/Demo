using System;
using System.Collections.Generic;
using System.Text;

namespace FunitureExample.Models
{
    public class Product : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int Review { get; set; }
        public double OldPrice { get; set; }
        public double NewPrice { get; set; }
        public bool Favorite { get; set; }
        public double Discount { get; set; }
        public string Image { get; set; }
        public string CreatedBy { get; set; }
        public string Overview { get; set; }


        public List<ColorProduct> Colors { get; set; }

        public class ColorProduct
        {
            public string  color { get; set; }
            public bool selected { get; set; }
        }
    }
}
