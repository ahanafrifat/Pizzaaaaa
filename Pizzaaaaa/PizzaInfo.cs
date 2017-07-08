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
    public partial class PizzaInfo : Form
    {
        public PizzaInfo()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\myHomeWork\Pizzaaaaa\Pizzaaaaa\Database1.mdf;Integrated Security=True");

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        private string UpdateInfo;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO PizzaInfo (Pizza_name,Pizza_Size,Price) VALUES('" + textBoxPizzaName.Text + "','" + comboBox1.Text + "'," + textBoxPrice.Text + ")";
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
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("SELECT * FROM PizzaInfo ", cn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonUpdateList_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(sda);
                sda.Update(dt);
            }
            catch (Exception qx)
            {
                MessageBox.Show(qx.Message, "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM PizzaInfo WHERE(Pizza_name='" + textBoxDName.Text + "' AND Pizza_No=" + textBoxDNo.Text + ")";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Delete done !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception wx)
            {
                MessageBox.Show(wx.Message, "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                UpdateInfo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBoxPizzaName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBoxPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBoxDNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBoxDName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception tx)
            {
                MessageBox.Show(tx.Message, "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int upd = Convert.ToInt32(UpdateInfo);
                cn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("UPDATE PizzaInfo SET Pizza_name='" + textBoxPizzaName.Text + "',Pizza_Size='" + comboBox1.Text + "',Price=" + textBoxPrice.Text + " where Pizza_No=" + upd + "", cn);
                SDA.SelectCommand.ExecuteNonQuery();               
                MessageBox.Show("Update Successfully");
            }
            catch (Exception rx)
            {
                MessageBox.Show(rx.Message, "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pizza m = new Pizza();
            m.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager ma = new Manager();
            ma.Show();
        }      
    }
}
