using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcsZeroOK
{
    public partial class mainForm : System.Windows.Forms.Form
    {
        int currentUser;
        Label[,] board = new Label[3, 3];
        public mainForm()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            InitGame();
        }

        private void InitGame()
        {
            CreateBoard();
            currentUser = 1;
        }

        private void CreateBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   
                    board[i, j] = new Label();

                    this.board[i, j].BackColor = System.Drawing.Color.Lime;
                    this.board[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.board[i, j].Left = 100 + j * 54;
                    this.board[i, j].Top = 50 + i * 54;
                    this.board[i, j].Size = new System.Drawing.Size(50, 50);
                    this.board[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    this.board[i, j].Click += Play;
                    this.board[i, j].MouseEnter += OnMouseEnter;
                    this.board[i, j].MouseLeave += OnMouseLeave;


                    Controls.Add(board[i, j]);
                    
                }
            }

        }

        private void Play(object sender, EventArgs e)
        {
            if (((Label)sender).Text == "")
                if (currentUser==1)
                {
                    ((Label)sender).Text = "0";
                    currentUser = 2;
                }
                else
                {
                    ((Label)sender).Text = "1";
                    currentUser = 1;
                }

            //int winner = Winner();
            //if (winner != 0)
            //{
            //    ShowWinner(winner);
            //    ResetBoard();
            //}
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Lime;            
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Yellow;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Label testLabel = new Label();

            testLabel.Text = "Franzela";
            testLabel.Left = 100;
            testLabel.Top = 20;

            this.Controls.Add(testLabel);
        }
    }
}
