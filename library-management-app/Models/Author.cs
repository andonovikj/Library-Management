using System.ComponentModel.DataAnnotations;

namespace library_management_app.Models
{
    public class Author
    {
        
        public int AuthorId { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
