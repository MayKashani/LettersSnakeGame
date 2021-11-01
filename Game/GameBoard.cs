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
    public partial class GameBoard : Form
    {
        static Letters[] obstacles;
        static int hearts;
        public HomePage parent;
        Random random = new Random();
        static int i = 0;
        Graphics paper;
        Snake snake;
        int score;
        Letters[] wordLetters = new Letters[26];


        public GameBoard()
        {
            InitializeComponent();
            StartNewGame();
            timer1.Interval = 150;
            timer1.Enabled = true;
        }

        private void pbGameLayots_Paint_1(object sender, PaintEventArgs e)
        {
            {
                paper = e.Graphics;
                DrawWord(paper);
                snake.drawsnake(paper);
                DrawObstacles(paper);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i == HomePage.Word.Length)
            {
                timer1.Enabled = false;
                DialogResult dr = MessageBox.Show("You won!!! Do you want to start a new game?", "Good job!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            if (i < HomePage.Word.Length)
            {
                if (EatLetter(paper, ref i) == true)
                    Snake.numOfRecs++;
                EatObstacle();
            }
            pbGameLayots.Invalidate();
            isInBoard();

        }

        private void GameBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && snake.Snakepos != position.Right)
            {
                snake.Snakepos = position.Left;
            }
            else if (e.KeyCode == Keys.Right && snake.Snakepos != position.Left)
            {
                snake.Snakepos = position.Right;
            }
            else if (e.KeyCode == Keys.Up && snake.Snakepos != position.Down)
            {
                snake.Snakepos = position.Up;
            }
            else if (e.KeyCode == Keys.Down && snake.Snakepos != position.Up)
            {
                snake.Snakepos = position.Down;
            }

        }

        private void isInBoard()
        {
            if (snake.rec_snake[0].X >= 440 || snake.rec_snake[0].X < 0 || snake.rec_snake[0].Y >= 400 || snake.rec_snake[0].Y < 0)
            {
                Lost();
            }
        }

        ////game is over
        public void Lost()
        {
            DialogResult dr;
            timer1.Enabled = false;
            dr = MessageBox.Show("Press Yes to start a new game with the same letters order", "YOU LOST!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                StartNewGame();
            }
            else this.Close();
        }

        public void InitLettersToCollect()
        {
            bool insert = true;
            int createdcounter = 0;
            string word = HomePage.Word;
            while (createdcounter < word.Length)
            {
                int x = random.Next(50, 400);
                x -= (x % 10);
                int y = random.Next(50, 350);
                y -= (y % 10);
                for (int j = 0; j < createdcounter; j++)
                {
                    if ((wordLetters[j] != null && (wordLetters[j].XPos == x && wordLetters[j].YPos == y) || (wordLetters[j].XPos + 10 == x || wordLetters[j].XPos - 10 == x || wordLetters[j].YPos + 10 == y || wordLetters[j].YPos - 10 == y)))
                    {
                        insert = false;
                        break;
                    }
                }
                if (insert == true)
                {
                    wordLetters[createdcounter] = new Letters(word[createdcounter], x, y);
                    createdcounter++;
                }
                else insert = true;
            }
        }

        public void StartNewGame()
        {
            i = 0; score = 0;
            hearts = 3;
            Snake.numOfRecs = 5;
            string word = HomePage.Word;
            lblnextocollect.Text = HomePage.Word[0].ToString();
            lblHeartsCounter.Text = hearts.ToString();
            snake = new Snake();
            InitLettersToCollect();
            SpreadObstacles();
            timer1.Enabled = true;
        }

        public char GetRandomLetter()
        {
            int num = random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let;
        }

        public void DrawWord(Graphics e)
        {
            char c;
            for (int i = 0; i < wordLetters.Length; i++)
            {
                if (wordLetters[i] != null)
                {
                    c = wordLetters[i].Letter;
                    using (Font myFont = new Font("Arial", 10))
                        e.DrawString(c.ToString(), myFont, Brushes.White, wordLetters[i].XPos, wordLetters[i].YPos);
                }
            }
        }


        public void DrawObstacles(Graphics e)
        {
            if (HomePage.Word.Length < 26)
            {
                char c;
                for (int i = 0; i < obstacles.Length; i++)
                {
                    if (obstacles[i] != null)
                    {
                        c = obstacles[i].Letter;
                        using (Font myFont = new Font("Arial", 10))
                            e.DrawString(c.ToString(), myFont, Brushes.White, obstacles[i].XPos, obstacles[i].YPos);
                    }
                }
            }
        }

        public bool EatLetter(Graphics e, ref int i)
        {
            if (wordLetters[i] != null && i < HomePage.Word.Length)
            {
                for (int j = i; j < HomePage.Word.Length; j++)
                {
                    if ((snake.rec_snake[0].X == wordLetters[i].XPos && snake.rec_snake[0].Y == wordLetters[i].YPos) || (snake.rec_snake[0].X == wordLetters[j].XPos && snake.rec_snake[0].Y == wordLetters[j].YPos && wordLetters[i].Letter == wordLetters[j].Letter))
                    {
                        if (snake.rec_snake[0].X == wordLetters[i].XPos && snake.rec_snake[0].Y == wordLetters[i].YPos)
                        {
                            using (Font myFont = new Font("Arial", 10))
                                e.DrawString("", myFont, Brushes.HotPink, wordLetters[i].XPos, wordLetters[i].YPos);
                            lblalreadycollected.Text += wordLetters[i].Letter.ToString();
                            wordLetters[i] = null;
                        }
                        else if (snake.rec_snake[0].X == wordLetters[j].XPos && snake.rec_snake[0].Y == wordLetters[j].YPos && wordLetters[i].Letter == wordLetters[j].Letter)
                        {
                            using (Font myFont = new Font("Arial", 10))
                                e.DrawString("", myFont, Brushes.HotPink, wordLetters[j].XPos, wordLetters[j].YPos);
                            lblalreadycollected.Text += wordLetters[i].Letter.ToString();
                            wordLetters[j] = wordLetters[i];
                            wordLetters[i] = null;
                        }
                        score += 10;
                        lblScoreCounter.Text = score.ToString();
                        if (i < HomePage.Word.Length - 1)
                        {
                            lblnextocollect.Text = wordLetters[i + 1].Letter.ToString();
                        }
                        else
                            lblnextocollect.Text = "";
                        i++;
                        return true;
                    }
                    else if (snake.rec_snake[0].X == wordLetters[j].XPos && snake.rec_snake[0].Y == wordLetters[j].YPos && wordLetters[i].Letter != wordLetters[j].Letter)
                    {
                        hearts--;
                        lblHeartsCounter.Text = hearts.ToString();
                        if (hearts == 0)
                            Lost();
                    }
                }
            }
            return false;
        }

        public void SpreadObstacles()
        {
            bool insert = true;
            int obsRequired = 12;
            int obsCounter = 0;
            char c;
            obstacles = new Letters[12];
            Letters obs;
            while (obsCounter < obsRequired)
            {
                c = GetRandomLetter();
                int x = random.Next(50, 400);
                x -= (x % 10);
                int y = random.Next(50, 350);
                y -= (y % 10);
                obs = new Letters(c, x, y);
                for (int i = 0; i < HomePage.Word.Length; i++)
                {
                    if (wordLetters[i] != null && (c == HomePage.Word[i] || (obs.XPos == wordLetters[i].XPos && obs.YPos == wordLetters[i].YPos)) || (obs.XPos == wordLetters[i].XPos && obs.YPos == wordLetters[i].YPos))
                    {
                        insert = false;
                        break;
                    }
                }
                if (insert == true)
                {
                    for (int i = 0; i < obsCounter; i++)
                    {
                        if (obstacles[i] != null && (obs.XPos == obstacles[i].XPos && obs.YPos == obstacles[i].YPos) || obs.XPos + 10 == obstacles[i].XPos || obs.XPos - 10 == obstacles[i].XPos || obs.YPos + 10 == obstacles[i].YPos || obs.YPos - 10 == obstacles[i].YPos)
                        {
                            insert = false;
                            break;
                        }
                    }
                }
               if (insert == true)
               {
                obstacles[obsCounter] = new Letters(c, x, y);
                obsCounter++;
               }
               else insert = true;
                }
            }
        

        public void EatObstacle()
        {
            for (int i = 0; i < obstacles.Length; i++)
            {
                if (snake.rec_snake[0].X == obstacles[i].XPos && snake.rec_snake[0].Y == obstacles[i].YPos)
                {
                    hearts--;
                    lblHeartsCounter.Text = hearts.ToString();
                    if (hearts == 0)
                        Lost();
                }
            }
        }



        //public void SnakeHeadBumpedIntoBody()
        //{
        //    for (int i=4;i<snake.rec_snake.Length;i++)
        //    {
        //        if (snake.rec_snake[0].X == snake.rec_snake[i].X && snake.rec_snake[0].Y == snake.rec_snake[i].Y)
        //        {
        //            Lost();
        //        }
        //    }
        //}
    }
}
  






           
        
