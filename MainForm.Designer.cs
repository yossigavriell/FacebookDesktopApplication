namespace FacebookAppForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_CoverPhoto = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.m_PostButton = new System.Windows.Forms.Button();
            this.m_EventButton = new System.Windows.Forms.Button();
            this.m_AlbumsButton = new System.Windows.Forms.Button();
            this.m_AboutMeButton = new System.Windows.Forms.Button();
            this.m_FriendListBox = new System.Windows.Forms.ListBox();
            this.m_StandardFeaturesGroupBox = new System.Windows.Forms.GroupBox();
            this.m_NewFeaturesGroupBox = new System.Windows.Forms.GroupBox();
            this.m_TopFanFeruteButton = new System.Windows.Forms.Button();
            this.m_CoronaReportButton = new System.Windows.Forms.Button();
            this.m_FriendListGroupBox = new System.Windows.Forms.GroupBox();
            this.m_PictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.m_TotalMainGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.m_StandardFeaturesGroupBox.SuspendLayout();
            this.m_NewFeaturesGroupBox.SuspendLayout();
            this.m_FriendListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFriend)).BeginInit();
            this.m_TotalMainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_CoverPhoto
            // 
            this.m_CoverPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_CoverPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_CoverPhoto.Location = new System.Drawing.Point(14, 136);
            this.m_CoverPhoto.Name = "m_CoverPhoto";
            this.m_CoverPhoto.Size = new System.Drawing.Size(1152, 187);
            this.m_CoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_CoverPhoto.TabIndex = 1;
            this.m_CoverPhoto.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePicture.Location = new System.Drawing.Point(67, 152);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(179, 153);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // m_PostButton
            // 
            this.m_PostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_PostButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_PostButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_PostButton.Location = new System.Drawing.Point(53, 116);
            this.m_PostButton.Name = "m_PostButton";
            this.m_PostButton.Size = new System.Drawing.Size(126, 41);
            this.m_PostButton.TabIndex = 3;
            this.m_PostButton.Text = "Posts";
            this.m_PostButton.UseVisualStyleBackColor = false;
            this.m_PostButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // m_EventButton
            // 
            this.m_EventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_EventButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_EventButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_EventButton.Location = new System.Drawing.Point(53, 228);
            this.m_EventButton.Name = "m_EventButton";
            this.m_EventButton.Size = new System.Drawing.Size(126, 41);
            this.m_EventButton.TabIndex = 4;
            this.m_EventButton.Text = "Events";
            this.m_EventButton.UseVisualStyleBackColor = false;
            this.m_EventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // m_AlbumsButton
            // 
            this.m_AlbumsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_AlbumsButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_AlbumsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_AlbumsButton.Location = new System.Drawing.Point(53, 174);
            this.m_AlbumsButton.Name = "m_AlbumsButton";
            this.m_AlbumsButton.Size = new System.Drawing.Size(126, 41);
            this.m_AlbumsButton.TabIndex = 5;
            this.m_AlbumsButton.Text = "Albums";
            this.m_AlbumsButton.UseVisualStyleBackColor = false;
            this.m_AlbumsButton.Click += new System.EventHandler(this.albumsButton_Click);
            // 
            // m_AboutMeButton
            // 
            this.m_AboutMeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_AboutMeButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_AboutMeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_AboutMeButton.Location = new System.Drawing.Point(53, 58);
            this.m_AboutMeButton.Name = "m_AboutMeButton";
            this.m_AboutMeButton.Size = new System.Drawing.Size(126, 41);
            this.m_AboutMeButton.TabIndex = 6;
            this.m_AboutMeButton.Text = "About Me";
            this.m_AboutMeButton.UseVisualStyleBackColor = false;
            this.m_AboutMeButton.Click += new System.EventHandler(this.aboutMeButton_Click);
            // 
            // m_FriendListBox
            // 
            this.m_FriendListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_FriendListBox.BackColor = System.Drawing.Color.White;
            this.m_FriendListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_FriendListBox.FormattingEnabled = true;
            this.m_FriendListBox.ItemHeight = 16;
            this.m_FriendListBox.Location = new System.Drawing.Point(40, 41);
            this.m_FriendListBox.Name = "m_FriendListBox";
            this.m_FriendListBox.Size = new System.Drawing.Size(163, 132);
            this.m_FriendListBox.TabIndex = 7;
            this.m_FriendListBox.SelectedValueChanged += new System.EventHandler(this.friendListBox_SelectedValueChanged);
            // 
            // m_StandardFeaturesGroupBox
            // 
            this.m_StandardFeaturesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.m_StandardFeaturesGroupBox.Controls.Add(this.m_PostButton);
            this.m_StandardFeaturesGroupBox.Controls.Add(this.m_EventButton);
            this.m_StandardFeaturesGroupBox.Controls.Add(this.m_AlbumsButton);
            this.m_StandardFeaturesGroupBox.Controls.Add(this.m_AboutMeButton);
            this.m_StandardFeaturesGroupBox.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_StandardFeaturesGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_StandardFeaturesGroupBox.Location = new System.Drawing.Point(37, 25);
            this.m_StandardFeaturesGroupBox.Name = "m_StandardFeaturesGroupBox";
            this.m_StandardFeaturesGroupBox.Size = new System.Drawing.Size(236, 302);
            this.m_StandardFeaturesGroupBox.TabIndex = 11;
            this.m_StandardFeaturesGroupBox.TabStop = false;
            this.m_StandardFeaturesGroupBox.Text = "Standard Features";
            // 
            // m_NewFeaturesGroupBox
            // 
            this.m_NewFeaturesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_NewFeaturesGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_NewFeaturesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.m_NewFeaturesGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_NewFeaturesGroupBox.Controls.Add(this.m_TopFanFeruteButton);
            this.m_NewFeaturesGroupBox.Controls.Add(this.m_CoronaReportButton);
            this.m_NewFeaturesGroupBox.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_NewFeaturesGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_NewFeaturesGroupBox.Location = new System.Drawing.Point(420, 25);
            this.m_NewFeaturesGroupBox.Name = "m_NewFeaturesGroupBox";
            this.m_NewFeaturesGroupBox.Size = new System.Drawing.Size(236, 302);
            this.m_NewFeaturesGroupBox.TabIndex = 12;
            this.m_NewFeaturesGroupBox.TabStop = false;
            this.m_NewFeaturesGroupBox.Text = "New Features";
            // 
            // m_TopFanFeruteButton
            // 
            this.m_TopFanFeruteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TopFanFeruteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_TopFanFeruteButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_TopFanFeruteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_TopFanFeruteButton.Location = new System.Drawing.Point(52, 91);
            this.m_TopFanFeruteButton.Name = "m_TopFanFeruteButton";
            this.m_TopFanFeruteButton.Size = new System.Drawing.Size(125, 55);
            this.m_TopFanFeruteButton.TabIndex = 0;
            this.m_TopFanFeruteButton.Text = "Top Fan";
            this.m_TopFanFeruteButton.UseVisualStyleBackColor = false;
            this.m_TopFanFeruteButton.Click += new System.EventHandler(this.topFanFeruteButton_Click);
            // 
            // m_CoronaReportButton
            // 
            this.m_CoronaReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_CoronaReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_CoronaReportButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CoronaReportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_CoronaReportButton.Location = new System.Drawing.Point(52, 160);
            this.m_CoronaReportButton.Name = "m_CoronaReportButton";
            this.m_CoronaReportButton.Size = new System.Drawing.Size(126, 55);
            this.m_CoronaReportButton.TabIndex = 1;
            this.m_CoronaReportButton.Text = "Covid-19 Report";
            this.m_CoronaReportButton.UseVisualStyleBackColor = false;
            this.m_CoronaReportButton.Click += new System.EventHandler(this.coronaFeature_Click);
            // 
            // m_FriendListGroupBox
            // 
            this.m_FriendListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_FriendListGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_FriendListGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.m_FriendListGroupBox.Controls.Add(this.m_PictureBoxFriend);
            this.m_FriendListGroupBox.Controls.Add(this.m_FriendListBox);
            this.m_FriendListGroupBox.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_FriendListGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_FriendListGroupBox.Location = new System.Drawing.Point(809, 25);
            this.m_FriendListGroupBox.Name = "m_FriendListGroupBox";
            this.m_FriendListGroupBox.Size = new System.Drawing.Size(236, 302);
            this.m_FriendListGroupBox.TabIndex = 13;
            this.m_FriendListGroupBox.TabStop = false;
            this.m_FriendListGroupBox.Text = "Friends";
            // 
            // m_PictureBoxFriend
            // 
            this.m_PictureBoxFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_PictureBoxFriend.Location = new System.Drawing.Point(40, 189);
            this.m_PictureBoxFriend.Name = "m_PictureBoxFriend";
            this.m_PictureBoxFriend.Size = new System.Drawing.Size(163, 97);
            this.m_PictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxFriend.TabIndex = 8;
            this.m_PictureBoxFriend.TabStop = false;
            // 
            // m_TotalMainGroupBox
            // 
            this.m_TotalMainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TotalMainGroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_TotalMainGroupBox.Controls.Add(this.m_StandardFeaturesGroupBox);
            this.m_TotalMainGroupBox.Controls.Add(this.m_FriendListGroupBox);
            this.m_TotalMainGroupBox.Controls.Add(this.m_NewFeaturesGroupBox);
            this.m_TotalMainGroupBox.Location = new System.Drawing.Point(67, 360);
            this.m_TotalMainGroupBox.Name = "m_TotalMainGroupBox";
            this.m_TotalMainGroupBox.Size = new System.Drawing.Size(1073, 345);
            this.m_TotalMainGroupBox.TabIndex = 14;
            this.m_TotalMainGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookAppForm.Properties.Resources.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 744);
            this.Controls.Add(this.m_TotalMainGroupBox);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.m_CoverPhoto);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.m_StandardFeaturesGroupBox.ResumeLayout(false);
            this.m_NewFeaturesGroupBox.ResumeLayout(false);
            this.m_FriendListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFriend)).EndInit();
            this.m_TotalMainGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_CoverPhoto;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button m_PostButton;
        private System.Windows.Forms.Button m_EventButton;
        private System.Windows.Forms.Button m_AlbumsButton;
        private System.Windows.Forms.Button m_AboutMeButton;
        private System.Windows.Forms.ListBox m_FriendListBox;
        private System.Windows.Forms.GroupBox m_StandardFeaturesGroupBox;
        private System.Windows.Forms.GroupBox m_NewFeaturesGroupBox;
        private System.Windows.Forms.Button m_CoronaReportButton;
        private System.Windows.Forms.Button m_TopFanFeruteButton;
        private System.Windows.Forms.GroupBox m_FriendListGroupBox;
        private System.Windows.Forms.GroupBox m_TotalMainGroupBox;
        private System.Windows.Forms.PictureBox m_PictureBoxFriend;
    }
}