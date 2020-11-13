using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Passion_project_git_gud.Models
{
    public class PostsModel
    {
        [Key]
        public int id {get; set;}

        public int postBody {get; set;}
    }
}