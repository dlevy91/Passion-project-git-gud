using System;
using System.ComponentModel.DataAnnotations;

namespace gitgudclone.Models
{
    public class FavoritesModel
    {
        [Key]
        public int id {get; set;}

        public string userEmail {get; set;}

        public bool userFav {get; set;}
    }
}