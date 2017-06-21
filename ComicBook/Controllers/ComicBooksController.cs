using ComicBook.Data;
using ComicBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ComicBook.Controllers
{
    public class ComicBooksController :Controller
    {
        private ComicBookRepository _comicBookRepository = new ComicBookRepository();
        
        public ActionResult Detail(int? id)
        {
            if (id==null)
                return HttpNotFound();

            var SelectedComicBook = _comicBookRepository.getComicBook((int) id);

            return View(SelectedComicBook); // viewnya biar isinya comicBook
        }
        // agar tidak error saat id diluar repository 
        // handle null  Detail(int? id) 


        public ActionResult Index()
        {
            var allComicBook = _comicBookRepository.getAllComicBook();

            return View(allComicBook);
        }
    }
}

//public string Detail()
//{
//    return "This is Controller Class";
//}
//public ComicBooksController()
//{
//    _comicBookRepository = new ComicBookRepository();
//}