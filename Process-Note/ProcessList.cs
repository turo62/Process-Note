using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Process_Note
{
    public partial class ProcessList : Form
    {
        BaseProcess selectedProcess;
        List<BaseProcess> MyProcesses { get; set; }
        List<BaseProcess> processList;
        Process actProcess;
        Dictionary<string, string> notedProcess = new Dictionary<string, string>();
        List<BaseProcess> Processes = new List<BaseProcess>();
        public ProcessList()
        {
            InitializeComponent();
            refresh.Enabled = true;
            threads.Enabled = true;
            addNote.Enabled = true;
            saveProcesses.Enabled = true;
            load_active_Processes.Enabled = false;
            loadFromFile.Enabled = true;
            textBox1.Enabled = true;

        }
        
        public ProcessList(string selectedFile)
        {
            
            InitializeComponent();
            MyProcesses = ReadFromXML(selectedFile);

            var actList = MyProcesses.OrderBy(BaseProcess => BaseProcess.Name);
            List<BaseProcess> processList = actList.ToList();

            GenerateListView(processList);

            refresh.Enabled = false;
            threads.Enabled = false;
            addNote.Enabled = false;
            saveProcesses.Enabled = false;
            load_active_Processes.Enabled = true;
            loadFromFile.Enabled = false;
            textBox1.Enabled = false;
        }

        private void ProcessList_Load(object sender, EventArgs e)
        {
            GetActiveProcessList();

            if(refresh.Enabled)
            {
                modeText.Text = "online";
            }
            else
            {
                modeText.Text = "offline";
            }
        }

        private List<BaseProcess> GetActiveProcessList()
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process tempProcess in processList)
            {
                if (tempProcess != null && tempProcess.Id > 0)
                {
                    try
                    {
                        DateTime startTime = tempProcess.StartTime;
                        Processes.Add(new BaseProcess(tempProcess));
                    }
                    catch (UnauthorizedAccessException)
                    {
                        continue;
                    }
                    catch (Win32Exception)
                    {
                        continue;
                    }
                    catch (InvalidOperationException)
                    {
                        continue;
                    }
                }

                textBox1.Text = "Enter some text here";

            }

            var actList = Processes.OrderBy(process => process.Name);
            this.processList = actList.ToList();
            GenerateListView(this.processList);

            return Processes;
        }

        private void GenerateListView(List<BaseProcess> baseProcesses)
        {
            foreach (BaseProcess tempProcess in baseProcesses)
            {
                ListViewItem item = new ListViewItem(tempProcess.PID.ToString());
                item.SubItems.Add(tempProcess.Name.ToString());
                listView1.Items.Add(item);
            }
        }

        private void AlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = alwaysOnTop.Checked;
        }

        private void MyProcesses_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            if (selectedItem == null) return;
            selectedProcess = GetProcessByID(selectedItem.Text);
            AddNewItemToDetails();
        }

        private BaseProcess GetProcessByID(string id) 
        {
            foreach(BaseProcess actProcess in processList)
            {
                if(actProcess.PID.Equals(id))
                {
                    return actProcess;
                }
            }
            return null;
        }

        private void AddNewItemToDetails()
        {
            if(details.Items.Count  > 0)
            { details.Items.Clear();
            }
            if(selectedProcess != null)
            {
                ListViewItem item = new ListViewItem(selectedProcess.PID);
                item.SubItems.Add(selectedProcess.Name);
                item.SubItems.Add(selectedProcess.CPUUsage);
                item.SubItems.Add(selectedProcess.MemoryUsage);
                item.SubItems.Add(selectedProcess.RunningTime);
                item.SubItems.Add(selectedProcess.StartTime);
                item.SubItems.Add(selectedProcess.Comment);

                details.Items.Add(item);
            }
        }

        private void Threads_Click(object sender, EventArgs e)
        {
            actProcess = Process.GetProcessById(int.Parse(selectedProcess.PID));
            Form threadList = new Threads(actProcess);
            threadList.ShowDialog();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter some text here")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Red;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter some text here";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            GetActiveProcessList();
            details.Items.Clear();
        }

        private void AddNote_MouseClick(object sender, MouseEventArgs e)
        {
            SaveNote();
        }

        private void SaveNote()
        {
            if (textBox1.Text.Length > 0 && textBox1.Text != "Enter some text here")
            {
                if (notedProcess.ContainsKey(selectedProcess.PID))
                {
                    notedProcess[selectedProcess.PID] = notedProcess[selectedProcess.PID] + ", " + textBox1.Text;
                    selectedProcess.Comment = selectedProcess.Comment + ", " + textBox1.Text;
                    AddNewItemToDetails();
                }
                else
                {
                    notedProcess.Add(selectedProcess.PID, textBox1.Text);
                    selectedProcess.Comment = textBox1.Text;
                    AddNewItemToDetails();
                }

                textBox1.Text = "";
            }
        }

        private void ProcessList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text != "Enter some text here")
            {

                if (MessageBox.Show("Do you want to save changes to your text?", "ProcessNote",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveNote();
                }
            }
        }

        private void SaveProcesses_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text != "Enter some text here")
            {

                if (MessageBox.Show("Do you want to save changes to your text?", "ProcessNote",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveNote();
                }
            }

            SaveProcesses();
        }

        private void SaveProcesses()
        {
            Directory.SetCurrentDirectory(@"C:\Users\User\Documents\codecool\datafiles");
            var myUniqueFileName = $@"savedProcesses{DateTime.Now.Ticks}.xml"; //Generates unique file name
            Stream str = File.OpenWrite (myUniqueFileName);
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<BaseProcess>));

            xmlSer.Serialize(str, Processes);
            str.Close();
        }

        private List<BaseProcess> ReadFromXML(string fileName)
        {
            Directory.SetCurrentDirectory(@"C:\Users\User\Documents\codecool\datafiles");

            XmlSerializer xmlSer = new XmlSerializer(typeof(List<BaseProcess>));
            Stream str = File.OpenRead(fileName);

            Processes = (List<BaseProcess>)xmlSer.Deserialize(str);

            return Processes;
        }

        private void LoadFromFile_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            FileList myFiles = new FileList();
            myFiles.Closed += (s, args) => this.Close();
            myFiles.Show();
        }

        private void load_active_Processes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcessList actProcessList = new ProcessList();
            actProcessList.Closed += (s, args) => this.Close();
            actProcessList.Show();
        }
    }
}
