namespace Social_Media_System
{
    partial class fr_Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_usname = new TextBox();
            txt_pass = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label5 = new Label();
            label6 = new Label();
            nud_age = new NumericUpDown();
            btn_register = new Button();
            btn_login = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 73);
            label1.Name = "label1";
            label1.Size = new Size(104, 35);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 9);
            label2.Name = "label2";
            label2.Size = new Size(160, 46);
            label2.TabIndex = 1;
            label2.Text = "Welcome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 162);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "User Name";
            // 
            // txt_usname
            // 
            txt_usname.Location = new Point(171, 159);
            txt_usname.Name = "txt_usname";
            txt_usname.Size = new Size(144, 27);
            txt_usname.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(171, 216);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(144, 27);
            txt_pass.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 223);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(527, 155);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(201, 27);
            txt_email.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 158);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 219);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 8;
            label6.Text = "Age";
            // 
            // nud_age
            // 
            nud_age.Location = new Point(527, 212);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(62, 27);
            nud_age.TabIndex = 10;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(190, 303);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(173, 29);
            btn_register.TabIndex = 11;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(457, 303);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(173, 29);
            btn_login.TabIndex = 12;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // fr_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(nud_age);
            Controls.Add(label6);
            Controls.Add(txt_email);
            Controls.Add(label5);
            Controls.Add(txt_pass);
            Controls.Add(label4);
            Controls.Add(txt_usname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fr_Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_usname;
        private TextBox txt_pass;
        private Label label4;
        private TextBox txt_email;
        private Label label5;
        private Label label6;
        private NumericUpDown nud_age;
        private Button btn_register;
        private Button btn_login;
    }
}