using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppForm
{
    public sealed class  FacebookUserUtiles
    {
        private static readonly object padlock = new object();
        private static FacebookUserUtiles s_Instance = null;

        public static FacebookUserUtiles GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = new FacebookUserUtiles();
                    }
                    return s_Instance;
                }
            }
        }
        public User User { get; private set; }
        private FacebookUserUtiles()
        {  
        }

        internal void LoginAndInitialize()
        {
            LoginResult result = FacebookWrapper.FacebookService.Login("2361638314144643",

                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                User = result.LoggedInUser;
            }
            else
            {
                throw new Exception("Login Faild!");
            }
        }

        public Album FetchAlbumByName(string i_NameOfAlbum)
        {
            Album albumToReturn = null;

            foreach (Album album in User.Albums)
            {
                if (album.Name.Equals(i_NameOfAlbum))
                {
                    albumToReturn = album;
                    break;
                }
            }

            return albumToReturn;
        }

        public List<User> FetchAllUsersAreWasWithMeInSameCheckins()
        {
            List<User> userListSameCheckinsWithMe = new List<User>();
            foreach (Checkin checkins in User.Checkins)
            {
                foreach (User user in checkins.TaggedUsers)
                {
                    userListSameCheckinsWithMe.Add(user);
                }
            }

            return userListSameCheckinsWithMe;
        }

        public List<Photo> FetchAllUsersAreTaggedWithMeInPhoto()
        {
            List<Photo> photosListAreUserTagged = new List<Photo>();
                foreach (Photo photo in User.PhotosTaggedIn)
                {
                    photosListAreUserTagged.Add(photo);
                }

                return photosListAreUserTagged; 
        }

        public FacebookObjectCollection<Event> FetchDeclinedEvents()
        {
            FacebookObjectCollection<Event> declineEvents = new FacebookObjectCollection<Event>();
            foreach (Event events in User.EventsDeclined)
            {
                declineEvents.Add(events);
            }

            return declineEvents;
        }

        public FacebookObjectCollection<Event> FetchMaybeEvents()
        {
            FacebookObjectCollection<Event> maybeEvents = new FacebookObjectCollection<Event>();
            foreach (Event events in User.EventsMaybe)
            {
                maybeEvents.Add(events);
            }

            return maybeEvents;
        }
        public FacebookObjectCollection<Event> FetchNotYetRepliedEvents()
        {
            FacebookObjectCollection<Event> notYetRepliedEvent
                = new FacebookObjectCollection<Event>();
            foreach (Event events in User.EventsDeclined)
            {
                notYetRepliedEvent.Add(events);
            }

            return notYetRepliedEvent;
        }
        public FacebookObjectCollection<Album> FetchUserAlbum()
        {
            return User.Albums;
        }

        public string FetchPhotoProfilePictureUrl()
        {
            return User.PictureNormalURL;
        }

        internal IEnumerable<Photo> FetchUserPhotos(Album i_Album)
        {
            return i_Album.Photos;
        }

        public FacebookObjectCollection<Post> FetchUserPosts()
        {
            return User.Posts;
        }

        internal SortedDictionary<User, int> CalcGeneralFan(SortedDictionary<User, int> i_PhotoLikeCounter, SortedDictionary<User, int> i_PostsLikeCounter)
        {
            foreach (User user in i_PostsLikeCounter.Keys)
            {
                if (i_PhotoLikeCounter.ContainsKey(user))
                {
                    i_PhotoLikeCounter[user] += i_PostsLikeCounter[user];
                }
                else
                {
                    i_PhotoLikeCounter.Add(user, 1);
                }
            }
            return i_PhotoLikeCounter;
        }

        internal SortedDictionary<User, int> CalcPostsLikesDict()
        {
            SortedDictionary<User, int> postsLikeCounter = new SortedDictionary<User, int>();
            foreach (Post post in FetchUserPosts())
            {
                postsLikeCounter = UpdateLikesToDict(post.LikedBy, postsLikeCounter);
            }
            return postsLikeCounter;
        }

        internal SortedDictionary<User, int> CalcPhotosLikesDict()
        {
            SortedDictionary<User, int> photoLikeCounter = new SortedDictionary<User, int>();
            foreach (Album album in FetchUserAlbum())
            {
                foreach (Photo photo in FetchUserPhotos(album))
                {
                    photoLikeCounter = UpdateLikesToDict(photo.LikedBy, photoLikeCounter);
                }
            }
            return photoLikeCounter;
        }

        public Status Post(string i_Post)
        {
            Status status = null;
            try
            {
                status = User.PostStatus(i_Post);
            }
            catch (Exception ex)
            {
                throw new Exception("Post is fail", ex);
            }

            return status;
        }

        internal string FetchPhotoUrl(Album i_CurrAlbum, string i_SelectedPhoto)
        {
            string urlToReturn = string.Empty;
            foreach(Photo photo in i_CurrAlbum.Photos)
            {
                if (photo.Id.Equals(i_SelectedPhoto))
                {
                    urlToReturn = photo.PictureNormalURL;
                    break;
                }
            }
            return urlToReturn;
        }

        public SortedDictionary<User, int> UpdateLikesToDict(FacebookObjectCollection<User> i_UsersToAdd, SortedDictionary<User, int> i_UsersDictToUpdate)
        {
            foreach (User user in i_UsersToAdd)
            {
                if (i_UsersDictToUpdate.ContainsKey(user))
                {
                    i_UsersDictToUpdate[user]++;
                }
                else
                {
                    i_UsersDictToUpdate.Add(user, 1);
                }
            }
            return i_UsersDictToUpdate;
        }
    }
}
