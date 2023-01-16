using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display (Name ="Display Order")]   
        [Range(1,100,ErrorMessage ="Value should be between 1-100.")]
        public int DisplayOrder { get; set; }
    }
}
