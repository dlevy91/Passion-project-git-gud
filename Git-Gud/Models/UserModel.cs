using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Passion_project_git_gud.Models
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

        public List<FavoritesModel> userFavorites {get; set;}

        public List<MessagesModel> userMessages {get; set;}

        public List<NotificationsModel> userNotifications {get; set;}

        public List<PostQueueModel> adminWarning {get; set;}
    }
}