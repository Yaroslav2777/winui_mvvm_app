using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;

namespace winui_mvvm_app1.Views
{
    public sealed partial class AddActivityPage : Page
    {
        public AddActivityPage()
        {
            // InitializeComponent is generated from XAML during build. Ensure the XAML file is included as a Page in the project
            this.InitializeComponent();
            this.DataContext = App.ViewModel; // bind page to the singleton ViewModel
        }

        private void Save_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            App.ViewModel.SaveNewActivity();
        }

        private void Clear_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            App.ViewModel.ClearNewActivity();
        }
    }
}