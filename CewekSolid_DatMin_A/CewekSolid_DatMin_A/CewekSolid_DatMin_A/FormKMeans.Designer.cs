
namespace CewekSolid_DatMin_A
{
    partial class FormKMeans
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonKMeans = new System.Windows.Forms.Button();
            this.dataGridViewKMeans = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKMeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.AutoSize = true;
            this.buttonBrowse.Location = new System.Drawing.Point(731, 28);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(112, 29);
            this.buttonBrowse.TabIndex = 14;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFile.Location = new System.Drawing.Point(138, 26);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(566, 28);
            this.textBoxFile.TabIndex = 13;
            // 
            // labelFile
            // 
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(22, 17);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(156, 37);
            this.labelFile.TabIndex = 12;
            this.labelFile.Text = "File Path : ";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKMeans
            // 
            this.buttonKMeans.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonKMeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKMeans.Location = new System.Drawing.Point(22, 88);
            this.buttonKMeans.Name = "buttonKMeans";
            this.buttonKMeans.Size = new System.Drawing.Size(152, 42);
            this.buttonKMeans.TabIndex = 10;
            this.buttonKMeans.Text = "K-Means";
            this.buttonKMeans.UseVisualStyleBackColor = false;
            this.buttonKMeans.Click += new System.EventHandler(this.buttonKMeans_Click);
            // 
            // dataGridViewKMeans
            // 
            this.dataGridViewKMeans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKMeans.Location = new System.Drawing.Point(22, 167);
            this.dataGridViewKMeans.Name = "dataGridViewKMeans";
            this.dataGridViewKMeans.RowHeadersWidth = 51;
            this.dataGridViewKMeans.RowTemplate.Height = 24;
            this.dataGridViewKMeans.Size = new System.Drawing.Size(1056, 339);
            this.dataGridViewKMeans.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 541);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1056, 217);
            this.dataGridView2.TabIndex = 15;
            // 
            // FormKMeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 786);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonKMeans);
            this.Controls.Add(this.dataGridViewKMeans);
            this.Name = "FormKMeans";
            this.Text = "K-Means";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKMeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonKMeans;
        private System.Windows.Forms.DataGridView dataGridViewKMeans;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}