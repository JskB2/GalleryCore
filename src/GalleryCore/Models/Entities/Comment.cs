using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryCore.Models.Entities
{
    public class Comment
    {
        [Key]
        public int IDComment { get; set; }
        [Required]
        [StringLength(500)]
        public string Content { get; set; }
        public int GalleryPicID { get; set; }
        [ForeignKey("GalleryPicID")]
        public GalleryPic GalleryPic { get; set; }
    }
}
