using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Note
{
    public partial class Threads : Form
    {
        public Process Process { get; set; }
        public ProcessThreadCollection MyThreads { get; }

        public Threads(Process process)
        {
            InitializeComponent();
            this.Process = process;
            this.MyThreads = process.Threads;
        }

        private void Threads_Load(object sender, EventArgs e)
        {
            foreach (ProcessThread thread in MyThreads)
            {
                threadListBox.Items.Add(thread.Id.ToString());
            }
        }
    }
}
