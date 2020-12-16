using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookAppForm
{
    class FacadeCoronaForm
    {
        FacebookUserUtiles m_FacebookUserUtiles = FacebookUserUtiles.GetInstance;

        public FacadeCoronaForm()
        {

        }

        internal List<Photo> FetchAllUsersAreTaggedWithMeInPhoto()
        {
            return m_FacebookUserUtiles.FetchAllUsersAreTaggedWithMeInPhoto();
        }

        internal List<User> FetchAllUsersAreWasWithMeInSameCheckins()
        {
            return m_FacebookUserUtiles.FetchAllUsersAreWasWithMeInSameCheckins();
        }

        internal FacebookObjectCollection<User> FetchFriends()
        {
            return m_FacebookUserUtiles.User.Friends;
        }
    }
}
