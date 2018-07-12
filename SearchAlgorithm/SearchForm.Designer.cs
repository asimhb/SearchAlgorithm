namespace SearchAlgorithm
{
    partial class search
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.countLbl = new System.Windows.Forms.Label();
            this.pathList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.lblFolderPathName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(262, 157);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(645, 22);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(926, 151);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(165, 28);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(980, 278);
            this.countLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(0, 17);
            this.countLbl.TabIndex = 3;
            // 
            // pathList
            // 
            this.pathList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pathList.FormattingEnabled = true;
            this.pathList.ItemHeight = 16;
            this.pathList.Location = new System.Drawing.Point(136, 208);
            this.pathList.Margin = new System.Windows.Forms.Padding(4);
            this.pathList.Name = "pathList";
            this.pathList.Size = new System.Drawing.Size(779, 404);
            this.pathList.TabIndex = 4;
            this.pathList.SelectedIndexChanged += new System.EventHandler(this.pathList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Folder Search";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(926, 55);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(165, 60);
            this.btnSelectPath.TabIndex = 7;
            this.btnSelectPath.Text = "Select Folder Path";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(125, 98);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(85, 17);
            this.lblFolderPath.TabIndex = 8;
            this.lblFolderPath.Text = "Folder Path:";
            // 
            // lblFolderPathName
            // 
            this.lblFolderPathName.AutoSize = true;
            this.lblFolderPathName.Location = new System.Drawing.Point(234, 98);
            this.lblFolderPathName.Name = "lblFolderPathName";
            this.lblFolderPathName.Size = new System.Drawing.Size(0, 17);
            this.lblFolderPathName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Search Here:";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFolderPathName);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathList);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.ListBox pathList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.Label lblFolderPathName;
        private System.Windows.Forms.Label label2;
    }
}

