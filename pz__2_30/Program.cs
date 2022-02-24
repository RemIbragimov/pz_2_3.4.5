using System;

namespace pz__2_30
{
    class Program
    {
        static void Main(string[] args)
        {
            BookCard b1 = new BookCard(1, "Пушкин", "Дубровский", "Списания");
            BookCard b2 = new BookCard(2, "Лермонтов", "Парус", "Новая");
            BookCard b3 = new BookCard(3, "Есенин", "Сорокоуст", "Хорошая");
            BookCard b4 = new BookCard(4, "Толстой", "Казаки", "Новая");
            BookCard b5 = new BookCard(5, "Маяковский", "На дне", "Списания", 1999);
            ScientificBookCard b6 = new ScientificBookCard(6, "Маршак", "Русские", "Новая","Калиграфия" ,2000);
            ScientificBookCard b7 = new ScientificBookCard(7, "Сталин", "Путь до Берлина", "Хорошая", "Наука", 2019);
            ScientificBookCard b8 = new ScientificBookCard(8, "Фет", "Были мы", "Списания", "Биография", 2018);

            b1.GetBookInfo();
            b2.GetBookInfo();
            b3.GetBookInfo();
            b4.GetBookInfo();
            b5.GetBookInfo();
            b6.GetBookInfo();
            b7.GetBookInfo();
            b8.GetBookInfo();

            BookCard.BooksCondition();
        }
    }
}