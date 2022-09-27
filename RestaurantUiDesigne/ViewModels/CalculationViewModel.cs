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
    public class CalculationViewModel:BaseViewModel
    {
        public Eat Eat { get; set; }

        private string eatNumberTb;

        public string EatNumberTb
        {
            get { return eatNumberTb; }
            set { eatNumberTb = value; OnPropertyChanged(); }
        }

        private string totalPriceTb;

        public string TotalPriceTb
        {
            get { return totalPriceTb; }
            set { totalPriceTb = value; OnPropertyChanged(); }
        }

        public CalculationViewModel()
        {
            EatNumberTb="3";
        }
    }
}
