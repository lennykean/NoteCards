using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NoteCards.DomainModel;
using NoteCards.Presenter;
using NoteCards.View;

namespace NoteCards.Test
{
    [TestClass]
    public class MainPresenterTests
    {
        [TestMethod]
        public void LoadTest()
        {
            var notes = new[] {"Note1", "Note2"};
            var repo = new Mock<INoteCardRepository>();
            var view = new Mock<IMainView>();
            repo.Setup(m => m.NoteCards)
                .Returns(notes)
                .Verifiable();

            var presenter = new MainPresenter(view.Object, repo.Object);

            repo.Verify();
            view.Verify(m => m.LoadNotes(It.IsAny<IEnumerable<string>>()));
            view.VerifySet(m => m.StatusText = "2 Notes");
        }

        [TestMethod]
        public void NewNoteTest()
        {
            var repo = new Mock<INoteCardRepository>();
            var view = new Mock<IMainView>();

            var presenter = new MainPresenter(view.Object, repo.Object);
            view.Raise(m => m.NewNote += null, null, null);

            view.Verify(m => m.ClearSelectedNote());
            view.Verify(m => m.LoadNote(It.IsAny<NoteCard>()));
        }
    }
}
