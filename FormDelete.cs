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
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idText.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ICT\C#\Lec9\Lec9.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "delete from Login where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully!");
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

        private void deleteBack_Click(object sender, EventArgs e)
        {
            FormMain f1 = new FormMain();
            f1.Show();
            this.Hide();
        }
    }
}
