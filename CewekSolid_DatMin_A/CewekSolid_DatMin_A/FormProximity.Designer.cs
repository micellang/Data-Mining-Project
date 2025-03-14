namespace CewekSolid_DatMin_A
{
    partial class FormProximity
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
            this.buttonEucledian = new System.Windows.Forms.Button();
            this.buttonManhattan = new System.Windows.Forms.Button();
            this.buttonSupremum = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.dataGridViewProx = new System.Windows.Forms.DataGridView();
            this.proximityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEucledian
            // 
            this.buttonEucledian.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEucledian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEucledian.Location = new System.Drawing.Point(12, 99);
            this.buttonEucledian.Name = "buttonEucledian";
            this.buttonEucledian.Size = new System.Drawing.Size(152, 42);
            this.buttonEucledian.TabIndex = 2;
            this.buttonEucledian.Text = "Eucledian";
            this.buttonEucledian.UseVisualStyleBackColor = false;
            this.buttonEucledian.Click += new System.EventHandler(this.buttonEucledian_Click);
            // 
            // buttonManhattan
            // 
            this.buttonManhattan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonManhattan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManhattan.Location = new System.Drawing.Point(187, 99);
            this.buttonManhattan.Name = "buttonManhattan";
            this.buttonManhattan.Size = new System.Drawing.Size(164, 42);
            this.buttonManhattan.TabIndex = 3;
            this.buttonManhattan.Text = "Manhattan";
            this.buttonManhattan.UseVisualStyleBackColor = false;
            this.buttonManhattan.Click += new System.EventHandler(this.buttonManhattan_Click);
            // 
            // buttonSupremum
            // 
            this.buttonSupremum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSupremum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupremum.Location = new System.Drawing.Point(374, 99);
            this.buttonSupremum.Name = "buttonSupremum";
            this.buttonSupremum.Size = new System.Drawing.Size(178, 42);
            this.buttonSupremum.TabIndex = 5;
            this.buttonSupremum.Text = "Supremum";
            this.buttonSupremum.UseVisualStyleBackColor = false;
            this.buttonSupremum.Click += new System.EventHandler(this.buttonSupremum_Click);
            // 
            // labelFile
            // 
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(12, 28);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(156, 37);
            this.labelFile.TabIndex = 6;
            this.labelFile.Text = "File Path : ";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFile.Location = new System.Drawing.Point(128, 37);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(524, 28);
            this.textBoxFile.TabIndex = 7;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.AutoSize = true;
            this.buttonBrowse.Location = new System.Drawing.Point(685, 39);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(112, 29);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // dataGridViewProx
            // 
            this.dataGridViewProx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProx.Location = new System.Drawing.Point(16, 168);
            this.dataGridViewProx.Name = "dataGridViewProx";
            this.dataGridViewProx.RowHeadersWidth = 51;
            this.dataGridViewProx.RowTemplate.Height = 24;
            this.dataGridViewProx.Size = new System.Drawing.Size(1092, 488);
            this.dataGridViewProx.TabIndex = 9;
            // 
            // proximityBindingSource
            // 
            this.proximityBindingSource.DataSource = typeof(CewekSolid_DatMin_A.Proximity);
            // 
            // FormProximity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 676);
            this.Controls.Add(this.dataGridViewProx);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonSupremum);
            this.Controls.Add(this.buttonManhattan);
            this.Controls.Add(this.buttonEucledian);
            this.Name = "FormProximity";
            this.Text = "Perhitungan Proximity";
            this.Load += new System.EventHandler(this.FormProximity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEucledian;
        private System.Windows.Forms.Button buttonManhattan;
        private System.Windows.Forms.BindingSource proximityBindingSource;
        private System.Windows.Forms.Button buttonSupremum;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.DataGridView dataGridViewProx;
    }
}