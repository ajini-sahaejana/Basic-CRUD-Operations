using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            FormInsert f1 = new FormInsert();
            f1.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            FormUpdate f1 = new FormUpdate();
            f1.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            FormDelete f1 = new FormDelete();
            f1.Show();
            this.Hide();
        }
    }
}
