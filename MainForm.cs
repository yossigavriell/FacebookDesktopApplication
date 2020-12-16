using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace FacebookAppForm
{
    public partial class MainForm : FacebookGeneralForm
    {
        FacadeMainForm m_FacadeMainForm = new FacadeMainForm();
        private const string coverPhotoHebrew = "תמונות נושא";
        private const string coverPhotoEnglish = "Cover Photos";
        public MainForm()
        {         
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            if (!LoginForm.s_LoginSec)
            {
                changeForm(typeof(LoginForm));
                if (LoginForm.s_LoginSec)
                {
                    Thread threadBasicInfo = new Thread(() =>
                    {

                        loadBasicDetails();

                    });
                    threadBasicInfo.Start();
                }
                else
                {
                    this.Dispose();
                }
            }
        }

        private void loadBasicDetails()
        {
            profilePicture.LoadAsync(m_FacadeMainForm.FetchProfilePicture());
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, profilePicture.Width - 3, profilePicture.Height - 3);
            Region rg = new Region(gp);
            profilePicture.Invoke(new Action(()=>profilePicture.Region = rg));

            try
            {
                if (m_FacadeMainForm.FetchCoverPhoto(coverPhotoHebrew) != null)
                {
                    Album album = m_FacadeMainForm.FetchCoverPhoto(coverPhotoHebrew);
                    m_CoverPhoto.LoadAsync(album.Photos[0].PictureNormalURL);
                }
                else if (m_FacadeMainForm.FetchCoverPhoto(coverPhotoEnglish) != null)
                {
                    Album album = m_FacadeMainForm.FetchCoverPhoto(coverPhotoEnglish);
                    m_CoverPhoto.LoadAsync(album.Photos[0].PictureNormalURL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                foreach (User friend in m_FacadeMainForm.FetchFriends())
                {
                    m_FriendListBox.Invoke(new Action(() => m_FriendListBox.Items.Add(friend.Name)));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load, please check app access permissions");
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
            
        private void changeForm(Type i_AppForm)
        { 
            FacebookGeneralForm facebookGeneralForm = FactoryFacebookForm.CreateInstance(i_AppForm);
            if(facebookGeneralForm != null)
                {
                facebookGeneralForm.InitializeForm();
                this.Visible = false;
                facebookGeneralForm.StartPosition = FormStartPosition.CenterParent;
                facebookGeneralForm.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Upload Form EEROR!");
            }

        }

        private void postButton_Click(object sender, EventArgs e)
        {
            changeForm(typeof(PostForm));
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            changeForm(typeof(EventForm));
        }

        private void albumsButton_Click(object sender, EventArgs e)
        {       
            changeForm(typeof(AlbumsForm));  
        }

        private void aboutMeButton_Click(object sender, EventArgs e)
        {
            changeForm(typeof(AboutMeForm));
        }


        private void coronaFeature_Click(object sender, EventArgs e)
        {
            changeForm(typeof(CoronaForm));
        }

        private void topFanFeruteButton_Click(object sender, EventArgs e)
        {
            changeForm(typeof(TopFanForm));
        }

        private void friendListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string friendName = (string)m_FriendListBox.SelectedItem;

            foreach (User user in m_FacadeMainForm.FetchFriends())
            {
                if (user.Name.Equals(friendName))
                {
                    m_PictureBoxFriend.LoadAsync(user.PictureNormalURL);
                }
            }
        }
    }
}
