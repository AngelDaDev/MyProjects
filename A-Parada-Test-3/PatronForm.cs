using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Parada_Test_3
{
    public partial class PatronForm : Form
    {
        Library library = new Library();
        bool EDIT_MODE = false;
        public PatronForm()
        {
            InitializeComponent();
            PopulatePatrons();
        }

        private void BtnClosePatronForm_Click(object sender, EventArgs e)
        {
            library.SavePatronsToFile();
            this.Close();
        }

        private void BtnAddPatron_Click(object sender, EventArgs e)
        {
            if (TextName.Text == string.Empty || TextPatronID.Text == string.Empty)
            {
                MessageBox.Show("All fields must be filled!");
            }
            else
            {
                if (!EDIT_MODE)
                {
                    bool searchIndex = false;
                    for (int i = 0; i < library.PatronList.Count; i++)
                    {
                        if (library.PatronList[i].PatronID == TextPatronID.Text)
                        {
                            searchIndex = true;
                        }
                    }
                    if (!searchIndex)
                    {
                        Patron newPatron = new Patron(TextName.Text.Trim(), TextPatronID.Text.Trim());
                        library.PatronList.Add(newPatron);
                        ListBoxPatrons.Items.Add(newPatron.GetPatron());
                    }
                    else
                    {
                        MessageBox.Show("Patron ID Already Exists!");
                    }
                }
                else
                {
                    for (int i = 0; i < library.PatronList.Count; i++)
                    {
                        if (library.PatronList[i].PatronID == TextPatronID.Text)
                        {
                            library.PatronList[i].Name = TextName.Text;
                        }
                    }
                    TextPatronID.ReadOnly = false;
                }
                ResetForm();
                PopulatePatrons();

            }
        }


        private void PopulatePatrons()
        {
            ListBoxPatrons.Items.Clear();
            foreach (var item in library.PatronList)
            {
                ListBoxPatrons.Items.Add(item.GetPatron());
            }
        }

        private void ResetForm()
        {
            TextName.Text = string.Empty;
            TextPatronID.Text = string.Empty;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ListBoxPatrons.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a book");
            }
            else
            {

                string[] current = ListBoxPatrons.SelectedItem.ToString().Split(',');
                TextName.Text = current[0].Trim();
                TextPatronID.Text += current[1].Trim();
                TextPatronID.ReadOnly = true;
                BtnAddPatron.Text = "Save Change";
                EDIT_MODE = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxPatrons.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a book");
            }
            else
            {
                library.PatronList.RemoveAt(ListBoxPatrons.SelectedIndex);
                string[] selectedItem = ListBoxPatrons.Text.Split(',');
                
                for (int i = 0; i < library.PatronList.Count; i++)
                {
                    if (library.PatronList[i].PatronID == selectedItem[1])
                    {
                        library.PatronList.RemoveAt(i);
                    }
                }
                PopulatePatrons();
            }
        }
    }
}
