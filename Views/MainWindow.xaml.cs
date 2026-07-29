using System.Windows;
using RestaurantHR.ViewModels;

namespace RestaurantHR.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // ربط الواجهة بالبيانات الوهمية لتجربة التطبيق
            DataContext = new MainViewModel();
        }
    }
}
