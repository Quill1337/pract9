using System;

namespace WpfApp1
{
    internal struct Books
    {
        private string _bookname, _author, _publisher;
        private int _pagecount;

        public string Bookname { get => _bookname; set { _bookname = value; } }
        public string Author { get => _author; set { _author = value; } }
        public string Publisher { get => _publisher; set { _publisher = value; } }
        public int Pagecount
        {
            get => _pagecount;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Страницы не могут быть отрицательными");
                }
            }
        }
        public Books(string bookname, string author, string publisher, int pagecount)
        {
            _bookname = bookname;
            _author = author;
            _publisher = publisher;
            _pagecount = pagecount;
        }
    }
}
