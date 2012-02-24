using System;
using System.ComponentModel.DataAnnotations;

namespace NoteCards.DomainModel
{
    public class NoteCard
    {
        [Required]
        [RegularExpression(@"^[_0-9a-zA-Z\s\-_]+$", ErrorMessage="Title cannot contain special characters.")]
        public string Title { get; set; }
        [Required]
        public string NoteText { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
