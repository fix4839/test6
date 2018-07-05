using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace test4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MonthClass monthClass = new MonthClass();

            NoteClass noteClass = new NoteClass();

            DateTime currDate = DateTime.Now.Date;
            string month = (currDate.ToString("MM/dd/yyyy HH:mm")).Substring(0, 2);
            int monthInt;
            int.TryParse(month, out monthInt);

            MainPage = new NavigationPage(new MonthPage(monthInt, monthClass, noteClass));

        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
