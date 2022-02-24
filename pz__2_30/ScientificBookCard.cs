using System;
using System.Collections.Generic;
using System.Text;

namespace pz__2_30
{
    class ScientificBookCard : BookCard
    {        
        //          propfull        ctor
        
        private string _Direction;  // (направление – химия, медицина, и т.д.) 
        public string Direction
        {           
            get { return _Direction; }
            set { _Direction = value; }
        }
        private long _ReceiptDate;  //(добавить проверку на свежесть литературы – не старше 5 лет)
        public long ReceiptDate
        {
            get { return _ReceiptDate; }
            set { _ReceiptDate = value>2017?value:-1; }
        }
        public ScientificBookCard(int _ID, string _author, string _title, string _condition, string dir, long date)
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
            Direction = dir;
            ReceiptDate = date;
        }
        public override void GetBookInfo()
        {
            base.GetBookInfo();
            Console.WriteLine($", direction = {Direction}, receipdate = {ReceiptDate}");
        }
    }
}
