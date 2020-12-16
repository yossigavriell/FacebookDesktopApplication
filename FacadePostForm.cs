using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookAppForm
{
    class FacadePostForm
    {
        FacebookUserUtiles m_FacebookUserUtiles = FacebookUserUtiles.GetInstance;

        private IEnumerable<string> m_Posts;
        private LinkedList<string> m_PostToData = new LinkedList<string>();

        public event Action PostsHandler;

        public FacadePostForm()
        {

        }

        internal FacebookObjectCollection<Post> FetchUserPosts()
        {
            return m_FacebookUserUtiles.FetchUserPosts();
        }

        internal void WritePost(string i_PostToWrite)
        {   
            m_FacebookUserUtiles.Post(i_PostToWrite);
        }

        protected virtual void OnPostsReady()
        {
            if (PostsHandler != null)
            {
                PostsHandler.Invoke();
            }
        }

        public void FetchPosts()
        {
            m_Posts = createEnumerable();
            m_PostToData = new LinkedList<string>(m_Posts);
            OnPostsReady();
        }

        private IEnumerable<string> createEnumerable()
        {
            IEnumerable<Post> posts = m_FacebookUserUtiles.FetchUserPosts();

            foreach (Post post in posts)
            {
                if (post.Message != null)
                {
                    yield return post.Message;
                }
                else if (post.Caption != null)
                {
                    yield return post.Caption;
                }
                else
                {
                    yield return string.Format("[{0}]", post.Type);
                }
            }
        }
    }
}
