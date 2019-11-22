﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BooksService_MicrosoftTutorial2.Models
{
    public class BooksService_MicrosoftTutorial2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BooksService_MicrosoftTutorial2Context() : base("name=BooksService_MicrosoftTutorial2Context")
        {
        }

        public System.Data.Entity.DbSet<BookService.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<BookService.Models.Book> Books { get; set; }
    }
}
