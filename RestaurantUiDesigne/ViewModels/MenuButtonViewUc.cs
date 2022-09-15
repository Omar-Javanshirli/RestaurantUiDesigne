using RestaurantUiDesigne.Model;
using RestaurantUiDesigne.Repo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUiDesigne.ViewModels
{
    public class MenuButtonViewUc : BaseViewModel
    {
        public ImageClass image { get; set; }
        public MenuButtonViewUc(ImageClass image)
        {
            this.image = image;
        }
    }
}
