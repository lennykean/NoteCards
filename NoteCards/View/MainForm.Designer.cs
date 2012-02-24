namespace NoteCards.View
{
    partial class MainForm
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.noteList = new System.Windows.Forms.ListBox();
            this.editPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.editedText = new System.Windows.Forms.TextBox();
            this.createdText = new System.Windows.Forms.TextBox();
            this.noteText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.createdLabel = new System.Windows.Forms.Label();
            this.editedLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.statusBar.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 300);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(404, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(404, 24);
            this.mainMenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newNoteToolStripMenuItem.Text = "New Note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.noteList);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.editPanel);
            this.mainContainer.Size = new System.Drawing.Size(404, 276);
            this.mainContainer.SplitterDistance = 132;
            this.mainContainer.TabIndex = 0;
            // 
            // noteList
            // 
            this.noteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteList.FormattingEnabled = true;
            this.noteList.Location = new System.Drawing.Point(0, 0);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(132, 276);
            this.noteList.TabIndex = 0;
            this.noteList.SelectedValueChanged += new System.EventHandler(this.noteList_SelectedValueChanged);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.deleteButton);
            this.editPanel.Controls.Add(this.saveButton);
            this.editPanel.Controls.Add(this.editedText);
            this.editPanel.Controls.Add(this.createdText);
            this.editPanel.Controls.Add(this.noteText);
            this.editPanel.Controls.Add(this.titleText);
            this.editPanel.Controls.Add(this.createdLabel);
            this.editPanel.Controls.Add(this.editedLabel);
            this.editPanel.Controls.Add(this.noteLabel);
            this.editPanel.Controls.Add(this.titleLabel);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(268, 276);
            this.editPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(100, 239);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(181, 239);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editedText
            // 
            this.editedText.Location = new System.Drawing.Point(59, 173);
            this.editedText.Name = "editedText";
            this.editedText.ReadOnly = true;
            this.editedText.Size = new System.Drawing.Size(147, 20);
            this.editedText.TabIndex = 6;
            this.editedText.TabStop = false;
            // 
            // createdText
            // 
            this.createdText.Location = new System.Drawing.Point(59, 147);
            this.createdText.Name = "createdText";
            this.createdText.ReadOnly = true;
            this.createdText.Size = new System.Drawing.Size(147, 20);
            this.createdText.TabIndex = 5;
            this.createdText.TabStop = false;
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(60, 27);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(196, 114);
            this.noteText.TabIndex = 5;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(60, 4);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(196, 20);
            this.titleText.TabIndex = 4;
            // 
            // createdLabel
            // 
            this.createdLabel.Location = new System.Drawing.Point(4, 150);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(49, 23);
            this.createdLabel.TabIndex = 3;
            this.createdLabel.Text = "Created:";
            // 
            // editedLabel
            // 
            this.editedLabel.Location = new System.Drawing.Point(4, 176);
            this.editedLabel.Name = "editedLabel";
            this.editedLabel.Size = new System.Drawing.Size(49, 23);
            this.editedLabel.TabIndex = 2;
            this.editedLabel.Text = "Edited:";
            // 
            // noteLabel
            // 
            this.noteLabel.Location = new System.Drawing.Point(4, 30);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(49, 23);
            this.noteLabel.TabIndex = 1;
            this.noteLabel.Text = "Note:";
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(4, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(49, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainContainer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(404, 276);
            this.mainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 322);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.statusBar);
            this.MinimumSize = new System.Drawing.Size(420, 360);
            this.Name = "MainForm";
            this.Text = "Note Cards";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ListBox noteList;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox editedText;
        private System.Windows.Forms.TextBox createdText;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label editedLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;

    }
}

