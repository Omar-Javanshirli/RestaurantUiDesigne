using RestaurantUiDesigne.Command;
using RestaurantUiDesigne.Helper;
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
        public FakeRepo EatRepository { get; set; }
        public ObservableCollection<ImageClass> Images { get; set; }

        public MainWindow _mainWindow;
        public RelayCommand ChangeButtonCommand { get; set; }
        public RelayCommand BuyCommand { get; set; }

        private ImageClass image;
        public ImageClass Image
        {
            get { return image; }
            set { image = value; }
        }

        private string subTotal;

        public string SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        public int GetIndexOfButton(Button button)
        {
            int index = 0;
            var panel=button.Parent as StackPanel;
            foreach (var item in panel.Children)
            {
                if(item is Button bt)
                {
                    if (bt.Name == button.Name)
                    {
                        return index;
                    }
                }
                ++index;
            }
            return -1;
        }

        public void GetEatUc()
        {
            EatRepository=new FakeRepo();
            //var eatUc = new ObservableCollection<Eat>(EatRepository.GetAllEat());

            DataClasses1DataContext dtx = new DataClasses1DataContext();
            var eatUc = from e in dtx.Eats
                        select e;

            foreach (var item in eatUc)
            {
                EatViewModel eatViewModel = new EatViewModel();
                eatViewModel.Eat = item;
                EatUc eatUc1 = new EatUc();
                eatUc1.DataContext=eatViewModel;
                _mainWindow.eatWrapPanel.Children.Add(eatUc1);
            }

        }

        public AppViewModel(MainWindow mainWindow)
        {
            BlobStorage.DownloadImage();
            _mainWindow = mainWindow;
            ImageRepository = new FakeRepo();
            Images = new ObservableCollection<ImageClass>(ImageRepository.GetAllImage());
            int y = 70;
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

            ChangeButtonCommand = new RelayCommand(e =>
            {
                var btn = e as Button;
                var index = GetIndexOfButton(btn);
                _mainWindow.gridCursor.Margin = new Thickness(10 + (89 * index), 0, 0, 0);
            });

            GetEatUc();

            BuyCommand = new RelayCommand((e) =>
            {
                MessageBox.Show("Sccesfully");
            });
        }
    }
}
