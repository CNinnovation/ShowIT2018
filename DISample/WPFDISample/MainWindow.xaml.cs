using DISampleViewModels.ViewModels;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace WPFDISample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public MainViewModel ViewModel => ApplicationServices.Instance.ServiceProvider.GetService<MainViewModel>();
    }
}
