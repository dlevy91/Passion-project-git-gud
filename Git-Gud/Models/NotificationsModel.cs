using System;
using System.ComponentModel.DataAnnotations;

namespace Passion_project_git_gud.Models
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