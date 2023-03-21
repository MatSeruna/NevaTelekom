namespace NevaTelecom
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eMail = textBox_eMail.Text;
            string password = textBox_password.Text;

            if(eMail == "user@gmail.com" && password == "12345678")
            {
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
            }

        }
    }
}