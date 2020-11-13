using System;
using System.ComponentModel.DataAnnotations;

namespace gitgudclone.Models
{
    public class NotificationsModel
    {
        [Key]
        public int id {get; set;}

        public string userEmail {get; set;}

        public bool isUrgent {get; set;}

        public string notificationText {get; set;}
    }
}