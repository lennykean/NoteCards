
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using NoteCards.DomainModel;
using NoteCards.View;

namespace NoteCards.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly INoteCardRepository _repository;

        public MainPresenter(IMainView view, INoteCardRepository repository)
        {
            _view = view;
            _repository = repository;

            view.NewNote += NewNote;
            view.NoteSelected += NoteSelected;
            view.SaveNote += SaveNote;
            view.DeleteNote += DeleteNote;

            LoadNotes();
        }

        public void LoadNotes()
        {
            var notes = _repository.NoteCards.ToList();

            _view.LoadNotes(notes);
            _view.StatusText = String.Format("{0} Notes", notes.Count);
        }

        private void NewNote(object sender, EventArgs e)
        {
            _view.ClearSelectedNote();
            _view.LoadNote(new NoteCard());
        }

        private void NoteSelected(object sender, EventArgs e)
        {
            if (!_repository.NoteExists(_view.SelectedNote))
                return;

            var note = _repository.GetNote(_view.SelectedNote);
            
            _view.LoadNote(note);
            _view.Title = String.Format("Note Cards - {0}", note.Title);
        }

        private void SaveNote(object sender, EventArgs e)
        {
            var note = _view.GetNote();
            var results = new List<ValidationResult>();
            var context = new ValidationContext(note, null, null);

            if (Validator.TryValidateObject(note, context, results, true))
            {
                _repository.Save(note);
                LoadNotes();
                _view.SelectedNote = note.Title;
            }
            else
            {
                var validationMessage = String.Join("\n", results.Select(t => String.Format("- {0}", t.ErrorMessage)));

                _view.DisplayMessage("Validation Error", validationMessage);
            }
        }

        private void DeleteNote(object sender, EventArgs e)
        {
            var note = _view.GetNote();

            _repository.Delete(note); 

            LoadNotes();
            _view.ClearSelectedNote();
            _view.LoadNote(new NoteCard());
        }
    }
}
