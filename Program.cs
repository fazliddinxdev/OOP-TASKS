// 1 - masala
using OOP_TASKS.Classes;


Console.Write("Kitob nomini kiriting: ");
string bookName = Console.ReadLine();
Console.Write("Kitob muallifini kiriting: ");
string nameAuthor = Console.ReadLine();
Console.Write("Kitob narxini kiriting: ");
string priceValue = Console.ReadLine();
int price = Convert.ToInt32(priceValue);


Book myBook = new Book(bookName, nameAuthor,price);

myBook.PrintInfoAboutBooks();