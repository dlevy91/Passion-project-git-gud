using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gitgudclone.Models
{
    public class UserModel
    {
        [Key]
        [Display(Name = "ID")]
        public int id {get; set;}

        [Display(Name = "Email")]
        public string userEmail {get; set;}

        [Display(Name = "Screen Name")]
        public string userScreenName {get; set;}

        [Display(Name = "Post")]
        public string userPost {get; set;}

        public List<PostsModel> userFavorites {get; set;}

        public List<MessagesModel> userMessages {get; set;}

        public List<NotificationsModel> userNotifications {get; set;}

        public List<PostQueueModel> postQueue {get; set;}
    }
}