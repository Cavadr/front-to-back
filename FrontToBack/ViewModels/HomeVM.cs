using FrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDesc SliderDesc { get; set; }

        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
