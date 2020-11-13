using System;
using System.ComponentModel.DataAnnotations;

namespace Passion_project_git_gud.Models
{
    public class PostQueueModel
    {
        [Key]
        public int id {get; set;}

        public string authorEmail {get; set;}

        public string postBody {get; set;}
    }
}