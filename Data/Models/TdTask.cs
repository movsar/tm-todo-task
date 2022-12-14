using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Data.Models {
    public class TdTask {
    [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }
        [StringLength(200)]
        public string Title { get; set; } = String.Empty;
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; private set; }
        public void SetCompletionStatus(bool isCompleted) {
            IsCompleted = isCompleted;
        }
    }
}
