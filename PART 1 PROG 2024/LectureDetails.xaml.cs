using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class LectureDetails : Window
    {
        public LectureDetails()
        {
            InitializeComponent();
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            var coordinatorLoginWindow = new CoordinatorLogin();
            coordinatorLoginWindow.Show();
            this.Close();
        }
    }
}