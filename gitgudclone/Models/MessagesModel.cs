using System;
using System.ComponentModel.DataAnnotations;

namespace gitgudclone.Models
{
    public class MessagesModel
    {
        [Key]
        public int id {get; set;}

        [Display(Name = "User Email")]
        public string userEmail {get; set;}

        [Display(Name = "Recipient Email")]
        public string recipientEmail {get; set;}

        [Display(Name = "Message Date")]
        public DateTime messageDate {get; set;}

        [Display(Name = "Subject")]
        [Required]
        public string subjectLine {get; set;}

        [Display(Name = "Body")]
        [Required]
        public string textBody {get; set;}

        [Display(Name = "Read")]
        public bool isRead {get; set;}
    }
}