using System.ComponentModel.DataAnnotations;

namespace CutomilyNetCoreTest.Models
{
    public class Page : DateLog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual List<Image> Images { get; set; }
        public virtual List<Text> Texts { get; set; }
    }
}
