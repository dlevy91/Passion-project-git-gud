using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Passion_project_git_gud.Models;

namespace Passion_project_git_gud.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AdminModel> adminList {get; set;}

        public DbSet<FavoritesModel> favoriteList {get; set;}

        public DbSet<MessagesModel> messagesList {get; set;}

        public DbSet<NotificationsModel> notificationsList {get; set;}

        public DbSet<PostQueueModel> postQueueList {get; set;}

        public DbSet<UserModel> userList {get; set;}

        public DbSet<PostsModel> postsList {get; set;}
    }
}
