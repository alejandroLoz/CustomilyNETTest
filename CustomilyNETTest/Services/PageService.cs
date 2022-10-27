using CustomilyNETTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.UI.WebControls;

namespace CustomilyNETTest.Services
{
    public class PageService
    {
        private PagesDbContext _db = new PagesDbContext();
        
        public PageService()
        {
            
        }
        
        public void SavePage(PageViewModel page)
        {
            using (var db = new PagesDbContext())
            {
                var pageEntity = new Page();
                pageEntity.Title = page.Title;
                //pageEntity.CreatedDate = DateTime.Now;
                //pageEntity.ModifiedDate = DateTime.Now;
                db.Pages.Add(pageEntity);
                db.SaveChanges();

                foreach (var image in page.Images)
                {
                    var imageEntity = new Image();
                    imageEntity.PageId = pageEntity.Id;
                    imageEntity.URL = image.URL;
                    imageEntity.X = image.X;
                    imageEntity.Y = image.Y;
                    //imageEntity.CreatedDate = DateTime.Now;
                    //pageEntity.ModifiedDate = DateTime.Now;
                    db.Images.Add(imageEntity);
                }

                foreach (var text in page.Texts)
                {
                    var textEntity = new Text();
                    textEntity.PageId = pageEntity.Id;
                    textEntity.Content = text.Content;
                    textEntity.X = text.X;
                    textEntity.Y = text.Y;
                    //textEntity.CreatedDate = DateTime.Now;
                    //pageEntity.ModifiedDate = DateTime.Now;
                    db.Texts.Add(textEntity);
                }

                db.SaveChanges();
            }
        }

        public List<string> GetTitlesByxy(double x, double y)
        {
            return _db.Pages.Where(p => p.Images.Where(i => i.X >= x && i.Y >= y).Count() == p.Images.Count() && p.Texts.Where(t => t.X >= x && t.Y >= y).Count() == p.Texts.Count()).Select(p => p.Title).ToList();           
        }
    }
}