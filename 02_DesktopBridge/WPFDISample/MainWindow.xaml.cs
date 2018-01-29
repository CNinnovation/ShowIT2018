using DISampleViewModels.ViewModels;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Windows.ApplicationModel.DataTransfer;
using System;
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

        private async void OnShare(object sender, RoutedEventArgs e)
        {
            string protocol = "sampleprotocol";
            Uri uri = new Uri($"{protocol}://");
            var success = await Launcher.LaunchUriAsync(uri);


        }

        private void OnDataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            args.Request.Data.SetText("Hello from WPF");
        }
    }
}
