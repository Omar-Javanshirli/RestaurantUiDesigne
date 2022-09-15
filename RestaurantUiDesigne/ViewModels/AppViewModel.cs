using RestaurantUiDesigne.Model;
using RestaurantUiDesigne.Repo;
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
    public class AppViewModel:BaseViewModel
    {
        public FakeRepo ImageRepository { get; set; }
        public ObservableCollection<ImageClass> Images { get; set; }
        private ImageClass image;
        MainWindow _mainWindow;
        public ImageClass Image
        {
            get { return image; }
            set { image = value; }
        }

        public AppViewModel()
        {
            ImageRepository = new FakeRepo();
            Images = new ObservableCollection<ImageClass>(ImageRepository.GetAllImage());
            Image=new ImageClass();
            MenuButtonViewUc menuButtonViewUc = new MenuButtonViewUc(Image);
            //_mainWindow.menuBarCanvas.Children.Add(menuButtonViewUc);
        }
    }
}
