using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class CoordinatorLogin : Window
    {
        public CoordinatorLogin()
        {
            InitializeComponent();
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            var claimPageWindow = new ClaimPage();
            claimPageWindow.Show();
            this.Close();
        }
    }
}