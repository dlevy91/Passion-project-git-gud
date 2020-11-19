using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gitgudclone.Models
{
    public class PostsModel
    {
        [Key]
        public int id {get; set;}

        [Required]
        public string title {get; set;}

        // [NotMapped]
        public List<StepsModel> postSteps {get; set;}

        // public ICollection<StepsModel> postBody {get; set;}

        // public string postBody {get; set;}

        public bool isApproved {get; set;}
    }

    public class StepsModel
    {
        [Key]
        public int id {get; set;}

        [Required]
        public string step {get; set;}

        public string img {get; set;}
    }
}