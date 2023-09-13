using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRestClient.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("FK_Image_Book_1")]
        public int BookId { get; set; }
        public string ImageUrl { get; set; }
    }
}
