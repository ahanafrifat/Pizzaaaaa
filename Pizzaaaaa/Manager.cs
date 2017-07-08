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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\myHomeWork\Pizzaaaaa\Pizzaaaaa\Database1.mdf;Integrated Security=True");

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pizza m = new Pizza();
            m.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.SellInfo' table. You can move, or remove it, as needed.
            this.sellInfoTableAdapter.Fill(this.database1DataSet.SellInfo);

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("SELECT * FROM SellInfo ", cn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PizzaInfo pi = new PizzaInfo();
            pi.Show();

        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeInfo emp = new EmployeInfo();
            emp.Show();
        }

        private void sellPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            SellPizza sp = new SellPizza();
            sp.Show();
        }
    }
}
