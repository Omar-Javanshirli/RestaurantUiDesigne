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
    public class CalculationViewModel:BaseViewModel
    {
        public Eat Eat { get; set; }

        private TextBox eatNumberTb;

        public TextBox EatNumberTb
        {
            get { return eatNumberTb; }
            set { eatNumberTb = value; OnPropertyChanged(); }
        }

        private TextBlock totalPriceTb;

        public TextBlock TotalPriceTb
        {
            get { return totalPriceTb; }
            set { totalPriceTb = value; OnPropertyChanged(); }
        }

        public CalculationViewModel()
        {

            EatNumberTb.Text = "2";
        }
    }
}
