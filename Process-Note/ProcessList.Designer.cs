namespace Process_Note
{
    partial class ProcessList
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
            this.components = new System.ComponentModel.Container();
            this.saveProcesses = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processDetails = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.details = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpuUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memoryUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.runningTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.threads = new System.Windows.Forms.Button();
            this.addNote = new System.Windows.Forms.Button();
            this.alwaysOnTop = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.modeText = new System.Windows.Forms.Label();
            this.loadFromFile = new System.Windows.Forms.Button();
            this.load_active_Processes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveProcesses
            // 
            this.saveProcesses.Location = new System.Drawing.Point(1023, 555);
            this.saveProcesses.Name = "saveProcesses";
            this.saveProcesses.Size = new System.Drawing.Size(90, 31);
            this.saveProcesses.TabIndex = 0;
            this.saveProcesses.Text = "Save list";
            this.saveProcesses.UseVisualStyleBackColor = true;
            this.saveProcesses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveProcesses_MouseClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pID,
            this.processName});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1097, 302);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyProcesses_MouseClick);
            // 
            // pID
            // 
            this.pID.Text = "ID";
            this.pID.Width = 79;
            // 
            // processName
            // 
            this.processName.Text = "Process name";
            this.processName.Width = 1015;
            // 
            // processDetails
            // 
            this.processDetails.AutoSize = true;
            this.processDetails.Location = new System.Drawing.Point(10, 341);
            this.processDetails.Name = "processDetails";
            this.processDetails.Size = new System.Drawing.Size(104, 17);
            this.processDetails.TabIndex = 3;
            this.processDetails.Text = "Process details";
            // 
            // details
            // 
            this.details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.cpuUsage,
            this.memoryUsage,
            this.runningTime,
            this.startTime,
            this.comment});
            this.details.HideSelection = false;
            this.details.Location = new System.Drawing.Point(13, 361);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(1097, 154);
            this.details.TabIndex = 4;
            this.details.UseCompatibleStateImageBehavior = false;
            this.details.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 377;
            // 
            // cpuUsage
            // 
            this.cpuUsage.Text = "CPU usage";
            this.cpuUsage.Width = 74;
            // 
            // memoryUsage
            // 
            this.memoryUsage.Text = "Memory usage";
            this.memoryUsage.Width = 64;
            // 
            // runningTime
            // 
            this.runningTime.Text = "Running time";
            this.runningTime.Width = 90;
            // 
            // startTime
            // 
            this.startTime.Text = "Start time";
            this.startTime.Width = 144;
            // 
            // comment
            // 
            this.comment.Text = "Note";
            this.comment.Width = 260;
            // 
            // threads
            // 
            this.threads.Location = new System.Drawing.Point(1023, 518);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(90, 31);
            this.threads.TabIndex = 7;
            this.threads.Text = "Threads";
            this.threads.UseVisualStyleBackColor = true;
            this.threads.Click += new System.EventHandler(this.Threads_Click);
            // 
            // addNote
            // 
            this.addNote.Location = new System.Drawing.Point(916, 518);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(90, 31);
            this.addNote.TabIndex = 8;
            this.addNote.Text = "Add note";
            this.addNote.UseVisualStyleBackColor = true;
            this.addNote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddNote_MouseClick);
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.AutoSize = true;
            this.alwaysOnTop.Location = new System.Drawing.Point(993, 10);
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.Size = new System.Drawing.Size(117, 21);
            this.alwaysOnTop.TabIndex = 10;
            this.alwaysOnTop.Text = "Always on top";
            this.alwaysOnTop.UseVisualStyleBackColor = true;
            this.alwaysOnTop.CheckedChanged += new System.EventHandler(this.AlwaysOnTop_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 518);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(762, 68);
            this.textBox1.TabIndex = 11;
            this.textBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(916, 555);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(90, 31);
            this.refresh.TabIndex = 12;
            this.refresh.Text = "Refresh view";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // modeText
            // 
            this.modeText.AutoSize = true;
            this.modeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeText.Location = new System.Drawing.Point(513, 6);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(83, 25);
            this.modeText.TabIndex = 13;
            this.modeText.Text = "isOnline";
            // 
            // loadFromFile
            // 
            this.loadFromFile.Location = new System.Drawing.Point(781, 555);
            this.loadFromFile.Name = "loadFromFile";
            this.loadFromFile.Size = new System.Drawing.Size(129, 31);
            this.loadFromFile.TabIndex = 15;
            this.loadFromFile.Text = "Load saved data";
            this.loadFromFile.UseVisualStyleBackColor = true;
            this.loadFromFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoadFromFile_MouseClick);
            // 
            // load_active_Processes
            // 
            this.load_active_Processes.Location = new System.Drawing.Point(781, 518);
            this.load_active_Processes.Name = "load_active_Processes";
            this.load_active_Processes.Size = new System.Drawing.Size(129, 31);
            this.load_active_Processes.TabIndex = 16;
            this.load_active_Processes.Text = "Turn online";
            this.load_active_Processes.UseVisualStyleBackColor = true;
            this.load_active_Processes.Click += new System.EventHandler(this.load_active_Processes_Click);
            // 
            // ProcessList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 602);
            this.Controls.Add(this.load_active_Processes);
            this.Controls.Add(this.loadFromFile);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.alwaysOnTop);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.threads);
            this.Controls.Add(this.details);
            this.Controls.Add(this.processDetails);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.saveProcesses);
            this.Name = "ProcessList";
            this.Text = "Running processes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessList_FormClosing);
            this.Load += new System.EventHandler(this.ProcessList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveProcesses;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader pID;
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.Label processDetails;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView details;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader cpuUsage;
        private System.Windows.Forms.ColumnHeader memoryUsage;
        private System.Windows.Forms.ColumnHeader runningTime;
        private System.Windows.Forms.ColumnHeader startTime;
        private System.Windows.Forms.ColumnHeader comment;
        private System.Windows.Forms.Button threads;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.CheckBox alwaysOnTop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label modeText;
        private System.Windows.Forms.Button loadFromFile;
        private System.Windows.Forms.Button load_active_Processes;
    }
}