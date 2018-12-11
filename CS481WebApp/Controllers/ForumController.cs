using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CS481WebApp.Models;
using Microsoft.AspNet.Identity;

namespace CS481WebApp.Controllers
{
    [Authorize]
    public class ForumController : Controller
    {
        private CS481WebApp_dbEntities1 db = new CS481WebApp_dbEntities1();

        // GET: Forum
        public ActionResult Index()
        {
            return View(db.Fora.ToList());
        }

        public ActionResult ViewComments(int? ParentID)
        {
            return View(db.Comments.Where(x => x.ParentID == ParentID).ToList());
        }

        public ActionResult Manage()
        {
            var id = System.Web.HttpContext.Current.User.Identity.GetUserId();
            return View(db.Fora.Where((x => x.UserID == id)).ToList());
        }

        // GET: Forum/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forum forum = db.Fora.Find(id);
            if (forum == null)
            {
                return HttpNotFound();
            }
            return View(forum);
        }

        // GET: Forum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Forum/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Body")] Forum forum)
        {
            if (ModelState.IsValid)
            {
                var userID = System.Web.HttpContext.Current.User.Identity.GetUserId();
                var timestamp = DateTime.Now;
                Forum forumAdd = new Forum
                {
                    ForumID = db.Fora.Count(),
                    UserID = userID,
                    Title = forum.Title,
                    Body = forum.Body,
                    Timestamp = timestamp,
                    Score = 0
                };
                db.Fora.Add(forumAdd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(forum);
        }

        // GET: Forum/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forum forum = db.Fora.Find(id);
            if (forum == null)
            {
                return HttpNotFound();
            }
            return View(forum);
        }

        // POST: Forum/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ForumID,Title,Body,Timestamp,Score,UserID")] Forum forum)
        {
            Forum fa = db.Fora.Find(forum.ForumID);
            fa.Title = forum.Title;
            fa.Body = forum.Body;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Forum/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forum forum = db.Fora.Find(id);
            if (forum == null)
            {
                return HttpNotFound();
            }
            return View(forum);
        }

        // POST: Forum/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Forum forum = db.Fora.Find(id);
            db.Fora.Remove(forum);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateComment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateComment([Bind(Include = "Body, ParentID")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                var userID = System.Web.HttpContext.Current.User.Identity.GetUserId();
                var timestamp = DateTime.Now;
                Comment commentAdd = new Comment
                {
                    CommentID = db.Comments.Count(),
                    Body = comment.Body,
                    ParentID = comment.ParentID
                };
                db.Comments.Add(commentAdd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
