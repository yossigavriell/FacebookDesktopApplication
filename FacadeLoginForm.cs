using System;
using System.Windows.Forms;

namespace FacebookAppForm
{
    class FacadeLoginForm
    {
        FacebookUserUtiles m_FacebookUserUtiles = FacebookUserUtiles.GetInstance;

        public FacadeLoginForm()
        {

        }

        internal void Login()
        {
            try
            {
                m_FacebookUserUtiles.LoginAndInitialize();
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
