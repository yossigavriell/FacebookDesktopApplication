using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookAppForm
{
    public partial class AboutMeForm : FacebookGeneralForm
    {
        private FacadeAboutMeForm m_FacadeAboutMeForm = new FacadeAboutMeForm();

        public AboutMeForm()
            :base()
        {
            InitializeComponent();
        }

        public override void InitializeForm()
        {
            userBindingSource.DataSource = m_FacadeAboutMeForm.GetUser();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void birthdayLabel1_Click(object sender, EventArgs e)
        {

        }

        private void AboutMeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
