using System;
using System.Windows.Forms;
using NoteCards.Presenter;
using NoteCards.View;

namespace NoteCards
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            var presenter = new MainPresenter(mainForm, new NoteCardRepository());

            Application.Run(mainForm);
        }
    }
}
