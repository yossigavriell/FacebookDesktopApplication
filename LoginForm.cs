using System;
using System.Windows.Forms;

namespace FacebookAppForm
{
    public partial class LoginForm : FacebookGeneralForm
    {
        private FacadeLoginForm m_FacadeLoginForm = new FacadeLoginForm();
        internal static bool s_LoginSec = false;

        public LoginForm()
        {
            InitializeComponent();         
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        } 

        private void loginWithFacebook_Click(object sender, EventArgs e)
        {
            try
            {
                m_FacadeLoginForm.Login();
                s_LoginSec = true;
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
