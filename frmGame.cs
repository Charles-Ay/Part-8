using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_8
{
    public partial class frmHangMan : Form
    {
        string word;
        string displayWord;
        int guesses;
        List<string> Letters = new List< string > ();
        Random rand = new Random();
        int randNum;

        public frmHangMan()
        {
            InitializeComponent();
        }

        private void frmHangMan_Load(object sender, EventArgs e)
        {
            randNum = rand.Next(1, 4);
            //Words are 1 = computer, 2 = Aldworth, 3 =  NASCAR
            if (randNum == 1)
            {
                word = "C O M P U T E R";
                displayWord = "_ _ _ _ _ _ _ _";
            }
            else if (randNum ==  2)
            {
                word = "A L D W O R T H";
                displayWord = "_ _ _ _ _ _ _ _";
            }
            else if (randNum == 3)
            {
                word = "N A S C A R";
                displayWord = "_ _ _ _ _ _";
            }
            
            guesses = 0;
            
            
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string text = txtGuess.Text.Trim();
            int wordNum = word.IndexOf(text);
            if (randNum == 3 && txtGuess.Text.Contains("A"))
            {
                 System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
                strBuilder[2] = 'A';
                strBuilder[8] = 'A';
                displayWord = strBuilder.ToString();
                lblWord.Text = displayWord;
                lblEnusre.Text = "";
                Letters.Add(text);
                txtGuess.Text = "";
                lstGuessedLetters.DataSource = null;
                lstGuessedLetters.DataSource = Letters;
            }
            if (wordNum >= 0)//only does this if letter is found in word
            {
                System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
                char Character = char.Parse(text);
                strBuilder[wordNum] = Character;
                displayWord = strBuilder.ToString();
                lblWord.Text = displayWord;
                lblEnusre.Text = "";
                Letters.Add(text);
                txtGuess.Text = "";
                lstGuessedLetters.DataSource = null;
                lstGuessedLetters.DataSource = Letters;
            }
            else if (string.IsNullOrEmpty(txtGuess.Text) || string.IsNullOrWhiteSpace(txtGuess.Text))
            {
                lblEnusre.Text = "ENTER A LETTER";
            }
            else if (text.Length > 0)
            {
                Letters.Add(text);
                txtGuess.Text = "";
                lstGuessedLetters.DataSource = null;
                lstGuessedLetters.DataSource = Letters;
                guesses += 1;
                lblGuess.Text = $"Guesses:{guesses}";
                if (guesses == 1)
                {
                    imgHang.Image = Properties.Resources.hangman_1;
                }
                else if (guesses == 2)
                {
                    imgHang.Image = Properties.Resources.hangman_2;
                }
                else
                {
                    imgHang.Image = Properties.Resources.hangman_dead;
                    lblResult.Text = "You Lose";
                    MessageBox.Show("Loser ☹");
                    Close();
                }
            }



            //if (randNum == 1)
            //{


            //    if (txtGuess.Text.Contains("C"))
            //    {
            //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //        strBuilder[0] = 'C';
            //        displayWord = strBuilder.ToString();
            //        lblWord.Text = displayWord;
            //        lblEnusre.Text = "";
            //        Letters.Add(text);
            //        txtGuess.Text = "";
            //        lstGuessedLetters.DataSource = null;
            //        lstGuessedLetters.DataSource = Letters;
            //    }
            //    else if (txtGuess.Text.Contains("O"))
            //    {
            //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //        strBuilder[2] = 'O';
            //        displayWord = strBuilder.ToString();
            //        lblWord.Text = displayWord;
            //        lblEnusre.Text = "";
            //        Letters.Add(text);
            //        txtGuess.Text = "";
            //        lstGuessedLetters.DataSource = null;
            //        lstGuessedLetters.DataSource = Letters;
            //    }
            //    else if (txtGuess.Text.Contains("M"))
            //    {
            //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //        strBuilder[4] = 'M';
            //        displayWord = strBuilder.ToString();
            //        lblWord.Text = displayWord;
            //        lblEnusre.Text = "";
            //        Letters.Add(text);
            //        txtGuess.Text = "";
            //        lstGuessedLetters.DataSource = null;
            //        lstGuessedLetters.DataSource = Letters;
            //    }
            //    else if (txtGuess.Text.Contains("P"))
            //    {
            //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //        strBuilder[6] = 'P';
            //        displayWord = strBuilder.ToString();
            //        lblWord.Text = displayWord;
            //        lblEnusre.Text = "";
            //        Letters.Add(text);
            //        txtGuess.Text = "";
            //        lstGuessedLetters.DataSource = null;
            //        lstGuessedLetters.DataSource = Letters;
            //    }
            //    else if (txtGuess.Text.Contains("U"))
            //    {
            //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //        strBuilder[8] = 'U';
            //        displayWord = strBuilder.ToString();
            //        lblWord.Text = displayWord;
            //        lblEnusre.Text = "";
            //        Letters.Add(text);
            //        txtGuess.Text = "";
            //        lstGuessedLetters.DataSource = null;
            //        lstGuessedLetters.DataSource = Letters;
            //    }
            //    else if (txtGuess.Text.Contains("T"))
            //    {
            //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //        strBuilder[10] = 'T';
            //        displayWord = strBuilder.ToString();
            //        lblWord.Text = displayWord;
            //        lblEnusre.Text = "";
            //        Letters.Add(text);
            //        txtGuess.Text = "";
            //        lstGuessedLetters.DataSource = null;
            //        lstGuessedLetters.DataSource = Letters;
            //    }
            //    else if (txtGuess.Text.Contains("E"))
            //    {
            //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //        strBuilder[12] = 'E';
            //        displayWord = strBuilder.ToString();
            //        lblWord.Text = displayWord;
            //        lblEnusre.Text = "";
            //        Letters.Add(text);
            //        txtGuess.Text = "";
            //        lstGuessedLetters.DataSource = null;
            //        lstGuessedLetters.DataSource = Letters;
            //    }
            //    else if (txtGuess.Text.Contains("R"))
            //    {
            //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //        strBuilder[14] = 'R';
            //        displayWord = strBuilder.ToString();
            //        lblWord.Text = displayWord;
            //        lblEnusre.Text = "";
            //        Letters.Add(text);
            //        txtGuess.Text = "";
            //        lstGuessedLetters.DataSource = null;
            //        lstGuessedLetters.DataSource = Letters;
            //    }
            //    else if (string.IsNullOrEmpty(txtGuess.Text) || string.IsNullOrWhiteSpace(txtGuess.Text))
            //    {
            //        lblEnusre.Text = "ENTER A LETTER";
            //    }
            //    else if (text.Length > 0)
            //    {
            //        Letters.Add(text);
            //        txtGuess.Text = "";
            //        lstGuessedLetters.DataSource = null;
            //        lstGuessedLetters.DataSource = Letters;
            //        guesses += 1;
            //        lblGuess.Text = $"Guesses:{guesses}";
            //        if (guesses == 1)
            //        {
            //            imgHang.Image = Properties.Resources.hangman_1;
            //        }
            //        else if (guesses == 2)
            //        {
            //            imgHang.Image = Properties.Resources.hangman_2;
            //        }
            //        else
            //        {
            //            imgHang.Image = Properties.Resources.hangman_dead;
            //            lblResult.Text = "You Lose";
            //            MessageBox.Show("Loser ☹");
            //            Close();
            //        }
            //    }

            //    //if (randNum == 2)
            //    //{


            //    //    if (txtGuess.Text.Contains("A"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[0] = 'A';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("L"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[2] = 'L';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("D"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[4] = 'D';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("W"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[6] = 'W';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("O"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[8] = 'O';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("R"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[10] = 'R';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("T"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[12] = 'T';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("H"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[14] = 'H';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (string.IsNullOrEmpty(txtGuess.Text) || string.IsNullOrWhiteSpace(txtGuess.Text))
            //    //    {
            //    //        lblEnusre.Text = "ENTER A LETTER";
            //    //    }
            //    //    else if (text.Length > 0)
            //    //    {
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //        guesses += 1;
            //    //        lblGuess.Text = $"Guesses:{guesses}";
            //    //        if (guesses == 1)
            //    //        {
            //    //            imgHang.Image = Properties.Resources.hangman_1;
            //    //        }
            //    //        else if (guesses == 2)
            //    //        {
            //    //            imgHang.Image = Properties.Resources.hangman_2;
            //    //        }
            //    //        else
            //    //        {
            //    //            imgHang.Image = Properties.Resources.hangman_dead;
            //    //            lblResult.Text = "You Lose";
            //    //            MessageBox.Show("Loser ☹");
            //    //            Close();
            //    //        }
            //    //    }

            //    //}
            //    //if (randNum == 3)
            //    //{


            //    //    if (txtGuess.Text.Contains("N"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[0] = 'N';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("A"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[2] = 'A';
            //    //        strBuilder[8] = 'A';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("S"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[4] = 'S';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("C"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[6] = 'C';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (txtGuess.Text.Contains("R"))
            //    //    {
            //    //        System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(displayWord);
            //    //        strBuilder[10] = 'R';
            //    //        displayWord = strBuilder.ToString();
            //    //        lblWord.Text = displayWord;
            //    //        lblEnusre.Text = "";
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //    }
            //    //    else if (string.IsNullOrEmpty(txtGuess.Text) || string.IsNullOrWhiteSpace(txtGuess.Text))
            //    //    {
            //    //        lblEnusre.Text = "ENTER A LETTER";
            //    //    }
            //    //    else if (text.Length > 0)
            //    //    {
            //    //        Letters.Add(text);
            //    //        txtGuess.Text = "";
            //    //        lstGuessedLetters.DataSource = null;
            //    //        lstGuessedLetters.DataSource = Letters;
            //    //        guesses += 1;
            //    //        lblGuess.Text = $"Guesses:{guesses}";
            //    //        if (guesses == 1)
            //    //        {
            //    //            imgHang.Image = Properties.Resources.hangman_1;
            //    //        }
            //    //        else if (guesses == 2)
            //    //        {
            //    //            imgHang.Image = Properties.Resources.hangman_2;
            //    //        }
            //    //        else
            //    //        {
            //    //            imgHang.Image = Properties.Resources.hangman_dead;
            //    //            lblResult.Text = "You Lose";
            //    //            MessageBox.Show("Loser ☹");
            //    //            Close();
            //    //        }
            //    //    }

            //    //}
            //}
            if (displayWord == word)
            {
                MessageBox.Show("You Win ☺");
                Close();
            }
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            
            txtGuess.CharacterCasing = CharacterCasing.Upper;
           
        }

        private void lblUsed_Click(object sender, EventArgs e)
        {

        }

        private void lblWord_Click(object sender, EventArgs e)
        {

        }
    }
}
