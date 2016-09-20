using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryCore.Models.Entities
{
    public class GalleryPic
    {
        [Key]
        public int IDPic { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        public string Url { get; set; }
        public DateTime UploadDate { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
