using System.ComponentModel.DataAnnotations;

namespace WebAPI02.Models.Domain
{
    public class Publishers
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        //Navigation Properties - One publisher has many books
        public List<Books>? Book { get; set; }
    }
}
