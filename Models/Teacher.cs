using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public int CathedraId { get; set; }
        public virtual Cathedra Cathedra { get; set; }

        [JsonIgnore]
        public virtual ICollection<Lesson> Lessons { get; set; }


        public override string ToString()
        {
            return Id + " " + Name + " " + Cathedra;
        } 
    }
}
