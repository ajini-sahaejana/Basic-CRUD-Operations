using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lec9
{
    public partial class FormInsert : Form
    {
        int id = 0;

        public FormInsert()
        {
            InitializeComponent();
        }

        private void insertSubmit_Click(object sender, EventArgs e)
        {
            id = id + 1;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ICT\C#\Lec9\Lec9.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into Login(id, username, password) values('" + id + "','" + usernameText.Text + "','" + passwordText.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void insertBack_Click(object sender, EventArgs e)
        {
            FormMain f1 = new FormMain();
            f1.Show();
            this.Hide();
        }
    }
}
