using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lec9
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void updateSubmit_Click(object sender, EventArgs e)
        {
            /*string id = idText.Text;
            string npassword = passwordText.Text;*/

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ICT\C#\Lec9\Lec9.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "update Login set password ='" + passwordText.Text + "' where id='" + idText.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!");
            }
            catch (SqlException e1)
            {
                Console.WriteLine(e1.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void updateBack_Click(object sender, EventArgs e)
        {
            FormMain f1 = new FormMain();
            f1.Show();
            this.Hide();
        }
    }
}
