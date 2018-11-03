using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace XamCalendar
{
    public partial class App : Application
    {
        public App()
        {
            Log.Listeners.Add(new DelegateLogListener((arg1, arg2) => Debug.WriteLine(arg2)));

            InitializeComponent();

            MainPage = new TestView { };
        }
    }
}
