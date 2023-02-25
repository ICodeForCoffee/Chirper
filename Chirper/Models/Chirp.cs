using System.ComponentModel.DataAnnotations.Schema;

namespace Chirper.Models
{
    public class Chirp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChirpId { get; set; }
        public string MessageText { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
    }
}
