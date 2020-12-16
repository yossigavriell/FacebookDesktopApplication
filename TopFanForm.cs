using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookAppForm
{
    public partial class TopFanForm : FacebookGeneralForm
    {
        FacadeTopFanForm m_FacadeTopFanForm = new FacadeTopFanForm();
        internal SortedDictionary<User, int> m_PhotoLikeCounter;
        internal SortedDictionary<User, int> m_PostsLikeCounter;
        internal SortedDictionary<User, int> m_GeneralTopFanDict;
        private bool m_AllAges;
        private User.eGender m_genderFilter;
        private bool m_AllGenderSelected;
        private int m_MinAge;
        private int m_MaxAge;

        public TopFanForm()
        {
            InitializeComponent();
        }

        private void m_CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void m_PhotoFanButton_Click(object sender, EventArgs e)
        {
            if (m_PhotoLikeCounter == null)
            {
                m_PhotoLikeCounter = new SortedDictionary<User, int>();
            }
            try
            {
                applyFilters();
                m_PhotoLikeCounter = m_FacadeTopFanForm.CalcPhotosLikesDict();
                foreach (User user in m_PhotoLikeCounter.Keys)
                {
                    if (user.Gender == m_genderFilter || m_AllAges)
                    {
                        int userAge = checkUserAge(user);
                        if ((userAge >= m_MinAge && userAge <= m_MaxAge) || m_AllAges)
                        {
                            m_FansListBox.Invoke(new Action(()=>m_FansListBox.Items.Add(string.Format("{0} {1}", user.Name, m_PhotoLikeCounter[user]))));
                        }
                        else
                        {
                            m_PhotoLikeCounter.Remove(user);
                        }
                    }
                    else
                    {
                        m_PhotoLikeCounter.Remove(user);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_PostFanButton_Click(object sender, EventArgs e)
        {
            if (m_PostsLikeCounter == null)
            {
                m_PostsLikeCounter = new SortedDictionary<User, int>();
            }
            try
            {
                applyFilters();
                m_PostsLikeCounter = m_FacadeTopFanForm.CalcPostsLikesDict();
                foreach (User user in m_PostsLikeCounter.Keys)
                {
                    if (user.Gender == m_genderFilter || m_AllAges)
                    {
                        int userAge = checkUserAge(user);
                        if ((userAge >= m_MinAge && userAge <= m_MaxAge) || m_AllAges)
                        {
                            m_FansListBox.Invoke(new Action(()=>m_FansListBox.Items.Add(string.Format("{0} {1}", user.Name, m_PostsLikeCounter[user]))));
                        }
                        else
                        {
                            m_PostsLikeCounter.Remove(user);
                        }
                    }
                    else
                    {
                        m_PostsLikeCounter.Remove(user);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void applyFilters()
        {
            m_AllAges = m_AllAgesCheckBox.Checked;
            if (!m_AllAges)
            {

                m_MinAge = (int)m_MinAgeUpDown.Value;
                m_MaxAge = (int)m_MaxAgeUpDown.Value;
                if (m_MinAge > m_MaxAge)
                {
                    throw new Exception("Wrong age range");
                }
            }
            if (m_GenderComboBox.SelectedItem != null)
            {
                if (!m_GenderComboBox.SelectedItem.Equals("All"))
                {
                    m_genderFilter = (User.eGender)Enum.Parse(typeof(User.eGender), (string)m_GenderComboBox.SelectedItem);
                }
                else
                {
                    m_AllGenderSelected = true;
                }
            }
            else
            {
                throw new Exception("Please select gender filter from the list!");
            }
        }

        private void m_GeneralFanButton_Click(object sender, EventArgs e)
        {
            if (m_GeneralTopFanDict == null)
            {
                m_GeneralTopFanDict = new SortedDictionary<User, int>();
            }
            try
            {
                applyFilters();
                m_PhotoFanButton.PerformClick();
                m_PostFanButton.PerformClick();
                m_GeneralTopFanDict = m_FacadeTopFanForm.CalcGeneralFan(m_PhotoLikeCounter, m_PostsLikeCounter);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_AllAgesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool checkBoxResult = true;
            if (!m_AllAgesCheckBox.Checked)
            {
                checkBoxResult = true;
            }
            else
            {
                checkBoxResult = false;
            }
            foreach (Control control in m_AgeGroupBox.Controls)
            {
                control.Enabled = checkBoxResult;
            }
        }

        private int checkUserAge(User i_User)
        {
            DateTime today = DateTime.Today;
            DateTime birthday = DateTime.Parse(i_User.Birthday);
            int age = today.Year - birthday.Year;

            return age;

        }
    }
}
