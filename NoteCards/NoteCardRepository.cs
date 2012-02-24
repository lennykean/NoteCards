using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NoteCards.DomainModel;

namespace NoteCards
{
    public class NoteCardRepository : INoteCardRepository
    {
        private string BaseDirectory
        {
            get { return Path.GetDirectoryName(Application.ExecutablePath); }
        }

        public IEnumerable<string> NoteCards
        {
            get 
            {
                return 
                    from f in Directory.GetFiles(BaseDirectory, "*.note")
                    select Path.GetFileNameWithoutExtension(f);
            }
        }

        public NoteCard GetNote(string title)
        {
            var file = Path.Combine(BaseDirectory, title + ".note");

            return new NoteCard
            {
                Title = title,
                NoteText = File.ReadAllText(file),
                CreateDate = File.GetCreationTime(file),
                EditDate = File.GetLastWriteTime(file)
            };
        }

        public bool NoteExists(string title)
        {
            var file = Path.Combine(BaseDirectory, title + ".note");

            return File.Exists(file);
        }

        public void Save(NoteCard note)
        {
            var file = Path.Combine(BaseDirectory, note.Title + ".note");

            File.WriteAllText(file, note.NoteText);
        }

        public void Delete(NoteCard note)
        {
            var file = Path.Combine(BaseDirectory, note.Title + ".note");

            File.Delete(file);
        }
    }
}
