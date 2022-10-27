using System.ComponentModel.DataAnnotations;

namespace CutomilyNetCoreTest.Models
{
    public class Text : DateLog
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public int PageId { get; set; }

        public virtual Page Page { get; set; }
    }
}
