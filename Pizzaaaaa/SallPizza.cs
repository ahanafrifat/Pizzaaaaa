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
    public partial class SellPizza : Form
    {
        public SellPizza()
        {
            InitializeComponent();
            
        }
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\myHomeWork\Pizzaaaaa\Pizzaaaaa\Database1.mdf;Integrated Security=True");

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        string UpdateInfo;
        int total,P_Price,P_Number;
        private int Count_Total_Price()
        {
            try
            {
                P_Price = Convert.ToInt32(textBoxPrice.Text);
                P_Number = Convert.ToInt32(textBoxNo.Text);
                total = P_Price * P_Number;
            }
            catch(Exception xi){
                MessageBox.Show(xi.Message, "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return total;
        }

        private void SalePizza_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.PizzaInfo' table. You can move, or remove it, as needed.
            this.pizzaInfoTableAdapter.Fill(this.database1DataSet.PizzaInfo);

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("SELECT * FROM PizzaInfo ", cn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                UpdateInfo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBoxPizzaName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBoxSize.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBoxPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception tx)
            {
                MessageBox.Show(tx.Message, "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {         
            textBoxTotal.Text = Count_Total_Price().ToString();
        }

        private void buttonPaid_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO SellInfo (Pizza_name,Pizza_Size,Sell_Date,Total_sell,Pizza_Quantity) VALUES('" + textBoxPizzaName.Text + "','" + textBoxSize.Text + "','" + dateTimePicker1.Value.ToString() + "'," + textBoxTotal.Text + "," + textBoxNo.Text + ")";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Add new recode done !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }




            textBoxPizzaName.Text = null;
            textBoxSize.Text=null;
            textBoxPrice.Text = null;
            textBoxNo.Text = null;
            textBoxTotal.Text = null;

        }

        

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pizza pi = new Pizza();
            pi.Show();
        }
    }
}
