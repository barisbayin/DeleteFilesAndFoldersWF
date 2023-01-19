using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteFilesAndFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string path=string.Empty;
        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                string[] folders = Directory.GetDirectories(fbd.SelectedPath, "*.*", SearchOption.AllDirectories);

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath,"*.*",SearchOption.AllDirectories);

                    tbxPath.Text=fbd.SelectedPath;
                    path=fbd.SelectedPath;
                    lbxResults.Items.AddRange(files);
                    lbxFolders.Items.AddRange(folders);
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbxPath.Text = "";
            lbxResults.Items.Clear();
            lbxFolders.Items.Clear();
            tbxFilePatern.Text = "";
            tbxFolderPatern.Text = "";

        }

        private void DeleteFiles(string[] filePatterns, string[] folderPatterns)
        {
            if (!string.IsNullOrEmpty(tbxPath.Text))
            {
                string[] folders = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);

                foreach (string folder in folders)
                {
                    string directoryName = Path.GetFileName(folder.ToLower());

                    foreach (var folderPattern in folderPatterns)
                    {

                        if (directoryName.Contains(folderPattern.ToLower()))
                        {
                            string[] folderFiles = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
                            foreach (var folderFile in folderFiles)
                            {
                                File.Delete(folderFile);
                            }
                            break;
                        }
                    }
                }

                string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    foreach (var pattern in filePatterns)
                    {
                        if (Path.GetFileNameWithoutExtension(file).ToLower().Contains(pattern.ToLower()))
                        {
                            File.Delete(file);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }



        public string[] GetFilePatterns()
        {
            string[] patternArray = new string[lbxContainsFileName.Items.Count];
            lbxContainsFileName.Items.CopyTo(patternArray, 0);

            return patternArray;
        }
        public string[] GetFolderPatterns()
        {
            string[] patternArray = new string[lbxContainsFolderName.Items.Count];
            lbxContainsFolderName.Items.CopyTo(patternArray, 0);

            return patternArray;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxPath.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete files by patern. You can not get them back.", "warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteFiles(GetFilePatterns(), GetFolderPatterns());
                    MessageBox.Show("Files deleted by patern!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancelled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please choose directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void chckManuelChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (chckManuelChoose.Checked)
            {
                tbxPath.Enabled=true;
            }
            else
            {
                tbxPath.Enabled = false;
            }
        }

        private void btnGetFiles_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(tbxPath.Text, "*.*", SearchOption.AllDirectories);
            string[] folders = Directory.GetDirectories(tbxPath.Text, "*.*", SearchOption.AllDirectories);

            path = tbxPath.Text;
            lbxResults.Items.AddRange(files);
            lbxFolders.Items.AddRange(folders);
        }

        private void btnDeleteFilePatern_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxFilePatern.Text))
            {
                lbxContainsFileName.Items.Remove(tbxFilePatern.Text);
            }
        }

        private void btnAddFilePatern_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxFilePatern.Text))
            {
                lbxContainsFileName.Items.Add(tbxFilePatern.Text);
            }
        }

        private void btnDeleteFolderPatern_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxFolderPatern.Text))
            {
                lbxContainsFolderName.Items.Remove(tbxFolderPatern.Text);
            }
        }

        private void btnAddFolderPatern_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxFolderPatern.Text))
            {
                lbxContainsFolderName.Items.Add(tbxFolderPatern.Text);
            }
        }

        private void lbxContainsFileName_SelectedValueChanged(object sender, EventArgs e)
        {
            
               
            
        }

        private void lbxContainsFolderName_SelectedValueChanged(object sender, EventArgs e)
        {
        
           
        }

        private void lbxContainsFolderName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxContainsFolderName.SelectedIndex >= 0)
                {
                    tbxFolderPatern.Text = lbxContainsFolderName.SelectedItem.ToString();
                }
                else
                {
                    tbxFolderPatern.Text = "";
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void lbxContainsFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxContainsFileName.SelectedIndex >= 0)
                {
                    tbxFilePatern.Text = lbxContainsFileName.SelectedItem.ToString();
                }
                else
                {
                    tbxFilePatern.Text = "";
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}
