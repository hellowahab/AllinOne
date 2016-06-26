namespace AllinOne
{
    partial class DesktopCleaner
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesktopLocation = new System.Windows.Forms.TextBox();
            this.fbdTargetLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetLocation = new System.Windows.Forms.TextBox();
            this.btnTargetLocation = new System.Windows.Forms.Button();
            this.ckblFiles = new System.Windows.Forms.CheckedListBox();
            this.btnFetchFiles = new System.Windows.Forms.Button();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.btnDeleteFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desktop Location";
            // 
            // txtDesktopLocation
            // 
            this.txtDesktopLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesktopLocation.Location = new System.Drawing.Point(109, 6);
            this.txtDesktopLocation.Name = "txtDesktopLocation";
            this.txtDesktopLocation.Size = new System.Drawing.Size(497, 20);
            this.txtDesktopLocation.TabIndex = 1;
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderBrowser.Location = new System.Drawing.Point(612, 3);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(41, 23);
            this.btnFolderBrowser.TabIndex = 2;
            this.btnFolderBrowser.Text = "...";
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Target Location";
            // 
            // txtTargetLocation
            // 
            this.txtTargetLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetLocation.Location = new System.Drawing.Point(109, 32);
            this.txtTargetLocation.Name = "txtTargetLocation";
            this.txtTargetLocation.Size = new System.Drawing.Size(497, 20);
            this.txtTargetLocation.TabIndex = 1;
            // 
            // btnTargetLocation
            // 
            this.btnTargetLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTargetLocation.Location = new System.Drawing.Point(612, 29);
            this.btnTargetLocation.Name = "btnTargetLocation";
            this.btnTargetLocation.Size = new System.Drawing.Size(41, 23);
            this.btnTargetLocation.TabIndex = 2;
            this.btnTargetLocation.Text = "...";
            this.btnTargetLocation.UseVisualStyleBackColor = true;
            this.btnTargetLocation.Click += new System.EventHandler(this.btnTargetLocation_Click);
            // 
            // ckblFiles
            // 
            this.ckblFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckblFiles.FormattingEnabled = true;
            this.ckblFiles.Location = new System.Drawing.Point(12, 58);
            this.ckblFiles.Name = "ckblFiles";
            this.ckblFiles.Size = new System.Drawing.Size(641, 289);
            this.ckblFiles.TabIndex = 3;
            // 
            // btnFetchFiles
            // 
            this.btnFetchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFetchFiles.Location = new System.Drawing.Point(417, 353);
            this.btnFetchFiles.Name = "btnFetchFiles";
            this.btnFetchFiles.Size = new System.Drawing.Size(75, 23);
            this.btnFetchFiles.TabIndex = 4;
            this.btnFetchFiles.Text = "Fetch Files";
            this.btnFetchFiles.UseVisualStyleBackColor = true;
            this.btnFetchFiles.Click += new System.EventHandler(this.btnFetchFiles_Click);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveFiles.Location = new System.Drawing.Point(498, 353);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(75, 23);
            this.btnMoveFiles.TabIndex = 4;
            this.btnMoveFiles.Text = "Move Files";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // btnDeleteFiles
            // 
            this.btnDeleteFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFiles.Location = new System.Drawing.Point(579, 353);
            this.btnDeleteFiles.Name = "btnDeleteFiles";
            this.btnDeleteFiles.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFiles.TabIndex = 4;
            this.btnDeleteFiles.Text = "Delete Files";
            this.btnDeleteFiles.UseVisualStyleBackColor = true;
            this.btnDeleteFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // DesktopCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 398);
            this.Controls.Add(this.btnDeleteFiles);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.btnFetchFiles);
            this.Controls.Add(this.ckblFiles);
            this.Controls.Add(this.btnTargetLocation);
            this.Controls.Add(this.btnFolderBrowser);
            this.Controls.Add(this.txtTargetLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesktopLocation);
            this.Controls.Add(this.label1);
            this.Name = "DesktopCleaner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DesktopCleaner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesktopLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdTargetLocation;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetLocation;
        private System.Windows.Forms.Button btnTargetLocation;
        private System.Windows.Forms.CheckedListBox ckblFiles;
        private System.Windows.Forms.Button btnFetchFiles;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Button btnDeleteFiles;
    }
}