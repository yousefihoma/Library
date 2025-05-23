using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel.Entities
{
    public class ProfileImage
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public byte[]? Picture { get; set; }
    }
}
