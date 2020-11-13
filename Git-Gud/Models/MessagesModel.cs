using System;
using System.ComponentModel.DataAnnotations;

namespace Passion_project_git_gud.Models
{
    public class MessagesModel
    {
        [Key]
        public int id {get; set;}

        public string userEmail {get; set;}

        public string recipientEmail {get; set;}

        public string textBody {get; set;}
    }
}