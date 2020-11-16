using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gitgudclone.Models
{
    public class PostsModel
    {
        [Key]
        public int id {get; set;}

        public string postBody {get; set;}
    }
}