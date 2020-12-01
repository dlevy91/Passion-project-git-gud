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

        public DateTime messageDate {get; set;}

        [Required]
        public string subjectLine {get; set;}

        [Required]
        public string textBody {get; set;}

        public bool isRead {get; set;}
    }
}