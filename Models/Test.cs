using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dockerapi.Models
{
#pragma warning disable CS1591
    public class Test
    {
        public int Id { get; set; }
        public string Handle { get; set; }
    }
#pragma warning restore CS1591
}