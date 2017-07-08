namespace Pizzaaaaa
{
    partial class Pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizza));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEmploye = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.buttonEmploye);
            this.panel1.Controls.Add(this.buttonManager);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 273);
            this.panel1.TabIndex = 0;
            // 
            // buttonEmploye
            // 
            this.buttonEmploye.Location = new System.Drawing.Point(163, 188);
            this.buttonEmploye.Name = "buttonEmploye";
            this.buttonEmploye.Size = new System.Drawing.Size(84, 29);
            this.buttonEmploye.TabIndex = 1;
            this.buttonEmploye.Text = "Employe";
            this.buttonEmploye.UseVisualStyleBackColor = true;
            this.buttonEmploye.Click += new System.EventHandler(this.buttonEmploye_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(163, 153);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(84, 29);
            this.buttonManager.TabIndex = 0;
            this.buttonManager.Text = "Manager";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 280);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Pizza";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzaaa....";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEmploye;
        private System.Windows.Forms.Button buttonManager;
    }
}

