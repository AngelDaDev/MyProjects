using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Parada_Test_3
{
    public partial class BookForm : Form
    {
        Library Library = new Library();
        bool EDIT_MODE = false;
        public BookForm()
        {
            InitializeComponent();

            PopulateBooks();

        }
        private void PopulateBooks()
        {
            ListBoxBooks.Items.Clear();
            foreach (var item in Library.BookList)
            {
                ListBoxBooks.Items.Add(item.GetBook());
            }
        }
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (TextName.Text == string.Empty ||
                TextAuthor.Text == string.Empty ||
                TextISBN.Text == string.Empty ||
                ComboBoxAvailable.SelectedIndex < 0)
            {
                MessageBox.Show("All Fields must be filled!!");
            }
            else
            {
                if (!EDIT_MODE)
                {
                    bool searchIndex = false;
                    for (int i = 0; i < Library.BookList.Count; i++)
                    {
                        if (Library.BookList[i].ISBN == TextISBN.Text)
                        {
                            searchIndex = true;
                        }
                    }
                    if (!searchIndex)
                    {
                        Book newBook = new Book(TextName.Text, TextAuthor.Text, TextISBN.Text, ComboBoxAvailable.Text);
                        Library.BookList.Add(newBook);
                        ListBoxBooks.Items.Add(newBook.GetBook());

                        
                    }
                    else
                    {
                        MessageBox.Show("ISBN Already Exists!");
                    }
                }
                else
                {
                    for (int i=0; i< Library.BookList.Count;i++)
                    {
                        if (Library.BookList[i].ISBN == TextISBN.Text)
                        {
                            Library.BookList[i].Author = TextAuthor.Text;
                            Library.BookList[i].Title = TextName.Text;
                            Library.BookList[i].IsAvailable = ComboBoxAvailable.Text;
                        }
                    }
                    TextISBN.ReadOnly = false;
                }
                ResetForm();
                PopulateBooks();

            }

        }

        private void ResetForm()
        {
            TextName.Text = string.Empty;
            TextAuthor.Text = string.Empty;
            TextISBN.Text = string.Empty;
            ComboBoxAvailable.SelectedIndex = -1;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ListBoxBooks.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a book");
            }
            else
            {


                string[] current = ListBoxBooks.SelectedItem.ToString().Split(',');
                TextName.Text = current[0].Trim();
                TextAuthor.Text = current[1].Trim();
                TextISBN.Text = current[2].Trim();
                ComboBoxAvailable.SelectedIndex = ComboBoxAvailable.Items.IndexOf(current[3].Trim());

                TextISBN.ReadOnly = true;
                BtnAddBook.Text = "Save Change";
                EDIT_MODE = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxBooks.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a book");
            }
            else
            {
                Library.BookList.RemoveAt(ListBoxBooks.SelectedIndex);
                string[] selectedItem = ListBoxBooks.Text.Split(',');
                
                for (int i = 0; i < Library.BookList.Count; i++)
                {
                    if (Library.BookList[i].ISBN == selectedItem[2])
                    {
                        Library.BookList.RemoveAt(i);
                    }
                }
                PopulateBooks();
            }
        }

        private void BtnCloseBookForm_Click(object sender, EventArgs e)
        {
            Library.SaveBooksToFile();
        }
    }
}
