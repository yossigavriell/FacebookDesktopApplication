namespace FacebookAppForm
{
    partial class AboutMeForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label cityLabel;
            this.m_DetailsGroupBoxEvent = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_EventGroupBox = new System.Windows.Forms.GroupBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.m_CloseButton = new System.Windows.Forms.Button();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            this.m_DetailsGroupBoxEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.m_EventGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(313, 146);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(84, 16);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(313, 192);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(57, 16);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(313, 44);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(102, 16);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(313, 97);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(101, 16);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "Last Name:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(313, 243);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(44, 16);
            cityLabel.TabIndex = 8;
            cityLabel.Text = "City:";
            // 
            // m_DetailsGroupBoxEvent
            // 
            this.m_DetailsGroupBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.m_DetailsGroupBoxEvent.Controls.Add(this.pictureBox1);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_EventGroupBox);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_CloseButton);
            this.m_DetailsGroupBoxEvent.Location = new System.Drawing.Point(126, 155);
            this.m_DetailsGroupBoxEvent.Name = "m_DetailsGroupBoxEvent";
            this.m_DetailsGroupBoxEvent.Size = new System.Drawing.Size(879, 557);
            this.m_DetailsGroupBoxEvent.TabIndex = 8;
            this.m_DetailsGroupBoxEvent.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FacebookAppForm.Properties.Resources.Aboutme;
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // m_EventGroupBox
            // 
            this.m_EventGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.m_EventGroupBox.Controls.Add(this.imageNormalPictureBox);
            this.m_EventGroupBox.Controls.Add(cityLabel);
            this.m_EventGroupBox.Controls.Add(this.cityLabel1);
            this.m_EventGroupBox.Controls.Add(lastNameLabel);
            this.m_EventGroupBox.Controls.Add(this.lastNameLabel1);
            this.m_EventGroupBox.Controls.Add(firstNameLabel);
            this.m_EventGroupBox.Controls.Add(this.firstNameLabel1);
            this.m_EventGroupBox.Controls.Add(emailLabel);
            this.m_EventGroupBox.Controls.Add(this.emailLabel1);
            this.m_EventGroupBox.Controls.Add(birthdayLabel);
            this.m_EventGroupBox.Controls.Add(this.birthdayLabel1);
            this.m_EventGroupBox.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_EventGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_EventGroupBox.Location = new System.Drawing.Point(20, 110);
            this.m_EventGroupBox.Name = "m_EventGroupBox";
            this.m_EventGroupBox.Size = new System.Drawing.Size(835, 370);
            this.m_EventGroupBox.TabIndex = 2;
            this.m_EventGroupBox.TabStop = false;
            this.m_EventGroupBox.Text = "Details";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(29, 44);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(208, 215);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 11;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // cityLabel1
            // 
            this.cityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Hometown.Location.City", true));
            this.cityLabel1.Location = new System.Drawing.Point(450, 243);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(198, 23);
            this.cityLabel1.TabIndex = 9;
            this.cityLabel1.Text = "label1";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameLabel1.Location = new System.Drawing.Point(450, 97);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(198, 23);
            this.lastNameLabel1.TabIndex = 7;
            this.lastNameLabel1.Text = "label1";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameLabel1.Location = new System.Drawing.Point(450, 44);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(207, 23);
            this.firstNameLabel1.TabIndex = 5;
            this.firstNameLabel1.Text = "label1";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(450, 192);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(207, 23);
            this.emailLabel1.TabIndex = 3;
            this.emailLabel1.Text = "label1";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(450, 146);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(198, 23);
            this.birthdayLabel1.TabIndex = 1;
            this.birthdayLabel1.Text = "label1";
            // 
            // m_CloseButton
            // 
            this.m_CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_CloseButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CloseButton.ForeColor = System.Drawing.Color.White;
            this.m_CloseButton.Location = new System.Drawing.Point(691, 500);
            this.m_CloseButton.Name = "m_CloseButton";
            this.m_CloseButton.Size = new System.Drawing.Size(164, 45);
            this.m_CloseButton.TabIndex = 3;
            this.m_CloseButton.Text = "Close";
            this.m_CloseButton.UseVisualStyleBackColor = false;
            this.m_CloseButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AboutMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookAppForm.Properties.Resources.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 746);
            this.Controls.Add(this.m_DetailsGroupBoxEvent);
            this.Name = "AboutMeForm";
            this.Text = "AboutMeForm";
            this.Load += new System.EventHandler(this.AboutMeForm_Load);
            this.m_DetailsGroupBoxEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.m_EventGroupBox.ResumeLayout(false);
            this.m_EventGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox m_DetailsGroupBoxEvent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox m_EventGroupBox;
        private System.Windows.Forms.Button m_CloseButton;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label cityLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label birthdayLabel1;
    }
}