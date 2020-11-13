using System;
using System.ComponentModel.DataAnnotations;

namespace Passion_project_git_gud.Models
{
    public class FavoritesModel
    {
        [Key]
        public int id {get; set;}

        public string userEmail {get; set;}

        public bool userFav {get; set;}
    }
}