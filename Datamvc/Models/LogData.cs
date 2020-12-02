using System.ComponentModel.DataAnnotations;

namespace Datamvc.Models
{
    public class LogData
    {
        [Key]
        public int Id { get; set; }

        public string Category { get; set; }

        public string Message { get; set; }
    }
}
