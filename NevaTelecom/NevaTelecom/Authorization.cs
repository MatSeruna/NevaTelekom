using System.Data.SqlClient;
using System.Data;
namespace NevaTelecom
{
    public partial class Authorization : Form
    {
        DataBase dataBase = new DataBase();
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string eMail = textBox_eMail.Text;
            string password = textBox_password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id, email, password from Users where email = '{eMail}' and password = '{password}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("You logined", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
            }
            else
                MessageBox.Show("Wrong email or password!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Authorization_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_password.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }
    }
}