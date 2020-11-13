using System;
using System.ComponentModel.DataAnnotations;

namespace gitgudclone.Models
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