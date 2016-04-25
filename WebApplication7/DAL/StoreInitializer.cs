using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models;

namespace WebApplication7.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var books = new List<Book>
            {
                new Book() {BookTitle = "Ravensoul", ISBN="01234567891011"},
                new Book() {BookTitle = "The Kill Zone", ISBN="0134534535511"},

            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var authors = new List<Author>()
            {
                new Author() {AuthorName="Chris", AuthorSurname="Ryan"},
                new Author() {AuthorName="James", AuthorSurname="Barclay"}
            };
            authors.ForEach(a => context.Authors.Add(a));
            context.SaveChanges();
        }
    }
}