using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class BookStore
    {
        public int BookId;
        public string BookName;
        public string BookYazar;


        public void setBook(int bookID, string bookName, string bookYazar)
        {
            

            this.BookId = bookID;
            this.BookName = bookName;
            this.BookYazar = bookYazar;
          
            
          
        }

        public string getBook()
        {
           return($"Kitap Adı : {BookName}\nKitap Yazarı : {BookYazar}");
        }

    }
}
