using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotissimusTesting.DAL.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        [ForeignKey(nameof(ParentCategory))]
        public int? ParentId { get; set; }
        public Category? ParentCategory { get; set; }
    }
}
