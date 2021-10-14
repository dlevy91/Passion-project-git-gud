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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using iText.IO.Image;
using iText.Kernel.Colors;

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

        public IActionResult ViewUserPosts()
        {
            List<PostsModel> foundPosts = _context.postsList.Include(p => p.postSteps).ToList();
            return View(_context); 
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
            foundPost.title = upPost.title;
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

            return RedirectToAction("AddStepForm", new {postID = foundPost.id});
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
            newMessage.messageDate = DateTime.Now;
            _context.messagesList.Add(newMessage);
            _context.SaveChanges();
            return RedirectToAction("ViewMessages");
            }
            else{
               return Content("Not valid Message");
            }
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult AddMessageForm(string recipientEmail, string userEmail, string postTitle, string subjectLine)
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

//============================================================Create PDF function====================================================================================
        public IActionResult Pdf(int postID)
        {
            PostsModel foundPost = _context.postsList.Include(p => p.postSteps).FirstOrDefault(p => p.id == postID);
            

            MemoryStream ms = new MemoryStream();
            
            PdfWriter writer = new PdfWriter(ms);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph(foundPost.title)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(30)
                .SetBold()
                .SetBackgroundColor(ColorConstants.ORANGE);

            document.Add(header);

            foreach (StepsModel step in foundPost.postSteps)
            {
             Paragraph body = new Paragraph(step.step)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY);   
             String imageUrl = step.img;
             ImageData data = ImageDataFactory.Create(imageUrl);
             Image img = new Image(data)
                .SetMarginLeft(100)
                .SetMarginRight(100)
                .SetWidth(200)
                .SetAutoScaleHeight(true);
            
            document.Add(body);
            document.Add(img);
            }           

            
            
            document.Close();

            byte[] bytesStream = ms.ToArray();
            ms = new MemoryStream();
            ms.Write(bytesStream, 0, bytesStream.Length);
            ms.Position = 0;

            //TODO update what is returned to display post title in tab instead of "pdf"
            return new FileStreamResult(ms,"application/pdf");
        }

    }
}