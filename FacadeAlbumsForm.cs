using FacebookWrapper.ObjectModel;

namespace FacebookAppForm
{
    class FacadeAlbumsForm
    {
        FacebookUserUtiles m_FacebookUserUtiles = FacebookUserUtiles.GetInstance;

        public FacadeAlbumsForm()
        {

        }

        internal FacebookObjectCollection<Album> FetchUserAlbum()
        {
            return m_FacebookUserUtiles.FetchUserAlbum();
        }

        internal Album FetchAlbumByName(string i_AlbumToFetch)
        {
            return m_FacebookUserUtiles.FetchAlbumByName(i_AlbumToFetch);
        }

        internal string FetchPhotoUrl(Album i_CurrAlbum, string i_UrlToShow)
        {
            return m_FacebookUserUtiles.FetchPhotoUrl(i_CurrAlbum, i_UrlToShow);
        }
    }
}
