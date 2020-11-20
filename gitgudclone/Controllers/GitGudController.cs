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

        [HttpPost]
        public IActionResult AddPost(PostsModel newPost)
        {
            // return Content("Add Post");
            // if(ModelState.IsValid)
            // {
            
            _context.postsList.Add(newPost);
            _context.SaveChanges();


            return RedirectToAction("AddStepForm", new {postID = newPost.id});
            // return Content("Post Created");
            // }
            // else{
            //     return Content("Not Valid");
            // }
        }

        public IActionResult AddPostForm()
        {
            return View();
        }
            
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Edit=============================

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

        public IActionResult AddStepForm(int postID)
        {
            ViewData["postID"] = postID;
            return View();
        }

        //========================Edit==============================

        [HttpPost]
        public IActionResult EditStep(StepsModel upStep, int stepID)
        {
            StepsModel foundStep = _context.stepsList.FirstOrDefault(s => s.id == stepID);

            if(foundStep != null)
            {
                foundStep.img = upStep.img;
                foundStep.step = upStep.step;

                _context.SaveChanges();
                return Content("Step updated!");
            }
            else{
                return Content("No step found with that ID");
            }
        }

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

        public IActionResult DeleteStep(int stepID)
        {
            StepsModel foundStep = _context.stepsList.FirstOrDefault(s => s.id == stepID);

            if(foundStep != null)
            {
                _context.Remove(foundStep);

                _context.SaveChanges();
                return Content("Step deleted!");
            }
            else{
                return Content("No step found with that ID");
            }
        }

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

        public IActionResult ViewMessages()
        {
            // return Content("View Messages");
            return View(_context);
        }

        public IActionResult ViewMessageDetails(int messageID)
        {
            // return Content("ViewMessageDetails");
            MessagesModel foundMessage = _context.messagesList.FirstOrDefault(m => m.id == messageID);
            return View(foundMessage);
        }
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Add=============================

        [HttpPost]
        public IActionResult AddMessage(MessagesModel newMessage)
        {
            // return Content("Add Message");
            // if(ModelState.IsValid)
            // {
            _context.messagesList.Add(newMessage);
            _context.SaveChanges();
            return RedirectToAction("ViewMessages");
            // }
            // else{
            //    return Content("Not valid Message");
            // }
        }

        public IActionResult AddMessageForm()
        {
            return View();
        }
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Delete=============================

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

        public IActionResult ViewNotifications()
        {
            // return Content("ViewNotifications");
            return View(_context);
        }

        public IActionResult ViewNotificationDetails(int notifID)
        {
            // return Content("View Notification Details");
            NotificationsModel foundNotif = _context.notificationsList.FirstOrDefault(n => n.id == notifID);
            return View(foundNotif);
        }
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Add=============================

        [HttpPost]
        public IActionResult AddNotif(NotificationsModel newNotification)
        {
            // if(ModelState.IsValid)
            // {
            _context.notificationsList.Add(newNotification);
            _context.SaveChanges();
            return RedirectToAction("ViewNotifications");
            // }
            // else{
            //    return Content("Not valid Notification");
            // }
        }

        public IActionResult AddNotifForm()
        {
            return View();
        }
////////////////////////////////////////////////////////////////////////////////////////////

        //=====================Delete=============================

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