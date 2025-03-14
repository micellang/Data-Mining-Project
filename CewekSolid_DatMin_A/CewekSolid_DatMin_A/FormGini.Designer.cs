
namespace CewekSolid_DatMin_A
{
    partial class FormGini
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
            this.listBoxHasil = new System.Windows.Forms.ListBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGini = new System.Windows.Forms.Button();
            this.dataGridViewGini = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGini)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxHasil
            // 
            this.listBoxHasil.FormattingEnabled = true;
            this.listBoxHasil.ItemHeight = 16;
            this.listBoxHasil.Location = new System.Drawing.Point(27, 463);
            this.listBoxHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxHasil.Name = "listBoxHasil";
            this.listBoxHasil.Size = new System.Drawing.Size(862, 148);
            this.listBoxHasil.TabIndex = 22;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.AutoSize = true;
            this.buttonBrowse.Location = new System.Drawing.Point(151, 22);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(149, 37);
            this.buttonBrowse.TabIndex = 21;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFile
            // 
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(27, 22);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(156, 37);
            this.labelFile.TabIndex = 19;
            this.labelFile.Text = "File Path : ";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(687, 670);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(201, 42);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonGini
            // 
            this.buttonGini.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonGini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGini.Location = new System.Drawing.Point(27, 93);
            this.buttonGini.Name = "buttonGini";
            this.buttonGini.Size = new System.Drawing.Size(152, 42);
            this.buttonGini.TabIndex = 17;
            this.buttonGini.Text = "GINI";
            this.buttonGini.UseVisualStyleBackColor = false;
            this.buttonGini.Click += new System.EventHandler(this.buttonGini_Click);
            // 
            // dataGridViewGini
            // 
            this.dataGridViewGini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGini.Location = new System.Drawing.Point(27, 172);
            this.dataGridViewGini.Name = "dataGridViewGini";
            this.dataGridViewGini.RowHeadersWidth = 51;
            this.dataGridViewGini.RowTemplate.Height = 24;
            this.dataGridViewGini.Size = new System.Drawing.Size(861, 262);
            this.dataGridViewGini.TabIndex = 16;
            // 
            // FormGini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 770);
            this.Controls.Add(this.listBoxHasil);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonGini);
            this.Controls.Add(this.dataGridViewGini);
            this.Name = "FormGini";
            this.Text = "FormGini";
            this.Load += new System.EventHandler(this.FormGini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHasil;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonGini;
        private System.Windows.Forms.DataGridView dataGridViewGini;
    }
}