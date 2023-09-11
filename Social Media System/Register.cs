using Social_Media_System.Model;

namespace Social_Media_System
{
    public partial class fr_Register : Form
    {

        private DB_Context context;
        public fr_Register()
        {
            InitializeComponent();
            context = new DB_Context();
        }

        public bool IsUserNameValid(string userName)
        {
            if (userName == null)
            {
                MessageBox.Show(" Invalid Username");
                return false;
            }
            else if (context.authors.Any(i => i.UserName == userName))
            {
                MessageBox.Show(" Username Isnt available");
                return false;
            }
            return true;
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (IsUserNameValid(txt_usname.Text) && !string.IsNullOrEmpty(txt_pass.Text) && !string.IsNullOrEmpty(txt_email.Text))
            {
                Author author = new Author()
                {
                    UserName = txt_usname.Text,
                    Age = Convert.ToInt32(nud_age.Value),
                    Email = txt_email.Text,
                    Password = txt_pass.Text,

                };
                context.authors.Add(author);
                context.SaveChanges();
                MessageBox.Show("Thank you for Registering :)");
                Login login = new Login();
                login.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }

}
