using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gitgudclone.Models
{
    public class AdminModel
    {
        [Key]
        [Display(Name = "ID")]
        public int id {get; set;}

        [Display(Name = "Email")]
        public string adminEmail {get; set;}

        [Display(Name = "Screen Name")]
        public string adminScreenName {get; set;}

        [Display(Name = "Post")]
        public string adminPost {get; set;}

        public List<FavoritesModel> adminFavorites {get; set;}

        public List<MessagesModel> adminMessages {get; set;}

        public List<NotificationsModel> adminNotifications {get; set;}

        public List<PostQueueModel> adminQueue {get; set;}
    }
}