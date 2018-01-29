using DISampleViewModels.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using Windows.System;

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

        private async void OnLaunchUWP(object sender, RoutedEventArgs e)
        { 
            string protocol = "showit2018";
            var uri = new Uri($"{protocol}://");
            var success = await Launcher.LaunchUriAsync(uri);
        }
    }
}
