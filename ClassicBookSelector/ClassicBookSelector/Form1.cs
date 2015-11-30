//ClassicBookSelector Excercise 3
//Tells the user that reading is good
//when user hovers over the listbox,
//and vanishses when not over the
//listbox, also has a brief synopsis
//of the book selected
//Written By Michael Miranda
//Written on 11/14/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicBookSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void booksListbox_MouseEnter(object sender, EventArgs e)
        {
            hoverLabel.Visible = true;
        }

        private void booksListbox_MouseLeave(object sender, EventArgs e)
        {
            hoverLabel.Visible = false;
        }

        private void booksListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (booksListbox.SelectedIndex == 0)
            {
                synopsisLabel.Text = "The Dictionary is a book\n" +
                    "that has every word\n of the english language\n" +
                    "and its definition.";
            }
            else
                if (booksListbox.SelectedIndex == 1)
            {
                synopsisLabel.Text = "It's a book about a book";
            }
            else
                if (booksListbox.SelectedIndex == 2)
            {
                synopsisLabel.Text = "The epic sequal of book 1";
            }
            else
            if (booksListbox.SelectedIndex == 3)
            {
                synopsisLabel.Text = "It's a book about a book";
            }
            else
                if (booksListbox.SelectedIndex == 4)
            {
                synopsisLabel.Text = "The book that ends all books";
            }

        }
    }
}
