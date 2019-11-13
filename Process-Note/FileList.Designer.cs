namespace Process_Note
{
    partial class FileList
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
        protected void InitializeComponent()
        {
            this.listViewFile = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewFile
            // 
            this.listViewFile.HideSelection = false;
            this.listViewFile.Location = new System.Drawing.Point(13, 13);
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(324, 387);
            this.listViewFile.TabIndex = 0;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            this.listViewFile.View = System.Windows.Forms.View.List;
            this.listViewFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewFile_MouseClick);
            // 
            // FileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 412);
            this.Controls.Add(this.listViewFile);
            this.Name = "FileList";
            this.Text = "Saved process lists";
            this.Load += new System.EventHandler(this.FileList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFile;
    }
}