using System.Windows;
using System.Windows.Controls;


namespace TeleCompany.Pages
{
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration());
        }
    }
}
