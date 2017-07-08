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
    public partial class EmployeInfo : Form
    {
        public EmployeInfo()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\myHomeWork\Pizzaaaaa\Pizzaaaaa\Database1.mdf;Integrated Security=True");
        
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        string UpdateInfo;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO PizzaEmploye (E_Name,E_Father,E_Mother,E_BirthDate,Password,Phone_No,Address,E_post,Salary) VALUES('" + textBoxName.Text + "','" + textBoxFather.Text + "','" + textBoxMother.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBoxPassword.Text + "'," + textBoxPhoneNumber.Text + ",'" + textBoxAddress.Text + "','" + comboBox1.Text + "'," + textBoxSalary.Text + ")";
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

            sda = new SqlDataAdapter("SELECT * FROM PizzaEmploye ", cn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void UPDATEbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int upd = Convert.ToInt32(UpdateInfo);
                cn.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("UPDATE PizzaEmploye SET E_Name='" + textBoxName.Text + "',E_Father='" + textBoxFather.Text + "',E_Mother='" + textBoxMother.Text + "',E_BirthDate='" + dateTimePicker1.Value.ToString() + "',Password='" + textBoxPassword.Text + "',Phone_No=" + textBoxPhoneNumber.Text + ",Address='" + textBoxAddress.Text + "',E_post='" + comboBox1.Text + "',Salary=" + textBoxSalary.Text + " where Id=" + upd + "", cn);
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

        private void buttonUPDATELIST_Click(object sender, EventArgs e)
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

        private void DELETEbutton_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "DELETE FROM PizzaEmploye WHERE(E_Name='" + textBoxDName.Text + "' AND Id=" + textBoxId.Text + ")";
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
                textBoxName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBoxFather.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBoxMother.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                //dateTimePicker1.Value = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBoxPassword.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBoxPhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBoxAddress.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                textBoxSalary.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

                textBoxDName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBoxId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch(Exception ux) 
            {
                MessageBox.Show(ux.Message, "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager ma = new Manager();
            ma.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pizza m = new Pizza();
            m.Show();
        }

        
    }
}
