using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class LectureLogin : Window
    {
        public LectureLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Add login logic here
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            var lectureDetailsWindow = new LectureDetails();
            lectureDetailsWindow.Show();
            this.Close();
        }
    }
}