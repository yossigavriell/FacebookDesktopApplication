using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookAppForm
{
    class FacadeTopFanForm
    {
        FacebookUserUtiles m_FacebookUserUtiles = FacebookUserUtiles.GetInstance;

        public FacadeTopFanForm()
        {

        }

        internal SortedDictionary<User, int> CalcPhotosLikesDict()
        {
            return m_FacebookUserUtiles.CalcPhotosLikesDict();
        }

        internal SortedDictionary<User, int> CalcPostsLikesDict()
        {
            return m_FacebookUserUtiles.CalcPostsLikesDict();
        }

        internal SortedDictionary<User, int> CalcGeneralFan(SortedDictionary<User, int> i_PhotoLikeCounter, SortedDictionary<User, int> i_PostsLikeCounter)
        {
            return m_FacebookUserUtiles.CalcGeneralFan(i_PhotoLikeCounter, i_PostsLikeCounter);
        }
    }
}
