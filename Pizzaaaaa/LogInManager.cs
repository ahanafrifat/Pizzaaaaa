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

namespace Pizzaaaaa
{
    public partial class LogInManager : Form
    {
        public LogInManager()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\myHomeWork\Pizzaaaaa\Pizzaaaaa\Database1.mdf;Integrated Security=True");

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Pizza pi = new Pizza();
            this.Close();
            pi.Show();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PizzaEmploye where E_Name='" + textBoxUserName.Text + "' and Password='" + textBoxPassword.Text + "'", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Manager my = new Manager();
                my.Show();
            }

            else
            {
                MessageBox.Show("Username & Password is invalid");
            }
        }
    }
}
