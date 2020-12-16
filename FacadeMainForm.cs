using FacebookWrapper.ObjectModel;

namespace FacebookAppForm
{
    class FacadeMainForm
    {
        FacebookUserUtiles m_FacebookUserUtiles = FacebookUserUtiles.GetInstance;

        public FacadeMainForm()
        {

        }

        internal string FetchProfilePicture()
        {
            return m_FacebookUserUtiles.FetchPhotoProfilePictureUrl();
        }

        internal Album FetchCoverPhoto(string i_coverPhotoHebrew)
        {
            return m_FacebookUserUtiles.FetchAlbumByName(i_coverPhotoHebrew);
        }

        internal FacebookObjectCollection<User> FetchFriends()
        {
            return m_FacebookUserUtiles.User.Friends;
        }
    }
}
