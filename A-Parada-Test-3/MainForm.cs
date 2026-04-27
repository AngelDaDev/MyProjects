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
    public partial class MainForm : Form
    {
        //Library library = new Library();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //library.SaveToFile(library.BOOK_TEXT_FILE);
            //library.SaveToFile(library.PATRON_TEXT_FILE);
            this.Close();
        }

        private void BtnManageBooks_Click(object sender, EventArgs e)
        {
            
            BookForm frm = new BookForm();
            frm.ShowDialog();
        }

        private void BtnManagePatrons_Click(object sender, EventArgs e)
        {
            PatronForm frm = new PatronForm();
            frm.ShowDialog();
        }
    }
}
