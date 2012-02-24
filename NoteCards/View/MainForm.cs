using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NoteCards.DomainModel;

namespace NoteCards.View
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler NewNote;
        public event EventHandler NoteSelected;
        public event EventHandler SaveNote;
        public event EventHandler DeleteNote;

        public string SelectedNote
        {
            get { return noteList.SelectedItem as string; }
            set { noteList.SelectedItem = value; }
        }

        public string StatusText
        {
            get { return statusLabel.Text; }
            set { statusLabel.Text = value; }
        }

        public string Title
        {
            get { return Text; }
            set { Text = value; }
        }

        public void DisplayMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public void ClearSelectedNote()
        {
            noteList.ClearSelected();
        }

        public void SetSelectedNote(string title)
        {
            noteList.SelectedItem = title;
        }

        public void LoadNotes(IEnumerable<string> notes)
        {
            noteList.DataSource = notes.ToList();
        }

        public void LoadNote(NoteCard note)
        {
            titleText.Text = note.Title;
            noteText.Text = note.NoteText;
            createdText.Text = String.Format("{0}", note.CreateDate);
            editedText.Text = String.Format("{0}", note.EditDate);
        }

        public NoteCard GetNote()
        {
            return new NoteCard
            {
                Title = titleText.Text,
                NoteText = noteText.Text
            };
        }
        
        private void noteList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (NoteSelected != null)
                NoteSelected(sender, e);
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NewNote != null)
                NewNote(sender, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveNote != null)
                SaveNote(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteNote != null)
                DeleteNote(sender, e);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
