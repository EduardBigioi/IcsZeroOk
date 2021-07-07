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
            Console.WriteLine("aici cica se creaza matricea de 3x3");
        }
    }
}
