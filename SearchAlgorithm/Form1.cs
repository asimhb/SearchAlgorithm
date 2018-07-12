using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SearchAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            searchBtn.Enabled = false;


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchFolder srt = new SearchFolder();

            string searchWord = searchBox.Text;
            List<string> allFiles = new List<string>();
            srt.AddFileNamesToList(lblFolderPathName.Text, allFiles);



            foreach (string fileName in allFiles) // get all the files in the folder
            {

                string text = File.ReadAllText(fileName);
                if (text.Contains(searchWord))
                {
                    pathList.Items.Add(fileName);

                }
            }

        }


        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(searchBox.Text) && lblFolderPathName.Text != "")
                searchBtn.Enabled = true;
            else
                searchBtn.Enabled = false;
        }

        private void pathList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string openFile = pathList.SelectedItem.ToString();

            int index = pathList.FindString(openFile);

            if (index == -1)
                MessageBox.Show("error");
            else
            {
                // gameList.SetSelected(index, true);
                Process.Start(openFile);
            }


        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.RootFolder = Environment.SpecialFolder.Desktop;
            fdb.ShowNewFolderButton = false;
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                
               lblFolderPathName.Text = fdb.SelectedPath;
            }
        }

        private void ext_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
