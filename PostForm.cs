using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace FacebookAppForm
{
    public partial class PostForm : FacebookGeneralForm
    {
        private FacadePostForm m_FacadePostForm = new FacadePostForm();
        private bool m_ThreadIsFinish = false;

        private List<Post> Posts { get; set; }

        public PostForm()
            : base()
        {
            InitializeComponent();
            Posts = new List<Post>();
        }

        private void addDataBinding()
        {
            postBindingSource.DataSource = m_FacadePostForm.FetchUserPosts();
        }

        protected override void OnShown(EventArgs e)
        {
            m_FacadePostForm.PostsHandler += dataReady;
            Thread thread = new Thread(() => m_FacadePostForm.FetchPosts());
            thread.Start();
        }

        private void dataReady()
        {
            m_ThreadIsFinish = true;
            Invoke(new Action(addDataBinding));
        }

        private void PostForm_Load(object sender, EventArgs e)
        {

        }

        private void closetButtonPost_Click(object sender, EventArgs e)
        {
            if (m_ThreadIsFinish)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Initalize data...");
            }
        }

        private void writePostButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(m_WritePostTextBox.Text))
            {
                try
                {

                    m_FacadePostForm.WritePost(m_WritePostTextBox.Text);              
                    m_WritePostTextBox.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void getPostCommentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
