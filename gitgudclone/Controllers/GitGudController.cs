using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using gitgudclone.Data;
using gitgudclone.Models;

namespace Passion_project_git_gud.Controllers
{
    public class GitGudController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GitGudController(ApplicationDbContext context)
        {
            _context = context;
        }

        //=====================Display=============================

        public IActionResult ViewPost()
        {
            return View(_context.postsList);
            // return Content("View Post");
        }

        public IActionResult ViewPostDetails(int postID)
        {
            // return Content("ViewPostDetails");
            PostsModel foundPost = _context.postsList.FirstOrDefault(p => p.id == postID);
            return View(foundPost);
        }

        //=====================Posts=============================

        [HttpPost]
        public IActionResult AddPost(PostsModel newPost)
        {
            // return Content("Add Post");
            // if(ModelState.IsValid)
            // {
            _context.postsList.Add(newPost);
            _context.SaveChanges();
            return Content("Post Added");
            // }
            // else{
            //     return Content("Not Valid");
            // }
        }

        [HttpPost]
        public IActionResult EditPost(PostsModel upPost)
        {

            // return Content("Edit Post");
            PostsModel foundPost = _context.postsList.FirstOrDefault(p => p.id == upPost.id);
            if(foundPost != null)
            {
            foundPost.postBody = upPost.postBody;
            _context.SaveChanges();
            return Content("Post Edited");
            }
            else{
             return Content("Post Not found"); 
            }
        }

        public IActionResult DeletePost(int postID)
        {
            // return Content("Delete Post");
            PostsModel foundPost = _context.postsList.FirstOrDefault(p => p.id == postID);

            if(foundPost != null)
            {
            _context.Remove(foundPost);
            _context.SaveChanges();
            return Content("Post Deleted");
            }
            else{
             return Content("Post Not found"); 
            }
        }

        //=====================Messages=============================

        public IActionResult ViewMessage()
        {
            // return Content("View Messages");
            return View(_context.messagesList);
        }

        public IActionResult ViewMessageDetails(int messageID)
        {
            // return Content("ViewMessageDetails");
            MessagesModel foundMessage = _context.messagesList.FirstOrDefault(m => m.id == messageID);
            return View(foundMessage);
        }

        [HttpPost]
        public IActionResult AddMessage(MessagesModel newMessage)
        {
            // return Content("Add Message");
            // if(ModelState.IsValid)
            // {
            _context.messagesList.Add(newMessage);
            _context.SaveChanges();
            return Content("Message Added");
            // }
            // else{
            //    return Content("Not valid Message");
            // }
        }

        public IActionResult DeleteMessage(int messageID)
        {
            // return Content("Delete Message");
            MessagesModel foundMessage = _context.messagesList.FirstOrDefault(m => m.id == messageID);

            if(foundMessage != null)
            {
            _context.Remove(foundMessage);
            _context.SaveChanges();
            return Content("Message Deleted");
            }
            else{
               return Content("Message not found");
            }
        }

        //=====================Notifications=============================

        public IActionResult ViewNotifications()
        {
            // return Content("ViewNotifications");
            return View(_context.notificationsList);
        }

        public IActionResult ViewNotificationDetails(int notifID)
        {
            // return Content("View Notification Details");
            NotificationsModel foundNotif = _context.notificationsList.FirstOrDefault(n => n.id == notifID);
            return View(foundNotif);
        }

        public IActionResult DeleteNotif(int notifID)
        {
            // return Content("Delete Notification");
            NotificationsModel foundNotif = _context.notificationsList.FirstOrDefault(n => n.id == notifID);

            if(foundNotif != null)
            {
            _context.Remove(foundNotif);
            _context.SaveChanges();
            return Content("Notification Deleted");
            }
            else{
               return Content("Notification not found");
            }
        }

        //====================Post Queue==============================

        public IActionResult ViewQueue()
        {
            // return Content("View Queue");
            return View(_context.postQueueList);
        }

        [HttpPost]
        public IActionResult AddQueue(PostQueueModel newQueue)
        {
            // return Content("Add Post to Queue");

            if(ModelState.IsValid)
            {
            _context.postQueueList.Add(newQueue);
            _context.SaveChanges();
            return Content("Post Added to Queue");
            }
            else{
                return Content("Not Valid Post");
            }
        }
    }
}