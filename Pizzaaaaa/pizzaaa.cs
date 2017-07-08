using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaaaaa
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            LogInManager m = new LogInManager();
            this.Hide();
            m.Show();
        }

        private void buttonEmploye_Click(object sender, EventArgs e)
        {
            LogInEmploye emp = new LogInEmploye();
            this.Hide();
            emp.Show();
        }

        
    }
}
