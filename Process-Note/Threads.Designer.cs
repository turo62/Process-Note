namespace Process_Note
{
    partial class Threads
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
            this.threadListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // threadListBox
            // 
            this.threadListBox.FormattingEnabled = true;
            this.threadListBox.ItemHeight = 16;
            this.threadListBox.Location = new System.Drawing.Point(13, 13);
            this.threadListBox.Name = "threadListBox";
            this.threadListBox.Size = new System.Drawing.Size(131, 628);
            this.threadListBox.TabIndex = 0;
            // 
            // Threads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 655);
            this.Controls.Add(this.threadListBox);
            this.Name = "Threads";
            this.Text = "Threads of the detailed process";
            this.Load += new System.EventHandler(this.Threads_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox threadListBox;
    }
}