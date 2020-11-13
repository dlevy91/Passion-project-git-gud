using System;
using System.ComponentModel.DataAnnotations;

namespace gitgudclone.Models
{
    public class PostQueueModel
    {
        [Key]
        public int id {get; set;}

        public string authorEmail {get; set;}

        public string postBody {get; set;}
    }
}