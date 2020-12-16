namespace FacebookAppForm
{
    partial class PostForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createdTimeTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_WritePostTextBox = new System.Windows.Forms.TextBox();
            this.m_WritePostButton = new System.Windows.Forms.Button();
            this.m_ClostButtonPost = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_ListBoxPost = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.groupBox1.Controls.Add(this.createdTimeTextBox);
            this.groupBox1.Controls.Add(this.m_WritePostTextBox);
            this.groupBox1.Controls.Add(this.m_WritePostButton);
            this.groupBox1.Controls.Add(this.m_ClostButtonPost);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.m_ListBoxPost);
            this.groupBox1.Location = new System.Drawing.Point(110, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 511);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // createdTimeTextBox
            // 
            this.createdTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.createdTimeTextBox.Location = new System.Drawing.Point(20, 307);
            this.createdTimeTextBox.Multiline = true;
            this.createdTimeTextBox.Name = "createdTimeTextBox";
            this.createdTimeTextBox.Size = new System.Drawing.Size(713, 36);
            this.createdTimeTextBox.TabIndex = 13;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // m_WritePostTextBox
            // 
            this.m_WritePostTextBox.Location = new System.Drawing.Point(20, 349);
            this.m_WritePostTextBox.Multiline = true;
            this.m_WritePostTextBox.Name = "m_WritePostTextBox";
            this.m_WritePostTextBox.Size = new System.Drawing.Size(713, 78);
            this.m_WritePostTextBox.TabIndex = 12;
            this.m_WritePostTextBox.Text = "Write Post";
            // 
            // m_WritePostButton
            // 
            this.m_WritePostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_WritePostButton.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_WritePostButton.ForeColor = System.Drawing.Color.White;
            this.m_WritePostButton.Location = new System.Drawing.Point(20, 446);
            this.m_WritePostButton.Name = "m_WritePostButton";
            this.m_WritePostButton.Size = new System.Drawing.Size(164, 45);
            this.m_WritePostButton.TabIndex = 10;
            this.m_WritePostButton.Text = "Write Post";
            this.m_WritePostButton.UseVisualStyleBackColor = false;
            this.m_WritePostButton.Click += new System.EventHandler(this.writePostButton_Click);
            // 
            // m_ClostButtonPost
            // 
            this.m_ClostButtonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_ClostButtonPost.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ClostButtonPost.ForeColor = System.Drawing.Color.White;
            this.m_ClostButtonPost.Location = new System.Drawing.Point(569, 446);
            this.m_ClostButtonPost.Name = "m_ClostButtonPost";
            this.m_ClostButtonPost.Size = new System.Drawing.Size(164, 45);
            this.m_ClostButtonPost.TabIndex = 8;
            this.m_ClostButtonPost.Text = "Close";
            this.m_ClostButtonPost.UseVisualStyleBackColor = false;
            this.m_ClostButtonPost.Click += new System.EventHandler(this.closetButtonPost_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FacebookAppForm.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // m_ListBoxPost
            // 
            this.m_ListBoxPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.m_ListBoxPost.DataSource = this.postBindingSource;
            this.m_ListBoxPost.DisplayMember = "Description";
            this.m_ListBoxPost.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ListBoxPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(144)))));
            this.m_ListBoxPost.FormattingEnabled = true;
            this.m_ListBoxPost.ItemHeight = 16;
            this.m_ListBoxPost.Location = new System.Drawing.Point(20, 105);
            this.m_ListBoxPost.Name = "m_ListBoxPost";
            this.m_ListBoxPost.Size = new System.Drawing.Size(713, 196);
            this.m_ListBoxPost.TabIndex = 0;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FacebookAppForm.Properties.Resources.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 696);
            this.Controls.Add(this.groupBox1);
            this.Name = "PostForm";
            this.Text = "PostForm";
            this.Load += new System.EventHandler(this.PostForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox m_ListBoxPost;
        private System.Windows.Forms.Button m_WritePostButton;
        private System.Windows.Forms.Button m_ClostButtonPost;
        private System.Windows.Forms.TextBox m_WritePostTextBox;
        private System.Windows.Forms.TextBox createdTimeTextBox;
        private System.Windows.Forms.BindingSource postBindingSource;
    }
}