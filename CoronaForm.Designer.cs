namespace FacebookAppForm
{
    partial class CoronaForm
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
            this.m_DetailsGroupBoxEvent = new System.Windows.Forms.GroupBox();
            this.m_MoveToList = new System.Windows.Forms.Button();
            this.m_ListBoxCoronaSend = new System.Windows.Forms.ListBox();
            this.m_CheckListBoxFriendOfCovid = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_EventGroupBox = new System.Windows.Forms.GroupBox();
            this.m_ReportButton = new System.Windows.Forms.Button();
            this.m_FriendShowReportButton = new System.Windows.Forms.Button();
            this.m_CloseButton = new System.Windows.Forms.Button();
            this.m_DetailsGroupBoxEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.m_EventGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_DetailsGroupBoxEvent
            // 
            this.m_DetailsGroupBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_MoveToList);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_ListBoxCoronaSend);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_CheckListBoxFriendOfCovid);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.pictureBox1);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_EventGroupBox);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_CloseButton);
            this.m_DetailsGroupBoxEvent.Location = new System.Drawing.Point(103, 151);
            this.m_DetailsGroupBoxEvent.Name = "m_DetailsGroupBoxEvent";
            this.m_DetailsGroupBoxEvent.Size = new System.Drawing.Size(802, 508);
            this.m_DetailsGroupBoxEvent.TabIndex = 8;
            this.m_DetailsGroupBoxEvent.TabStop = false;
            // 
            // m_MoveToList
            // 
            this.m_MoveToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_MoveToList.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_MoveToList.ForeColor = System.Drawing.Color.White;
            this.m_MoveToList.Location = new System.Drawing.Point(279, 168);
            this.m_MoveToList.Name = "m_MoveToList";
            this.m_MoveToList.Size = new System.Drawing.Size(242, 70);
            this.m_MoveToList.TabIndex = 3;
            this.m_MoveToList.Text = "Move To Report Send List";
            this.m_MoveToList.UseVisualStyleBackColor = false;
            this.m_MoveToList.Click += new System.EventHandler(this.moveToList_Click);
            // 
            // m_ListBoxCoronaSend
            // 
            this.m_ListBoxCoronaSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_ListBoxCoronaSend.FormattingEnabled = true;
            this.m_ListBoxCoronaSend.ItemHeight = 16;
            this.m_ListBoxCoronaSend.Location = new System.Drawing.Point(553, 100);
            this.m_ListBoxCoronaSend.Name = "m_ListBoxCoronaSend";
            this.m_ListBoxCoronaSend.Size = new System.Drawing.Size(220, 196);
            this.m_ListBoxCoronaSend.TabIndex = 9;
            // 
            // m_CheckListBoxFriendOfCovid
            // 
            this.m_CheckListBoxFriendOfCovid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.m_CheckListBoxFriendOfCovid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_CheckListBoxFriendOfCovid.FormattingEnabled = true;
            this.m_CheckListBoxFriendOfCovid.Location = new System.Drawing.Point(29, 105);
            this.m_CheckListBoxFriendOfCovid.Name = "m_CheckListBoxFriendOfCovid";
            this.m_CheckListBoxFriendOfCovid.Size = new System.Drawing.Size(220, 191);
            this.m_CheckListBoxFriendOfCovid.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FacebookAppForm.Properties.Resources.covid;
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // m_EventGroupBox
            // 
            this.m_EventGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.m_EventGroupBox.Controls.Add(this.m_ReportButton);
            this.m_EventGroupBox.Controls.Add(this.m_FriendShowReportButton);
            this.m_EventGroupBox.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_EventGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_EventGroupBox.Location = new System.Drawing.Point(29, 318);
            this.m_EventGroupBox.Name = "m_EventGroupBox";
            this.m_EventGroupBox.Size = new System.Drawing.Size(744, 110);
            this.m_EventGroupBox.TabIndex = 2;
            this.m_EventGroupBox.TabStop = false;
            this.m_EventGroupBox.Text = "Report  options";
            // 
            // m_ReportButton
            // 
            this.m_ReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_ReportButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ReportButton.ForeColor = System.Drawing.Color.White;
            this.m_ReportButton.Location = new System.Drawing.Point(416, 23);
            this.m_ReportButton.Name = "m_ReportButton";
            this.m_ReportButton.Size = new System.Drawing.Size(214, 81);
            this.m_ReportButton.TabIndex = 2;
            this.m_ReportButton.Text = "Report your friend";
            this.m_ReportButton.UseVisualStyleBackColor = false;
            this.m_ReportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // m_FriendShowReportButton
            // 
            this.m_FriendShowReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_FriendShowReportButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_FriendShowReportButton.ForeColor = System.Drawing.Color.White;
            this.m_FriendShowReportButton.Location = new System.Drawing.Point(111, 23);
            this.m_FriendShowReportButton.Name = "m_FriendShowReportButton";
            this.m_FriendShowReportButton.Size = new System.Drawing.Size(214, 81);
            this.m_FriendShowReportButton.TabIndex = 1;
            this.m_FriendShowReportButton.Text = "Show me all the friends who have been around me for the past two weeks";
            this.m_FriendShowReportButton.UseVisualStyleBackColor = false;
            this.m_FriendShowReportButton.Click += new System.EventHandler(this.friendShowReportButton_Click);
            // 
            // m_CloseButton
            // 
            this.m_CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_CloseButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CloseButton.ForeColor = System.Drawing.Color.White;
            this.m_CloseButton.Location = new System.Drawing.Point(621, 445);
            this.m_CloseButton.Name = "m_CloseButton";
            this.m_CloseButton.Size = new System.Drawing.Size(164, 45);
            this.m_CloseButton.TabIndex = 3;
            this.m_CloseButton.Text = "Close";
            this.m_CloseButton.UseVisualStyleBackColor = false;
            this.m_CloseButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CoronaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookAppForm.Properties.Resources.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 696);
            this.Controls.Add(this.m_DetailsGroupBoxEvent);
            this.Name = "CoronaForm";
            this.Text = "CoronaForm";
            this.Load += new System.EventHandler(this.CoronaForm_Load);
            this.m_DetailsGroupBoxEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.m_EventGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox m_DetailsGroupBoxEvent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox m_EventGroupBox;
        private System.Windows.Forms.Button m_CloseButton;
        private System.Windows.Forms.Button m_FriendShowReportButton;
        private System.Windows.Forms.CheckedListBox m_CheckListBoxFriendOfCovid;
        private System.Windows.Forms.Button m_ReportButton;
        private System.Windows.Forms.Button m_MoveToList;
        private System.Windows.Forms.ListBox m_ListBoxCoronaSend;
    }
}