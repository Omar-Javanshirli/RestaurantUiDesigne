using RestaurantUiDesigne.Model;
using RestaurantUiDesigne.Repo;
using RestaurantUiDesigne.UserCantrols;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace RestaurantUiDesigne.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        public FakeRepo ImageRepository { get; set; }
        public ObservableCollection<ImageClass> Images { get; set; }
        private ImageClass image;
        public MainWindow _mainWindow;
        public ImageClass Image
        {
            get { return image; }
            set { image = value; }
        }

        public AppViewModel(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            ImageRepository = new FakeRepo();
            Images = new ObservableCollection<ImageClass>(ImageRepository.GetAllImage());
            int y = 40;
            int x = 0;
            foreach (var item in Images)
            {
                MenuButtonViewUc menuButtonViewModel = new MenuButtonViewUc();
                menuButtonViewModel.Image = item;
                MenuButton menuButton = new MenuButton();
                menuButton.Margin = new Thickness(x, y, 5, 0);
                y += 10;
                menuButton.DataContext = menuButtonViewModel;

                _mainWindow.menuBarCanvas.Children.Add(menuButton);
            }

        }
    }
}
