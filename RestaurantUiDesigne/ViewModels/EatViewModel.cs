using RestaurantUiDesigne.Command;
using RestaurantUiDesigne.Model;
using RestaurantUiDesigne.UserCantrols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RestaurantUiDesigne.ViewModels
{
    public class EatViewModel : BaseViewModel
    {
        private EatForView eatt;

        public EatForView Eatt
        {
            get { return eatt; }
            set { eatt = value; OnPropertyChanged(); }
        }

        public RelayCommand SelectCommand { get; set; }
        public EatViewModel()
        {
            Eatt = new EatForView();
            SelectCommand = new RelayCommand((e) =>
            {
                var viewModel = new CalculationViewModel();
                var view = new CalculationUC();
                view.DataContext = viewModel;
                viewModel.Eat.ImagePath = Eatt.ImagePath;
                viewModel.Eat.Description = Eatt.Description;
                viewModel.Eat.Price = ((int)Eatt.Price);
                viewModel.EatNumberTb = "1";

                var number = double.Parse(viewModel.EatNumberTb);
                var price = viewModel.Eat.Price;

                //var result = number * price;
                //viewModel.TotalPriceTb = result.ToString();
                App.CalculateWrap.Children.Add(view);
            });
        }
    }
}
