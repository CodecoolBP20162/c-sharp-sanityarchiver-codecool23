namespace SanityArchive
{
    partial class fileExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileExp));
            this.btnOpen = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnForward2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnFileName = new System.Windows.Forms.Button();
            this.btnZipFolder = new System.Windows.Forms.Button();
            this.btnZipFile = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(366, 15);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(54, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 46);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(408, 349);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser2.Location = new System.Drawing.Point(430, 46);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(445, 349);
            this.webBrowser2.TabIndex = 6;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // btnBack2
            // 
            this.btnBack2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack2.Location = new System.Drawing.Point(428, 14);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(32, 23);
            this.btnBack2.TabIndex = 7;
            this.btnBack2.Text = "<<";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnForward2
            // 
            this.btnForward2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForward2.Location = new System.Drawing.Point(463, 14);
            this.btnForward2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnForward2.Name = "btnForward2";
            this.btnForward2.Size = new System.Drawing.Size(32, 23);
            this.btnForward2.TabIndex = 8;
            this.btnForward2.Text = ">>";
            this.btnForward2.UseVisualStyleBackColor = true;
            this.btnForward2.Click += new System.EventHandler(this.btnForward2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(497, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Path";
            // 
            // txtPath2
            // 
            this.txtPath2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath2.Location = new System.Drawing.Point(528, 14);
            this.txtPath2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(285, 20);
            this.txtPath2.TabIndex = 10;
            // 
            // btnOpen2
            // 
            this.btnOpen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen2.Location = new System.Drawing.Point(821, 12);
            this.btnOpen2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(54, 23);
            this.btnOpen2.TabIndex = 11;
            this.btnOpen2.Text = "Open";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(115, 17);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(243, 20);
            this.txtPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path";
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(45, 15);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(32, 23);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(10, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(201, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Folder:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(201, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "File:";
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFolder.Location = new System.Drawing.Point(266, 401);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(278, 20);
            this.txtFolder.TabIndex = 15;
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFileName.Location = new System.Drawing.Point(266, 435);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(278, 20);
            this.txtFileName.TabIndex = 16;
            // 
            // btnFolder
            // 
            this.btnFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFolder.Location = new System.Drawing.Point(553, 399);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(30, 23);
            this.btnFolder.TabIndex = 17;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnFileName
            // 
            this.btnFileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFileName.Location = new System.Drawing.Point(553, 433);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(30, 23);
            this.btnFileName.TabIndex = 18;
            this.btnFileName.Text = "...";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // btnZipFolder
            // 
            this.btnZipFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZipFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnZipFolder.Image")));
            this.btnZipFolder.Location = new System.Drawing.Point(589, 398);
            this.btnZipFolder.Name = "btnZipFolder";
            this.btnZipFolder.Size = new System.Drawing.Size(42, 28);
            this.btnZipFolder.TabIndex = 19;
            this.btnZipFolder.Text = "ZIP";
            this.btnZipFolder.UseVisualStyleBackColor = true;
            this.btnZipFolder.Click += new System.EventHandler(this.btnZipFolder_Click);
            // 
            // btnZipFile
            // 
            this.btnZipFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZipFile.Image = ((System.Drawing.Image)(resources.GetObject("btnZipFile.Image")));
            this.btnZipFile.Location = new System.Drawing.Point(589, 433);
            this.btnZipFile.Name = "btnZipFile";
            this.btnZipFile.Size = new System.Drawing.Size(42, 30);
            this.btnZipFile.TabIndex = 20;
            this.btnZipFile.Text = "ZIP";
            this.btnZipFile.UseVisualStyleBackColor = true;
            this.btnZipFile.Click += new System.EventHandler(this.btnZipFile_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(266, 470);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(278, 23);
            this.progressBar.TabIndex = 21;
            // 
            // fileExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 505);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnZipFile);
            this.Controls.Add(this.btnZipFolder);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnForward2);
            this.Controls.Add(this.btnBack2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fileExp";
            this.Text = "SanityArchive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnForward2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.Button btnZipFolder;
        private System.Windows.Forms.Button btnZipFile;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

