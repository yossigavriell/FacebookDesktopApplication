namespace FacebookAppForm
{
    partial class EventForm
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
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.m_DetailsGroupBoxEvent = new System.Windows.Forms.GroupBox();
            this.m_EventsComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_EventGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startTimeLabel1 = new System.Windows.Forms.Label();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.endTimeLabel1 = new System.Windows.Forms.Label();
            this.m_OwnerOfEvent = new System.Windows.Forms.Label();
            this.m_CloseButton = new System.Windows.Forms.Button();
            this.m_EventListBox = new System.Windows.Forms.ListBox();
            endTimeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            this.m_DetailsGroupBoxEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.m_EventGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(38, 100);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(85, 16);
            endTimeLabel.TabIndex = 5;
            endTimeLabel.Text = "End Time:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(38, 149);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(82, 16);
            locationLabel.TabIndex = 7;
            locationLabel.Text = "Location:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(38, 51);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(96, 16);
            startTimeLabel.TabIndex = 9;
            startTimeLabel.Text = "Start Time:";
            // 
            // m_DetailsGroupBoxEvent
            // 
            this.m_DetailsGroupBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_EventsComboBox);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.pictureBox1);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_EventGroupBox);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_CloseButton);
            this.m_DetailsGroupBoxEvent.Controls.Add(this.m_EventListBox);
            this.m_DetailsGroupBoxEvent.Location = new System.Drawing.Point(103, 151);
            this.m_DetailsGroupBoxEvent.Name = "m_DetailsGroupBoxEvent";
            this.m_DetailsGroupBoxEvent.Size = new System.Drawing.Size(839, 508);
            this.m_DetailsGroupBoxEvent.TabIndex = 7;
            this.m_DetailsGroupBoxEvent.TabStop = false;
            // 
            // m_EventsComboBox
            // 
            this.m_EventsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_EventsComboBox.FormattingEnabled = true;
            this.m_EventsComboBox.Location = new System.Drawing.Point(20, 110);
            this.m_EventsComboBox.Name = "m_EventsComboBox";
            this.m_EventsComboBox.Size = new System.Drawing.Size(242, 24);
            this.m_EventsComboBox.TabIndex = 8;
            this.m_EventsComboBox.Text = "Select event status";
            this.m_EventsComboBox.SelectedIndexChanged += new System.EventHandler(this.eventsComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FacebookAppForm.Properties.Resources.events;
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
            this.m_EventGroupBox.Controls.Add(this.nameLabel1);
            this.m_EventGroupBox.Controls.Add(startTimeLabel);
            this.m_EventGroupBox.Controls.Add(this.startTimeLabel1);
            this.m_EventGroupBox.Controls.Add(locationLabel);
            this.m_EventGroupBox.Controls.Add(this.locationLabel1);
            this.m_EventGroupBox.Controls.Add(endTimeLabel);
            this.m_EventGroupBox.Controls.Add(this.endTimeLabel1);
            this.m_EventGroupBox.Controls.Add(this.m_OwnerOfEvent);
            this.m_EventGroupBox.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_EventGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_EventGroupBox.Location = new System.Drawing.Point(298, 110);
            this.m_EventGroupBox.Name = "m_EventGroupBox";
            this.m_EventGroupBox.Size = new System.Drawing.Size(508, 308);
            this.m_EventGroupBox.TabIndex = 2;
            this.m_EventGroupBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Owner.Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(138, 194);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 12;
            this.nameLabel1.Text = "None";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // startTimeLabel1
            // 
            this.startTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.startTimeLabel1.Location = new System.Drawing.Point(140, 51);
            this.startTimeLabel1.Name = "startTimeLabel1";
            this.startTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.startTimeLabel1.TabIndex = 10;
            this.startTimeLabel1.Text = "None";
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationLabel1.Location = new System.Drawing.Point(138, 149);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(100, 23);
            this.locationLabel1.TabIndex = 8;
            this.locationLabel1.Text = "None";
            // 
            // endTimeLabel1
            // 
            this.endTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true));
            this.endTimeLabel1.Location = new System.Drawing.Point(138, 100);
            this.endTimeLabel1.Name = "endTimeLabel1";
            this.endTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.endTimeLabel1.TabIndex = 6;
            this.endTimeLabel1.Text = "None";
            // 
            // m_OwnerOfEvent
            // 
            this.m_OwnerOfEvent.AutoSize = true;
            this.m_OwnerOfEvent.Location = new System.Drawing.Point(38, 194);
            this.m_OwnerOfEvent.Name = "m_OwnerOfEvent";
            this.m_OwnerOfEvent.Size = new System.Drawing.Size(79, 16);
            this.m_OwnerOfEvent.TabIndex = 4;
            this.m_OwnerOfEvent.Text = "Owner : ";
            // 
            // m_CloseButton
            // 
            this.m_CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_CloseButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CloseButton.ForeColor = System.Drawing.Color.White;
            this.m_CloseButton.Location = new System.Drawing.Point(642, 445);
            this.m_CloseButton.Name = "m_CloseButton";
            this.m_CloseButton.Size = new System.Drawing.Size(164, 45);
            this.m_CloseButton.TabIndex = 3;
            this.m_CloseButton.Text = "Close";
            this.m_CloseButton.UseVisualStyleBackColor = false;
            this.m_CloseButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // m_EventListBox
            // 
            this.m_EventListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.m_EventListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eventBindingSource, "Name", true));
            this.m_EventListBox.DataSource = this.eventBindingSource;
            this.m_EventListBox.DisplayMember = "Name";
            this.m_EventListBox.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_EventListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_EventListBox.FormattingEnabled = true;
            this.m_EventListBox.ItemHeight = 16;
            this.m_EventListBox.Location = new System.Drawing.Point(20, 142);
            this.m_EventListBox.Name = "m_EventListBox";
            this.m_EventListBox.Size = new System.Drawing.Size(242, 276);
            this.m_EventListBox.TabIndex = 0;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookAppForm.Properties.Resources.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 696);
            this.Controls.Add(this.m_DetailsGroupBoxEvent);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.m_DetailsGroupBoxEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.m_EventGroupBox.ResumeLayout(false);
            this.m_EventGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox m_EventListBox;
        private System.Windows.Forms.GroupBox m_EventGroupBox;
        private System.Windows.Forms.Label m_OwnerOfEvent;
        private System.Windows.Forms.GroupBox m_DetailsGroupBoxEvent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button m_CloseButton;
        private System.Windows.Forms.ComboBox m_EventsComboBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label startTimeLabel1;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.Label endTimeLabel1;
        private System.Windows.Forms.Label nameLabel1;
    }
}