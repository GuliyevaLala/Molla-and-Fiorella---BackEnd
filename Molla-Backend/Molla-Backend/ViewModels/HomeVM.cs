

using Molla_Backend.Models;

namespace Molla_Backend.ViewModels {

    public class HomeVM {

        public IEnumerable<Slider> Sliders { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
        
        


    }
}
