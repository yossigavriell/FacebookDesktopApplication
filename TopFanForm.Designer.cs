namespace FacebookAppForm
{
    partial class TopFanForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.m_AgeGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_MaxAgeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.m_MinAgeUpDown = new System.Windows.Forms.NumericUpDown();
            this.m_GenderComboBox = new System.Windows.Forms.ComboBox();
            this.m_AllAgesCheckBox = new System.Windows.Forms.CheckBox();
            this.m_PostFanButton = new System.Windows.Forms.Button();
            this.m_PhotoFanButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_CloseButton = new System.Windows.Forms.Button();
            this.m_GeneralFanButton = new System.Windows.Forms.Button();
            this.m_FansListBox = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.mFilterGroupBox.SuspendLayout();
            this.m_AgeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MaxAgeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MinAgeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.groupBox2.Controls.Add(this.mFilterGroupBox);
            this.groupBox2.Controls.Add(this.m_PostFanButton);
            this.groupBox2.Controls.Add(this.m_PhotoFanButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.m_CloseButton);
            this.groupBox2.Controls.Add(this.m_GeneralFanButton);
            this.groupBox2.Controls.Add(this.m_FansListBox);
            this.groupBox2.Location = new System.Drawing.Point(103, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 508);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // mFilterGroupBox
            // 
            this.mFilterGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.mFilterGroupBox.Controls.Add(this.m_AgeGroupBox);
            this.mFilterGroupBox.Controls.Add(this.m_GenderComboBox);
            this.mFilterGroupBox.Controls.Add(this.m_AllAgesCheckBox);
            this.mFilterGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mFilterGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.mFilterGroupBox.Location = new System.Drawing.Point(36, 305);
            this.mFilterGroupBox.Name = "mFilterGroupBox";
            this.mFilterGroupBox.Size = new System.Drawing.Size(375, 146);
            this.mFilterGroupBox.TabIndex = 16;
            this.mFilterGroupBox.TabStop = false;
            this.mFilterGroupBox.Text = "Filters";
            // 
            // m_AgeGroupBox
            // 
            this.m_AgeGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.m_AgeGroupBox.Controls.Add(this.label4);
            this.m_AgeGroupBox.Controls.Add(this.m_MaxAgeUpDown);
            this.m_AgeGroupBox.Controls.Add(this.label3);
            this.m_AgeGroupBox.Controls.Add(this.m_MinAgeUpDown);
            this.m_AgeGroupBox.ForeColor = System.Drawing.Color.White;
            this.m_AgeGroupBox.Location = new System.Drawing.Point(74, 56);
            this.m_AgeGroupBox.Name = "m_AgeGroupBox";
            this.m_AgeGroupBox.Size = new System.Drawing.Size(224, 47);
            this.m_AgeGroupBox.TabIndex = 21;
            this.m_AgeGroupBox.TabStop = false;
            this.m_AgeGroupBox.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Aharoni", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(141, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 10);
            this.label4.TabIndex = 20;
            this.label4.Text = "To:";
            // 
            // m_MaxAgeUpDown
            // 
            this.m_MaxAgeUpDown.Enabled = false;
            this.m_MaxAgeUpDown.Location = new System.Drawing.Point(169, 13);
            this.m_MaxAgeUpDown.Name = "m_MaxAgeUpDown";
            this.m_MaxAgeUpDown.Size = new System.Drawing.Size(49, 22);
            this.m_MaxAgeUpDown.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Aharoni", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 10);
            this.label3.TabIndex = 19;
            this.label3.Text = "From:";
            // 
            // m_MinAgeUpDown
            // 
            this.m_MinAgeUpDown.Enabled = false;
            this.m_MinAgeUpDown.Location = new System.Drawing.Point(86, 13);
            this.m_MinAgeUpDown.Name = "m_MinAgeUpDown";
            this.m_MinAgeUpDown.Size = new System.Drawing.Size(49, 22);
            this.m_MinAgeUpDown.TabIndex = 15;
            // 
            // m_GenderComboBox
            // 
            this.m_GenderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.m_GenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_GenderComboBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.m_GenderComboBox.FormattingEnabled = true;
            this.m_GenderComboBox.Items.AddRange(new object[] {
            "female",
            "male",
            "All"});
            this.m_GenderComboBox.Location = new System.Drawing.Point(74, 21);
            this.m_GenderComboBox.Name = "m_GenderComboBox";
            this.m_GenderComboBox.Size = new System.Drawing.Size(225, 24);
            this.m_GenderComboBox.TabIndex = 14;
            this.m_GenderComboBox.Text = "Select Gender";
            // 
            // m_AllAgesCheckBox
            // 
            this.m_AllAgesCheckBox.AutoSize = true;
            this.m_AllAgesCheckBox.Checked = true;
            this.m_AllAgesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_AllAgesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_AllAgesCheckBox.Location = new System.Drawing.Point(124, 109);
            this.m_AllAgesCheckBox.Name = "m_AllAgesCheckBox";
            this.m_AllAgesCheckBox.Size = new System.Drawing.Size(112, 17);
            this.m_AllAgesCheckBox.TabIndex = 18;
            this.m_AllAgesCheckBox.Text = "Select all ages";
            this.m_AllAgesCheckBox.UseVisualStyleBackColor = true;
            this.m_AllAgesCheckBox.CheckedChanged += new System.EventHandler(this.m_AllAgesCheckBox_CheckedChanged);
            // 
            // m_PostFanButton
            // 
            this.m_PostFanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_PostFanButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PostFanButton.ForeColor = System.Drawing.Color.White;
            this.m_PostFanButton.Location = new System.Drawing.Point(247, 160);
            this.m_PostFanButton.Name = "m_PostFanButton";
            this.m_PostFanButton.Size = new System.Drawing.Size(164, 45);
            this.m_PostFanButton.TabIndex = 13;
            this.m_PostFanButton.Text = "Your Posts Fan";
            this.m_PostFanButton.UseVisualStyleBackColor = false;
            this.m_PostFanButton.Click += new System.EventHandler(this.m_PostFanButton_Click);
            // 
            // m_PhotoFanButton
            // 
            this.m_PhotoFanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_PhotoFanButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PhotoFanButton.ForeColor = System.Drawing.Color.White;
            this.m_PhotoFanButton.Location = new System.Drawing.Point(36, 160);
            this.m_PhotoFanButton.Name = "m_PhotoFanButton";
            this.m_PhotoFanButton.Size = new System.Drawing.Size(164, 45);
            this.m_PhotoFanButton.TabIndex = 12;
            this.m_PhotoFanButton.Text = "Your Photos Fan";
            this.m_PhotoFanButton.UseVisualStyleBackColor = false;
            this.m_PhotoFanButton.Click += new System.EventHandler(this.m_PhotoFanButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Check who gave you the most likes:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FacebookAppForm.Properties.Resources.top_fan;
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // m_CloseButton
            // 
            this.m_CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_CloseButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CloseButton.ForeColor = System.Drawing.Color.White;
            this.m_CloseButton.Location = new System.Drawing.Point(623, 457);
            this.m_CloseButton.Name = "m_CloseButton";
            this.m_CloseButton.Size = new System.Drawing.Size(164, 45);
            this.m_CloseButton.TabIndex = 3;
            this.m_CloseButton.Text = "Close";
            this.m_CloseButton.UseVisualStyleBackColor = false;
            this.m_CloseButton.Click += new System.EventHandler(this.m_CloseButton_Click);
            // 
            // m_GeneralFanButton
            // 
            this.m_GeneralFanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_GeneralFanButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_GeneralFanButton.ForeColor = System.Drawing.Color.White;
            this.m_GeneralFanButton.Location = new System.Drawing.Point(36, 242);
            this.m_GeneralFanButton.Name = "m_GeneralFanButton";
            this.m_GeneralFanButton.Size = new System.Drawing.Size(375, 45);
            this.m_GeneralFanButton.TabIndex = 1;
            this.m_GeneralFanButton.Text = "Your General TOP Fan";
            this.m_GeneralFanButton.UseVisualStyleBackColor = false;
            this.m_GeneralFanButton.Click += new System.EventHandler(this.m_GeneralFanButton_Click);
            // 
            // m_FansListBox
            // 
            this.m_FansListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.m_FansListBox.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_FansListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_FansListBox.FormattingEnabled = true;
            this.m_FansListBox.ItemHeight = 16;
            this.m_FansListBox.Location = new System.Drawing.Point(438, 159);
            this.m_FansListBox.Name = "m_FansListBox";
            this.m_FansListBox.Size = new System.Drawing.Size(349, 292);
            this.m_FansListBox.TabIndex = 0;
            // 
            // TopFanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookAppForm.Properties.Resources.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 696);
            this.Controls.Add(this.groupBox2);
            this.Name = "TopFanForm";
            this.Text = "TopFanForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mFilterGroupBox.ResumeLayout(false);
            this.mFilterGroupBox.PerformLayout();
            this.m_AgeGroupBox.ResumeLayout(false);
            this.m_AgeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MaxAgeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MinAgeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox mFilterGroupBox;
        private System.Windows.Forms.GroupBox m_AgeGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown m_MaxAgeUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown m_MinAgeUpDown;
        private System.Windows.Forms.ComboBox m_GenderComboBox;
        private System.Windows.Forms.CheckBox m_AllAgesCheckBox;
        private System.Windows.Forms.Button m_PostFanButton;
        private System.Windows.Forms.Button m_PhotoFanButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button m_CloseButton;
        private System.Windows.Forms.Button m_GeneralFanButton;
        private System.Windows.Forms.ListBox m_FansListBox;
    }
}