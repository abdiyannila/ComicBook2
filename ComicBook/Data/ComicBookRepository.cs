using ComicBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBook.Data
{
    public class ComicBookRepository
    {
        private static Models.ComicBook[] _comicBooks = new Models.ComicBook[]
        {
            new Models.ComicBook()
            {
                Id=0,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                Description = "<p>Final issue! <strong>Will Parker</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name="Dan Slott",Role="Script"},
                    new Artist() {Name = "Humbreto Ramos",Role ="Pencils"},
                    new Artist() {Name="Victor Olazba",Role="Inks"},
                    new Artist() {Name="Edgar Delgado",Role="Colors"},
                    new Artist() {Name="Abdiyan Rezka",Role="Letters"}
                }
            },

            new Models.ComicBook()
            {
                Id=1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                Description = "<p>Final issue! <strong>Will Parker</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name="Dan Slott",Role="Script"},
                    new Artist() {Name = "Humbreto Ramos",Role ="Pencils"},
                    new Artist() {Name="Victor Olazba",Role="Inks"},
                    new Artist() {Name="Edgar Delgado",Role="Colors"},
                    new Artist() {Name="Abdiyan Rezka",Role="Letters"}
                }
            },

            new Models.ComicBook()
            {
                Id=2,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                Description = "<p>Final issue! <strong>Will Parker</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name="Dan Slott",Role="Script"},
                    new Artist() {Name = "Humbreto Ramos",Role ="Pencils"},
                    new Artist() {Name="Victor Olazba",Role="Inks"},
                    new Artist() {Name="Edgar Delgado",Role="Colors"},
                    new Artist() {Name="Abdiyan Rezka",Role="Letters"}
                }
            }
        };

        public Models.ComicBook getComicBook(int id)
        {
            Models.ComicBook comicBookClicked = new Models.ComicBook();

            foreach (var comic in _comicBooks)
            {
                if (comic.Id == id)
                {
                    comicBookClicked = comic;
                    break;
                }
            }
            return comicBookClicked;
        }

        public Models.ComicBook[] getAllComicBook()
        {
            return _comicBooks; // panggil arraynya
        }

        
    }
}