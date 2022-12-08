using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Fill();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(PagecountTextBox.Text, out int pagecount))
            {
                CollectionsBooks.Items.Add(new Books(BooknameTextBox.Text, AuthorTextBox.Text, PublisherTextBox.Text, pagecount));
            }
        }

        private void PublisherShow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (SearchPublisher.Text != "" && CollectionsBooks.Items.Count != 0)
                {
                    List<Books> book = new List<Books>();

                    foreach (Books item in CollectionsBooks.Items)
                    {
                        if (item.Publisher == SearchPublisher.Text)
                        {
                            book.Add(new Books(item.Bookname, item.Author, item.Publisher, item.Pagecount));
                        }
                    }
                    CollectionsBooks.Items.Clear();
                    foreach (Books item in book)
                    {
                        CollectionsBooks.Items.Add(new Books(item.Bookname, item.Author, item.Publisher, item.Pagecount));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseProg(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ClearAll(object sender, RoutedEventArgs e)
        {
            CollectionsBooks.Items.Clear();
            BooknameTextBox.Clear();
            AuthorTextBox.Clear();
            PublisherTextBox.Clear();
            PagecountTextBox.Clear();
            SearchPublisher.Clear();
            BooknameTextBox.Focus();
        }

        private void ShowTask(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Митрофанов Роман ИСП-31\nЗадание: Заполнить таблицу с учебной литературой с полями: название, автор, издательство, кол - во страниц.\nВывести результат на экран.\nВывести список книг заданного издательства.");
        }

        private void FillTablAuto(object sender, RoutedEventArgs e)
        {
            CollectionsBooks.Items.Clear();
            Fill();
        }
        private void Fill()
        {
            CollectionsBooks.Items.Add(new Books("Хребты безумия", "Говард Филиппс Лавкрафт", "Азбука", 64));
            CollectionsBooks.Items.Add(new Books("Илиада", "Гомер", "Литрес", 55));
            CollectionsBooks.Items.Add(new Books("Приключения Оливера Твиста", "Чарльза Диккенсат", "ОНИКС", 33));
            CollectionsBooks.Items.Add(new Books("Гордость и предубеждение", "Джейн Остин", "Питер", 23));
        }
    }
}
