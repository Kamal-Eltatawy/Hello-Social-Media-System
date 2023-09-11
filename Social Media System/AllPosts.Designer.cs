namespace Social_Media_System
{
    partial class AllPosts
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
            pb_allpost = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_postdate = new Label();
            txt_post_title = new TextBox();
            rtb_description = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            lbl_posttime = new Label();
            dgv_posts = new DataGridView();
            btn_mypost = new Button();
            btn_createPost = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_allpost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_posts).BeginInit();
            SuspendLayout();
            // 
            // pb_allpost
            // 
            pb_allpost.Location = new Point(575, 12);
            pb_allpost.Name = "pb_allpost";
            pb_allpost.Size = new Size(220, 95);
            pb_allpost.TabIndex = 0;
            pb_allpost.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 131);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Dscription";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 214);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // lbl_postdate
            // 
            lbl_postdate.AutoSize = true;
            lbl_postdate.Location = new Point(448, 214);
            lbl_postdate.Name = "lbl_postdate";
            lbl_postdate.Size = new Size(0, 20);
            lbl_postdate.TabIndex = 6;
            // 
            // txt_post_title
            // 
            txt_post_title.Location = new Point(83, 33);
            txt_post_title.Name = "txt_post_title";
            txt_post_title.ReadOnly = true;
            txt_post_title.Size = new Size(378, 27);
            txt_post_title.TabIndex = 2;
            // 
            // rtb_description
            // 
            rtb_description.Location = new Point(83, 86);
            rtb_description.Name = "rtb_description";
            rtb_description.ReadOnly = true;
            rtb_description.Size = new Size(378, 97);
            rtb_description.TabIndex = 7;
            rtb_description.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 33);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 8;
            label5.Text = "Post Images";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 214);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 9;
            label6.Text = "Post Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 214);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 12;
            label4.Text = "Post Time";
            // 
            // lbl_posttime
            // 
            lbl_posttime.AutoSize = true;
            lbl_posttime.Location = new Point(221, 214);
            lbl_posttime.Name = "lbl_posttime";
            lbl_posttime.Size = new Size(0, 20);
            lbl_posttime.TabIndex = 11;
            // 
            // dgv_posts
            // 
            dgv_posts.AllowUserToAddRows = false;
            dgv_posts.AllowUserToDeleteRows = false;
            dgv_posts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_posts.Location = new Point(1, 260);
            dgv_posts.Name = "dgv_posts";
            dgv_posts.ReadOnly = true;
            dgv_posts.RowHeadersWidth = 51;
            dgv_posts.RowTemplate.Height = 29;
            dgv_posts.Size = new Size(799, 188);
            dgv_posts.TabIndex = 13;
            dgv_posts.RowHeaderMouseDoubleClick += dgv_posts_RowHeaderMouseDoubleClick;
            // 
            // btn_mypost
            // 
            btn_mypost.Location = new Point(575, 131);
            btn_mypost.Name = "btn_mypost";
            btn_mypost.Size = new Size(209, 36);
            btn_mypost.TabIndex = 14;
            btn_mypost.Text = "My Post";
            btn_mypost.UseVisualStyleBackColor = true;
            btn_mypost.Click += btn_mypost_Click;
            // 
            // btn_createPost
            // 
            btn_createPost.Location = new Point(575, 186);
            btn_createPost.Name = "btn_createPost";
            btn_createPost.Size = new Size(209, 36);
            btn_createPost.TabIndex = 15;
            btn_createPost.Text = "Create Post";
            btn_createPost.UseVisualStyleBackColor = true;
            btn_createPost.Click += btn_createPost_Click;
            // 
            // AllPosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_createPost);
            Controls.Add(btn_mypost);
            Controls.Add(dgv_posts);
            Controls.Add(label4);
            Controls.Add(lbl_posttime);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rtb_description);
            Controls.Add(lbl_postdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_post_title);
            Controls.Add(label1);
            Controls.Add(pb_allpost);
            Name = "AllPosts";
            Text = "AllPosts";
            Load += AllPosts_Load;
            ((System.ComponentModel.ISupportInitialize)pb_allpost).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_posts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_allpost;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_postdate;
        private TextBox txt_post_title;
        private RichTextBox rtb_description;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label lbl_posttime;
        private DataGridView dgv_posts;
        private Button btn_mypost;
        private Button btn_createPost;
    }
}