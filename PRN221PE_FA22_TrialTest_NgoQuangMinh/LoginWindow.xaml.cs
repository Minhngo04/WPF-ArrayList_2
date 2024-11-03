using Candidates_BusinessObject;
using Candidates_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PRN221PE_FA22_TrialTest_NgoQuangMinh
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private IHRAccountService iAccountService;

        public LoginWindow()
        {
            InitializeComponent();
            iAccountService = new HRAccountService();
        }


        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Hraccount hraccount = iAccountService.GetHraccountByEmail(txtEmail.Text.Trim());

            if (hraccount != null && txtPassword.Password.Equals(hraccount.Password))
            {
                int? roleID = hraccount.MemberRole;
                switch (roleID)
                {
                    case 1:
                        this.Hide();
                        CandidateProfileManager candForm = new CandidateProfileManager(roleID);
                        candForm.Show();
                        break;
                    case 2:
                        this.Hide();
                        CandidateProfileManager staffCandidate = new CandidateProfileManager(roleID);
                        staffCandidate.Show();
                        break;
                    case 3:
                        this.Hide();
                        CandidateProfileManager managementCandidate = new CandidateProfileManager(roleID);
                        managementCandidate.Show();
                        break;
                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("Bye bye");
            }
        }
    }
}
