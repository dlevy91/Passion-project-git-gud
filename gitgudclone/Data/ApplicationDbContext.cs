using System;
using System.Collections.Generic;
using System.Text;
using gitgudclone.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace gitgudclone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MessagesModel> messagesList {get; set;}

        public DbSet<NotificationsModel> notificationsList {get; set;}

        public DbSet<UserModel> userList {get; set;}

        public DbSet<PostsModel> postsList {get; set;}
    }
}
