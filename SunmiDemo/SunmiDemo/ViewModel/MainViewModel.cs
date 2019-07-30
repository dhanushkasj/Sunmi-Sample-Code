using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SunmiDemo.ViewModel
{
    public class MainViewModel
    {
        public ICommand PrintCommand { get; private set; }
        public ICommand ScanCommand { get; private set; }
        public ICommand LFCommand { get; private set; }

        public MainViewModel()
        {
            PrintCommand = new Command(async () => await PrintItem());
            ScanCommand = new Command(async () => await ScanItem());
            LFCommand = new Command(async () => await PrinterCommand());
        }

        async Task ScanItem()
        {
            
            
            //var _navigation = Application.Current.MainPage.Navigation;
            //var _lastPage = _navigation.NavigationStack.LastOrDefault();

            //var NewPage = new cpgScan();
            //await Navigation.PushAsync(NewPage);

            //_navigation.RemovePage(_lastPage);
        }

        async Task PrinterCommand()
        {
            Xamarin.Forms.DependencyService.Register<INativePages>();
            DependencyService.Get<INativePages>().StartActivityInAndroid("LF");
        }

        async Task PrintItem()
        {
            // await Application.Current.MainPage.Navigation.PushModalAsync(new cpgPrint());
            Xamarin.Forms.DependencyService.Register<INativePages>();
            DependencyService.Get<INativePages>().StartActivityInAndroid("Hello Sunmi,\nI am printing some text\n");
        }

    }
}
