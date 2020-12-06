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

        [Display(Name = "User Email")]
        public string userEmail {get; set;}

        [Display(Name = "Title")]
        [Required]
        public string title {get; set;}

        [Display(Name = "Steps")]
        // [NotMapped]
        public List<StepsModel> postSteps {get; set;}

        [Display(Name = "Approved")]
        public bool isApproved {get; set;}
    }

    public class StepsModel
    {
        [Key]
        public int id {get; set;}

        [Display(Name = "Step Text")]
        [Required]
        public string step {get; set;}

        [Display(Name = "Image URL")]
        public string img {get; set;}

        public int postID {get; set;}
    }
}