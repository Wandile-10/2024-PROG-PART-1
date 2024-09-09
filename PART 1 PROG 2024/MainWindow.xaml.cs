using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetStartedButton_Click(object sender, RoutedEventArgs e)
        {
            var lectureLoginWindow = new LectureLogin();
            lectureLoginWindow.Show();
            this.Close();
        }
    }
}