using DemoComplete.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DemoComplete.Services
{
    public class BookService : IBookService
    {
        public List<Book>  GetBooks()
        {
            using (var myReader = File.OpenText("data/books.json"))
            {
                string str = myReader.ReadToEnd();                
                return JsonConvert.DeserializeObject<List<Book>>(str);
            }              
        }
    }

    public interface IBookService
    {
        List<Book> GetBooks();
    }
}
