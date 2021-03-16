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

namespace HomeWork1
{
    public partial class Form1 : Form
    {
        string PlayerFile = "playerFile.txt";
        string PlayerName;
        string PlayerGoals;
        string strToInsert;
        string ShowPlayers;
        string[] arrPlayers;
        List<Players> pl; //= new List<Players>();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            PlayerName = txtName.Text;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            strToInsert = PlayerName + "," + PlayerGoals + "\n";
            File.AppendAllText(PlayerFile, strToInsert);
        }

        private void txtGoals_TextChanged(object sender, EventArgs e)
        {
            PlayerGoals = txtGoals.Text;
        }

        private void lblToShow_Click(object sender, EventArgs e)
        {          
           
        }

        private void ShowPlayers12()
        {
            lblToShow.Text = "";
            foreach (var Player in pl)
            {
                lblToShow.Text += Player + "\n";
            }
        }

        private void btnShowPlayers_Click(object sender, EventArgs e)
        {
            pl = new List<Players>();
            foreach (var item in File.ReadAllLines(PlayerFile))
            {
                arrPlayers = item.Split(',');
                pl.Add(new Players { Name = arrPlayers[0], Goals = int.Parse(arrPlayers[1]) });
            }
            ShowPlayers12();
            //lblToShow.Text =
            //ShowPlayers = File.ReadAllLines(PlayerFile);

        }
    }
}
