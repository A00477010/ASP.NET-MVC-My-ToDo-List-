using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string name { get; set; }
        [DisplayName ("Display Order")]
        [Range (1,20,ErrorMessage ="Please enter a value which is between 1 and 20")]
        public int displayOrder { get; set; }

        public DateTime createdDate { get; set; } = DateTime.Now;

    }
}
