using RestaurantUiDesigne.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantUiDesigne.UserCantrols
{
    /// <summary>
    /// Interaction logic for CalculationUC.xaml
    /// </summary>
    public partial class CalculationUC : UserControl
    {

        public CalculationUC()
        {
            InitializeComponent();
            var vm = new CalculationViewModel();
            //vm.TotalPriceTb=totalPriceTb;
            //vm.EatNumberTb=eatNumberTb;
            this.DataContext = vm;
        }
    }
}
