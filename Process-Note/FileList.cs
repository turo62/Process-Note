using System;
using System.IO;
using System.Windows.Forms;

namespace Process_Note
{
    public partial class FileList : Form
    {
        public FileList()
        {
            InitializeComponent();
        }

        private void FileList_Load(object sender, EventArgs e)
        {
            LoopThroughFolder();
        }

        public void LoopThroughFolder()
        {
            string path = @"C:\Users\User\Documents\codecool\datafiles";
            try
            {

                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] Files = d.GetFiles("*.xml");

                foreach (FileInfo file in Files)
                {
                    listViewFile.Items.Add(file.Name.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void listViewFile_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedFile = listViewFile.SelectedItems[0];
            string fileName = selectedFile.Text;

            this.Hide();

            Form ProcessList = new ProcessList(fileName);
            ProcessList.Closed += (s, args) => this.Close();
            ProcessList.ShowDialog();
        }
    }
}
