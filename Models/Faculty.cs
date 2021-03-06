﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Teacher> Teachers { get; set; }

        public Faculty()
        {
            Teachers = new List<Teacher>();
        }
    }
}
