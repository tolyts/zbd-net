using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace zbd_net.Models {
    public class Story__c {
        [Key]
        public int id { get; set;}
        [Required]
        public string headline__c { get; set; }
        public string body__c { get; set; }
        public string story_id__c { get; set; }
        public string image__c { get; set; }     
    }
}