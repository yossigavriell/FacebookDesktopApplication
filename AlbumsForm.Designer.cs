namespace FacebookAppForm
{
    partial class AlbumsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumsForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_PicLabel = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idListBox = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_CloseButton = new System.Windows.Forms.Button();
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.groupBox2.Controls.Add(this.albumListBox);
            this.groupBox2.Controls.Add(this.m_PicLabel);
            this.groupBox2.Controls.Add(this.imageNormalPictureBox);
            this.groupBox2.Controls.Add(this.idListBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.m_CloseButton);
            this.groupBox2.Location = new System.Drawing.Point(126, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 522);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // m_PicLabel
            // 
            this.m_PicLabel.AutoSize = true;
            this.m_PicLabel.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PicLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_PicLabel.Location = new System.Drawing.Point(471, 105);
            this.m_PicLabel.Name = "m_PicLabel";
            this.m_PicLabel.Size = new System.Drawing.Size(68, 16);
            this.m_PicLabel.TabIndex = 15;
            this.m_PicLabel.Text = "Picture:";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(474, 155);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(338, 292);
            this.imageNormalPictureBox.TabIndex = 14;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // idListBox
            // 
            this.idListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.photoBindingSource, "Id", true));
            this.idListBox.DataSource = this.photoBindingSource;
            this.idListBox.DisplayMember = "Id";
            this.idListBox.FormattingEnabled = true;
            this.idListBox.ItemHeight = 16;
            this.idListBox.Location = new System.Drawing.Point(206, 155);
            this.idListBox.Name = "idListBox";
            this.idListBox.Size = new System.Drawing.Size(170, 292);
            this.idListBox.TabIndex = 13;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(203, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Picture List:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Album List:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FacebookAppForm.Properties.Resources.Albums;
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
            this.m_CloseButton.Location = new System.Drawing.Point(648, 471);
            this.m_CloseButton.Name = "m_CloseButton";
            this.m_CloseButton.Size = new System.Drawing.Size(164, 45);
            this.m_CloseButton.TabIndex = 3;
            this.m_CloseButton.Text = "Close";
            this.m_CloseButton.UseVisualStyleBackColor = false;
            this.m_CloseButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // albumListBox
            // 
            this.albumListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.photoBindingSource, "Id", true));
            this.albumListBox.DataSource = this.albumBindingSource;
            this.albumListBox.DisplayMember = "Name";
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.ItemHeight = 16;
            this.albumListBox.Location = new System.Drawing.Point(20, 155);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(170, 292);
            this.albumListBox.TabIndex = 16;
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 697);
            this.Controls.Add(this.groupBox2);
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            this.Load += new System.EventHandler(this.AlbumsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button m_CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.ListBox idListBox;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label m_PicLabel;
        private System.Windows.Forms.ListBox albumListBox;
    }
}