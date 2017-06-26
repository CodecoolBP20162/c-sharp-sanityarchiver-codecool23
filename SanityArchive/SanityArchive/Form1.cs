using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() {Description="Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
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
    }
}
