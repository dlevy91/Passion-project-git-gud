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

        public IActionResult ViewPosts()
        {
            List<PostsModel> foundPosts = _context.postsList.Include(p => p.postSteps).ToList();
            return View(_context);
            // return Content("View Post");
        }

        public IActionResult ViewPostDetails(int postID)
        {
            // return Content("ViewPostDetails");
            PostsModel foundPost = _context.postsList.Include(p => p.postSteps).FirstOrDefault(p => p.id == postID);
            return View(foundPost);
            // return Content($"{foundPost.title} and {foundPost.postBody}");
        }
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Add=============================
        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public IActionResult AddPost(PostsModel newPost)
        {
            // return Content("Add Post");
            if(ModelState.IsValid)
            {
            _context.postsList.Add(newPost);
            _context.SaveChanges();
            return RedirectToAction("AddStepForm", new {postID = newPost.id});
            // return Content("Post Created");
            }
            else{
                return Content("Not Valid");
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult AddPostForm(string userEmail)
        {
            return View();
        }
            
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Edit=============================
        
        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public IActionResult EditPost(PostsModel upPost)
        {

            // return Content("Edit Post");
            PostsModel foundPost = _context.postsList.FirstOrDefault(p => p.id == upPost.id);
            if(foundPost != null)
            {
            foundPost.postSteps = upPost.postSteps;
            foundPost.isApproved = upPost.isApproved;
            _context.SaveChanges();
            return RedirectToAction("ViewPosts");
            }
            else{
             return Content("Post Not found"); 
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult EditPostForm(int postID)
        {
            PostsModel foundPost = _context.postsList.FirstOrDefault(p => p.id == postID);
            if(foundPost != null)
            {
                return View(foundPost);
            }
            else
            {
                return Content("No Post with that ID");
            }
        }
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Delete=============================

        [Authorize(Roles = "admin, user")]
        public IActionResult DeletePostConf(int postID)
        {
            PostsModel foundPost = _context.postsList.FirstOrDefault(p => p.id == postID);
            if (foundPost != null)
            {
                return View(foundPost);
            }
            else{
                return Content("No post found with that ID");
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult DeletePost(int postID)
        {
            // return Content("Delete Post");
            PostsModel foundPost = _context.postsList.FirstOrDefault(p => p.id == postID);

            if(foundPost != null)
            {
            _context.Remove(foundPost);
            _context.SaveChanges();
            return RedirectToAction("ViewPosts");
            }
            else{
             return Content("Post Not found"); 
            }
        }


////////////////////////////////////////////////////////////////////////////////////////////
        //========================Steps=============================

        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public IActionResult AddStep(StepsModel newStep, int postID)
        {
            PostsModel foundPost = _context.postsList.Include(p => p.postSteps).FirstOrDefault(p => p.id == postID);
            if(foundPost != null)
            {
            foundPost.postSteps.Add(newStep);
            _context.SaveChanges();

            return RedirectToAction("ViewPosts");
            // return Content("Step Added");
            }
            else{
                return Content("Post not found!");
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult AddStepForm(int postID)
        {
            ViewData["postID"] = postID;
            return View();
        }

        //========================Edit==============================

        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public IActionResult EditStep(StepsModel upStep)
        {
            StepsModel foundStep = _context.stepsList.FirstOrDefault(s => s.id == upStep.id);

            if(foundStep != null)
            {
                foundStep.img = upStep.img;
                foundStep.step = upStep.step;

                _context.SaveChanges();
                return RedirectToAction("ViewPosts");
            }
            else{
                return Content("No step found with that ID");
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult EditStepForm(int stepID)
        {
            StepsModel foundStep = _context.stepsList.FirstOrDefault(s => s.id == stepID);

            if(foundStep != null)
            {
                return View(foundStep);
            }
            else{
                return Content("This step does not exist.");
            }
        }

        //========================Delete==============================

        [Authorize(Roles = "admin, user")]
        public IActionResult DeleteStep(int stepID)
        {
            StepsModel foundStep = _context.stepsList.FirstOrDefault(s => s.id == stepID);

            if(foundStep != null)
            {
                _context.Remove(foundStep);

                _context.SaveChanges();
                return RedirectToAction("ViewPosts");
            }
            else{
                return Content("No step found with that ID");
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult DeleteStepConf(int stepID)
        {
            StepsModel foundStep = _context.stepsList.FirstOrDefault(s => s.id == stepID);

            if(foundStep != null)
            {
                return View(foundStep);
            }
            else{
                return Content("No step found with that ID");
            }
        }

        //=====================Messages=============================

        [Authorize(Roles = "admin, user")]
        public IActionResult ViewMessages()
        {
            // return Content("View Messages");
            return View(_context);
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult ViewMessageDetails(int messageID)
        {
            // return Content("ViewMessageDetails");
            MessagesModel foundMessage = _context.messagesList.FirstOrDefault(m => m.id == messageID);

            foundMessage.isRead = true;

            _context.SaveChanges();

            return View(foundMessage);
        }
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Add=============================

        [Authorize(Roles = "admin, user")]
        [HttpPost]
        public IActionResult AddMessage(MessagesModel newMessage)
        {
            // return Content("Add Message");
            if(ModelState.IsValid)
            {
            _context.messagesList.Add(newMessage);
            _context.SaveChanges();
            return RedirectToAction("ViewMessages");
            }
            else{
               return Content("Not valid Message");
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult AddMessageForm(string recipientEmail, string userEmail)
        {
            return View();
        } 
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Delete=============================

        [Authorize(Roles = "admin, user")]
        public IActionResult DeleteMessageConf(int messageID)
        {
            MessagesModel foundMessage = _context.messagesList.FirstOrDefault(m => m.id == messageID);
            if (foundMessage != null)
            {
                return View(foundMessage);
            }
            else{
                return Content("No message found with that ID");
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult DeleteMessage(int messageID)
        {
            // return Content("Delete Message");
            MessagesModel foundMessage = _context.messagesList.FirstOrDefault(m => m.id == messageID);

            if(foundMessage != null)
            {
            _context.Remove(foundMessage);
            _context.SaveChanges();
            return RedirectToAction("ViewMessages");
            }
            else{
               return Content("Message not found");
            }
        }

        //=====================Notifications=============================

        [Authorize(Roles = "admin, user")]
        public IActionResult ViewNotifications()
        {
            // return Content("ViewNotifications");
            return View(_context);
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult ViewNotificationDetails(int notifID)
        {
            // return Content("View Notification Details");
            NotificationsModel foundNotif = _context.notificationsList.FirstOrDefault(n => n.id == notifID);
            return View(foundNotif);
        }
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Add=============================

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult AddNotif(NotificationsModel newNotification)
        {
            if(ModelState.IsValid)
            {
            _context.notificationsList.Add(newNotification);
            _context.SaveChanges();
            return RedirectToAction("ViewNotifications");
            }
            else{
               return Content("Not valid Notification");
            }
        }

        [Authorize(Roles = "admin")]
        public IActionResult AddNotifForm()
        {
            return View();
        }
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Delete=============================

        [Authorize(Roles = "admin, user")]
        public IActionResult DeleteNotifConf(int notifID)
        {
            NotificationsModel foundNotif = _context.notificationsList.FirstOrDefault(n => n.id == notifID);
            if(foundNotif != null)
            {
                return View(foundNotif);
            }
            else{
                return Content("No notification found with that ID");
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult DeleteNotif(int notifID)
        {
            // return Content("Delete Notification");
            NotificationsModel foundNotif = _context.notificationsList.FirstOrDefault(n => n.id == notifID);

            if(foundNotif != null)
            {
            _context.Remove(foundNotif);
            _context.SaveChanges();
            return RedirectToAction("ViewNotifications");
            }
            else{
               return Content("Notification not found");
            }
        }

    }
}