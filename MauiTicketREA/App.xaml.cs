using Microsoft.Maui.Controls;
namespace MauiTicketREA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}

