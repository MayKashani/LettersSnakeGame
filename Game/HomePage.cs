using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class HomePage : Form
    {
        public static string Word { get; set; }

        public HomePage()
        {
            InitializeComponent();
        }

        private void btnClientWord_Click(object sender, EventArgs e)
        {
            txtboxPlayerWord.Visible = true;
            btnStartPlaying.Visible = true;
        }

        private void btnStartPlaying_Click(object sender, EventArgs e)
        {
            Word = txtboxPlayerWord.Text;
            Word = Word.ToLower();
            ValidString();
            if (Word == null)
            {
                lblError.Visible = true;
            }
            else
            {
                GameBoard child = new GameBoard();
                child.ShowDialog();
            }
        }


        //public void StartGame()
        //{
        //    if (Word!=null)
        //    {
        //        GameBoard child = new GameBoard();
        //        child.ShowDialog();
        //    }
        //}

        private void btnByABC_Click(object sender, EventArgs e)
        {
            Word = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            GameBoard child = new GameBoard();
            child.ShowDialog();
        }


        public void ValidString()
        {
            for (int i = 0; i < Word.Length; i++)
            {
                char c =Word[i];
                if (Word[i] < 'a' || Word[i] > 'z')
                {
                    Word = null;
                        break;
                }
            }
        }

    }
}

    



