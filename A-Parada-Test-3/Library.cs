using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Parada_Test_3
{
    class Library
    {
        public string BOOK_TEXT_FILE = "Books.txt";
        public string PATRON_TEXT_FILE = "Patrons.txt";
        public List<Book> BookList = new List<Book>();
        public List<Patron> PatronList = new List<Patron>();


        public Library()
        {
            GetBooks();
            GetPatrons();
        }

        private void GetBooks()
        {
            StreamReader inputFile = File.OpenText(BOOK_TEXT_FILE);

            string[] rowString = new string[4];
            while (inputFile.EndOfStream == false)
            {
                rowString = inputFile.ReadLine().Split(',');
                Book newBook = new Book(rowString[0].Trim(), rowString[1].Trim(), rowString[2].Trim(), rowString[3].Trim());
                BookList.Add(newBook);
            }
            inputFile.Close();

        }

        private void GetPatrons()
        {
            StreamReader inputFile = File.OpenText("Patrons.txt");

            string[] rowString = new string[2];
            while (inputFile.EndOfStream == false)
            {
                rowString = inputFile.ReadLine().Split(',');
                PatronList.Add(new Patron(rowString[0], rowString[1]));
            }
            inputFile.Close ();
        }

        public void SaveBooksToFile()
        {
            StreamWriter outputFile;
            outputFile = File.CreateText(BOOK_TEXT_FILE);
            foreach (var item in BookList)
            {
                outputFile.WriteLine(item.GetBook());
            }
            outputFile.Close();
        }

        public void SavePatronsToFile()
        {
            StreamWriter outputFile;
            outputFile = File.CreateText(PATRON_TEXT_FILE);
            foreach (var item in PatronList)
            {
                outputFile.WriteLine(item.GetPatron());
            }
            outputFile.Close();
        }
    }
}
