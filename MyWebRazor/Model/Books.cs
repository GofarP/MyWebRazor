using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyWebRazor.Model
{
    public class Books
    {
        public int id { get; set; }
        [Required]
        [DisplayName("Book Title")]
        public string BookTitle { get; set; }

        [DisplayName("Book Description")]
        public string BookDescription { get; set; }

        [Required]
        public string Author { get; set; }


    }
}
