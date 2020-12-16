using FacebookWrapper.ObjectModel;

namespace FacebookAppForm
{
    class FacadeEventForm
    {
        FacebookUserUtiles m_FacebookUserUtiles= FacebookUserUtiles.GetInstance;

        public FacadeEventForm()
        {
       
        }

        internal FacebookObjectCollection<Event> FetchNotYetRepliedEvents()
        {
            return m_FacebookUserUtiles.FetchNotYetRepliedEvents();
        }

        internal FacebookObjectCollection<Event> FetchDeclinedEvents()
        {
            return m_FacebookUserUtiles.FetchDeclinedEvents();
        }

        internal FacebookObjectCollection<Event> FetchMaybeEvents()
        {
            return m_FacebookUserUtiles.FetchMaybeEvents();
        }
    }
}
