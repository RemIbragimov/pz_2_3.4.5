using System;
using System.Collections.Generic;
using System.Text;

namespace pz__2_30
{
    class BookCard
    {
        public int ID;
        public string author;
        public string title;
        public int year;
        public string condition;
        public Random rnd = new Random();
        public static int good = 0;
        public static int bad = 0;
        public static int awesome = 0;
        public BookCard(int _ID, string _author, string _title, int _year, string _condition)
        {
            ID = _ID;
            author = _author;
            title = _title;
            if (year >= 1990 && year <= 2022)   //пз 4
                year = _year;
            else
                year = rnd.Next((int)1990, 2022);
            condition = _condition;
            if (condition == "Новая")
                awesome += 1;
            if (condition == "Списания")
                bad += 1;
            if (condition == "Хорошая")
                good += 1;

        }
        public BookCard()
        {

        }
        public BookCard(int _ID, string _author, string _title, string _condition)
        {
            ID = _ID;
            author = _author;
            title = _title;
            year = rnd.Next((int)1990, 2022);
            condition = _condition;
            if (condition == "Новая")
                awesome += 1;
            if (condition == "Списания")
                bad += 1;
            if (condition == "Хорошая")
                good += 1;
        }
        public BookCard(int _ID, string _author, string _title, string _condition, int yyear)
        {
            ID = _ID;
            author = _author;
            title = _title;
            year = yyear;
            condition = _condition;
            if (condition == "Новая")
                awesome += 1;
            if (condition == "Списания")
                bad += 1;
            if (condition == "Хорошая")
                good += 1;
        }
        private static int Getgood()
        {
            return good;
        }
        private static int Getbad()
        {
            return bad;
        }
        private static int Getawesome()
        {
            return awesome;
        }

        public virtual void GetBookInfo()
        {
            Console.Write($"\nID = {ID}, year = {year}, author = {author}, title = {title}, condition = {condition}");
        }

        public static void BooksCondition()
        {
            Console.WriteLine($"Хороших: {BookCard.Getgood()}" + $"\nСписание: {BookCard.Getbad()}" + $"\nНовых: {BookCard.Getawesome()}");
        }
    }
}
