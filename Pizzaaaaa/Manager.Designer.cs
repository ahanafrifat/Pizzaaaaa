namespace Pizzaaaaa
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sellInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Pizzaaaaa.Database1DataSet();
            this.sellInfoTableAdapter = new Pizzaaaaa.Database1DataSetTableAdapters.SellInfoTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.sellPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeToolStripMenuItem,
            this.pizzaToolStripMenuItem,
            this.sellPizzaToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // employeToolStripMenuItem
            // 
            this.employeToolStripMenuItem.Name = "employeToolStripMenuItem";
            this.employeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.employeToolStripMenuItem.Text = "Employe";
            this.employeToolStripMenuItem.Click += new System.EventHandler(this.employeToolStripMenuItem_Click);
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pizzaToolStripMenuItem.Text = "pizza";
            this.pizzaToolStripMenuItem.Click += new System.EventHandler(this.pizzaToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(204, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sell Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellNoDataGridViewTextBoxColumn,
            this.sellDateDataGridViewTextBoxColumn,
            this.totalsellDataGridViewTextBoxColumn,
            this.pizzanameDataGridViewTextBoxColumn,
            this.pizzaSizeDataGridViewTextBoxColumn,
            this.pizzaQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sellInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(639, 258);
            this.dataGridView1.TabIndex = 2;
            // 
            // sellInfoBindingSource
            // 
            this.sellInfoBindingSource.DataMember = "SellInfo";
            this.sellInfoBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellInfoTableAdapter
            // 
            this.sellInfoTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 80);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // sellPizzaToolStripMenuItem
            // 
            this.sellPizzaToolStripMenuItem.Name = "sellPizzaToolStripMenuItem";
            this.sellPizzaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sellPizzaToolStripMenuItem.Text = "Sell Pizza";
            this.sellPizzaToolStripMenuItem.Click += new System.EventHandler(this.sellPizzaToolStripMenuItem_Click);
            // 
            // sellNoDataGridViewTextBoxColumn
            // 
            this.sellNoDataGridViewTextBoxColumn.DataPropertyName = "Sell_No";
            this.sellNoDataGridViewTextBoxColumn.HeaderText = "Sell_No";
            this.sellNoDataGridViewTextBoxColumn.Name = "sellNoDataGridViewTextBoxColumn";
            this.sellNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellDateDataGridViewTextBoxColumn
            // 
            this.sellDateDataGridViewTextBoxColumn.DataPropertyName = "Sell_Date";
            this.sellDateDataGridViewTextBoxColumn.HeaderText = "Sell_Date";
            this.sellDateDataGridViewTextBoxColumn.Name = "sellDateDataGridViewTextBoxColumn";
            this.sellDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalsellDataGridViewTextBoxColumn
            // 
            this.totalsellDataGridViewTextBoxColumn.DataPropertyName = "Total_sell";
            this.totalsellDataGridViewTextBoxColumn.HeaderText = "Total_sell";
            this.totalsellDataGridViewTextBoxColumn.Name = "totalsellDataGridViewTextBoxColumn";
            this.totalsellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pizzanameDataGridViewTextBoxColumn
            // 
            this.pizzanameDataGridViewTextBoxColumn.DataPropertyName = "Pizza_name";
            this.pizzanameDataGridViewTextBoxColumn.HeaderText = "Pizza_name";
            this.pizzanameDataGridViewTextBoxColumn.Name = "pizzanameDataGridViewTextBoxColumn";
            this.pizzanameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pizzaSizeDataGridViewTextBoxColumn
            // 
            this.pizzaSizeDataGridViewTextBoxColumn.DataPropertyName = "Pizza_Size";
            this.pizzaSizeDataGridViewTextBoxColumn.HeaderText = "Pizza_Size";
            this.pizzaSizeDataGridViewTextBoxColumn.Name = "pizzaSizeDataGridViewTextBoxColumn";
            this.pizzaSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pizzaQuantityDataGridViewTextBoxColumn
            // 
            this.pizzaQuantityDataGridViewTextBoxColumn.DataPropertyName = "Pizza_Quantity";
            this.pizzaQuantityDataGridViewTextBoxColumn.HeaderText = "Pizza_Quantity";
            this.pizzaQuantityDataGridViewTextBoxColumn.Name = "pizzaQuantityDataGridViewTextBoxColumn";
            this.pizzaQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 379);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource sellInfoBindingSource;
        private Database1DataSetTableAdapters.SellInfoTableAdapter sellInfoTableAdapter;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ToolStripMenuItem sellPizzaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaQuantityDataGridViewTextBoxColumn;
    }
}