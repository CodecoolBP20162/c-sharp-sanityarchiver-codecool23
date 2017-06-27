using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Threading;
using System.IO;

namespace SanityArchive
{
    public partial class fileExp : Form
    {

        public fileExp()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files(*.pdf)|*.pdf|WORD Files(*.doc;*.docx)|*.doc;*.docx|EXCEL Files(*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt)|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt|Image Files(*.jpg;*.gif;*.bmp;*.png;*.jpeg)|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() {Description="Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                    string path = fbd.ToString();
                    txtPath.Text = fbd.SelectedPath;
                }
                
            }
        }


        private void btnOpen2_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd2 = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd2.ShowDialog() == DialogResult.OK)
                {
                    webBrowser2.Url = new Uri(fbd2.SelectedPath);
                    txtPath2.Text = fbd2.SelectedPath;
                }    
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            if (webBrowser2.CanGoBack)
                webBrowser2.GoBack();
        }

        private void btnForward2_Click(object sender, EventArgs e)
        {
            if (webBrowser2.CanGoForward)
                webBrowser2.GoForward();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdFolder = new FolderBrowserDialog();
            fbdFolder.Description = "Select folder";
            if (fbdFolder.ShowDialog() == DialogResult.OK)
                txtFolder.Text = fbdFolder.SelectedPath;
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter="All files |*.*",ValidateNames=true,Multiselect=false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtFileName.Text = ofd.FileName;
            }
        }

        private void btnZipFolder_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Please select your folder", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            string path = txtFolder.Text;
            Thread thread = new Thread(t =>
            {
                using(Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile()) {
                    zip.AddDirectory(path);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
                    zip.SaveProgress += Zip_SaveProgress;
                    zip.Save(string.Format("{0}{1}.zip", di.Parent.FullName, di.Name));
                
                }

                
            })
            {IsBackground = true };
            thread.Start();

        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if(e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = e.EntriesTotal;
                    progressBar.Value = e.EntriesSaved + 1;
                    progressBar.Update();
                }));
            }
        }

        private void Zip_SaveFileProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum =100;
                    progressBar.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar.Update();
                }));
            }
        }

        private void btnZipFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("Please select your filename", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFileName.Focus();
                return;
            }
            string fileName = txtFileName.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(fileName);
                    zip.AddFile(fileName);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(fileName);
                    zip.SaveProgress += Zip_SaveFileProgress;
                    zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, fi.Name));

                }


            })
            { IsBackground = true };
            thread.Start();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
                    txtPath.Text = webBrowser1.Url.ToString();
                


        }

        
    }
}
