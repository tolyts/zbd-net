using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace zbd_net.Models {
    public class Contact {
        [Key]
        public int id { get; set;}
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }     
    }
}