
using System;
using System.Collections.Generic;
using NoteCards.DomainModel;

namespace NoteCards.View
{
    public interface IMainView
    {
        event EventHandler NewNote;
        event EventHandler NoteSelected;
        event EventHandler SaveNote;
        event EventHandler DeleteNote;

        string SelectedNote { get; set; }
        string StatusText { get; set; }
        string Title { get; set; }

        void DisplayMessage(string title, string message);
        void ClearSelectedNote();
        void LoadNotes(IEnumerable<string> notes);
        void LoadNote(NoteCard note);
        NoteCard GetNote();
    }
}
