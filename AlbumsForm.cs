using FacebookWrapper.ObjectModel;
using System;

namespace FacebookAppForm
{
    public partial class AlbumsForm : FacebookGeneralForm
    {
        private FacadeAlbumsForm m_FacadeAlbumsForm=new FacadeAlbumsForm();
       
        public AlbumsForm()
            :base()
        {
            InitializeComponent();
        }

        public override void InitializeForm()
        {
            albumBindingSource.DataSource = m_FacadeAlbumsForm.FetchUserAlbum();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
                this.Dispose();
        }

        private void albumListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            photoBindingSource.DataSource = (albumBindingSource.Current as Album).Photos;
        }

        private void albumBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void albumBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void AlbumsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
