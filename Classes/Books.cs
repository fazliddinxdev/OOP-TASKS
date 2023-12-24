namespace OOP_TASKS.Classes
{
    class Book
    {
        private string bookName;
        private string nameAuthor;
        private int price;

        public string BookName 
        {   get
            {
                return bookName;
            } 
            set
            {
                bookName = value;
            } 
        }

        public string NameAuthor
        { 
            get
            {
                return nameAuthor;
            } 
            set
            {
                nameAuthor = value;
            } 
        }

        public int Price 
        { 
            get
            {
                return price;
            } 
            set
            {
                price = value;
            } 
        }

        public Book(string bookName, string nameAuthor, int price)
        {
            bookName = bookName;
            nameAuthor = nameAuthor;
            price = price;
        }


        public void PrintInfoAboutBooks()
        {
            Console.WriteLine($"Kiritilgan kitob ma'lumotlari quyidagilar:\n Nomi:{bookName}\n Muallif{nameAuthor}\n Narxi:{price}");
        }
    }
}