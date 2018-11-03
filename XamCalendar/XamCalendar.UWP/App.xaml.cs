using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XamCalendar.UWP
{
    sealed partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            UnhandledException += App_UnhandledException;
        }

        private void App_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            e.Handled = true;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {

            if (!(Window.Current.Content is Frame rootFrame))
            {
                rootFrame = new Frame();

                Rg.Plugins.Popup.Popup.Init();

                Xamarin.Forms.Forms.Init(e);

                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                rootFrame.Navigate(typeof(MainPage), e.Arguments);
            }

            Window.Current.Activate();
        }
    }
}
