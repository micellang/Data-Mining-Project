namespace CewekSolid_DatMin_A
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.program1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gINIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMeansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.program1ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // program1ToolStripMenuItem
            // 
            this.program1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proximityToolStripMenuItem,
            this.gINIToolStripMenuItem,
            this.kMeansToolStripMenuItem});
            this.program1ToolStripMenuItem.Name = "program1ToolStripMenuItem";
            this.program1ToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.program1ToolStripMenuItem.Text = "Program Data Mining ";
            // 
            // proximityToolStripMenuItem
            // 
            this.proximityToolStripMenuItem.Name = "proximityToolStripMenuItem";
            this.proximityToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.proximityToolStripMenuItem.Text = "Proximity";
            this.proximityToolStripMenuItem.Click += new System.EventHandler(this.proximityToolStripMenuItem_Click);
            // 
            // gINIToolStripMenuItem
            // 
            this.gINIToolStripMenuItem.Name = "gINIToolStripMenuItem";
            this.gINIToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.gINIToolStripMenuItem.Text = "GINI";
            this.gINIToolStripMenuItem.Click += new System.EventHandler(this.gINIToolStripMenuItem_Click);
            // 
            // kMeansToolStripMenuItem
            // 
            this.kMeansToolStripMenuItem.Name = "kMeansToolStripMenuItem";
            this.kMeansToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.kMeansToolStripMenuItem.Text = "K-Means";
            this.kMeansToolStripMenuItem.Click += new System.EventHandler(this.kMeansToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Data Mining";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem program1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gINIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMeansToolStripMenuItem;
    }
}

