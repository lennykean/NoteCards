
using System.Collections.Generic;
using NoteCards.DomainModel;

namespace NoteCards
{
    public interface INoteCardRepository
    {
        IEnumerable<string> NoteCards { get; }

        NoteCard GetNote(string title);
        bool NoteExists(string title);
        void Save(NoteCard note);
        void Delete(NoteCard note);
    }
}
