using FacebookWrapper.ObjectModel;

namespace FacebookAppForm
{
    class FacadeAboutMeForm
    {
        FacebookUserUtiles m_FacebookUserUtiles = FacebookUserUtiles.GetInstance;

        public FacadeAboutMeForm()
        {

        }

        internal User GetUser()
        {
            return m_FacebookUserUtiles.User;
        }
    }
}
