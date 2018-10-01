using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private GameMode _mode;
        private Player player1;
        private Player player2;

        private int?[,] state = new int?[3,3];

        private event Action<Player> OnCurrentPlayer;
        // private delegate void ChangePlayerDelegate(Player p);
        // private event ChangePlayerDelegate OnChange;

        private Player currentPlayerAnother;
        private Player currentPlayer
        {
            get { return currentPlayerAnother; }
            set
            {
                currentPlayerAnother = value;
                if (OnCurrentPlayer != null)
                {
                    OnCurrentPlayer(value);
                }
            }
        }
        
        private delegate void CheckIfGameOver(Player p);
        private event CheckIfGameOver Check;
        //check e referinta la metoda CheckIfGameOver
        private void Form1_Check(Player p)
        {
            Player pplayer = p == player1 ? player2 : player1;
            int ok = 0;
            for (int i = 0; i < 3; i++)
            {
                if (((state[i, 0] == state[i, 1]) && (state[i, 0] == state[i, 2]) && (state[i,1] == state[i,2])) 
                    && (state[i, 0] == 1 || state[i, 0] == 0))
                    { ok = 1; }
                if (((state[0, i] == state[1, i]) && (state[0, i] == state[2, i]) && (state[1, i] == state[2, i]))
                    && (state[0, i] == 1 || state[0, i] == 0))
                    { ok = 1; }
            }
            //PROBLEMA AICI *************************************************************************************
            if (((state[0, 0] == state[1, 1]) && (state[0, 0] == state[2, 2]) && (state[1, 1] == state[2, 2]))
                && (state[1,1] == 1 || state[1,1] == 0))
                { ok = 1; }
            // ***************************************************************************************************
            if (((state[2, 0] == state[1, 1]) && (state[1, 1] == state[0, 2]) && (state[2, 0] == state[0, 2]))
                && (state[1, 1] == 1 || state[1, 1] == 0))
                { ok = 1; }
            if (ok==1)
            {
                if(pplayer.Name=="" || pplayer.Name == null)
                {
                    label4.Text = "Game won by the Computer.";
                }
                else
                    label4.Text = "Game won by " + pplayer.Name + ". Congratulations!";
                panel3.Enabled = false;
                playerLabel.Text = "";
                panel1.Visible = false;
                panel2.Enabled = true;
                btnPvC.Enabled = true;
                btnPvP.Enabled = true;
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            ok = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (state[i, j] != 0 && state[i, j] != 1)
                        ok = 1;
                }
            }
            if (ok == 2)
            {
                label4.Text = "Draw";
                panel3.Enabled = false;
                playerLabel.Text = "";
                panel1.Visible = false;
                panel2.Enabled = true;
                btnPvC.Enabled = true;
                btnPvP.Enabled = true;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnPvP_Click(object sender, EventArgs e)
        {
            _mode = GameMode.Player2Player;
            panel1.Enabled = true;
            panel1.Visible = true;
            label2.Enabled = true;
            textBox2.Enabled = true;
            label2.Visible = true;
            textBox2.Visible = true;
            //state[0, 0] = 1;
            //state[0, 1] = 0;
            //RefreshCanvas();
        }

        private void btnPvC_Click(object sender, EventArgs e)
        {
            _mode = GameMode.Player2Computer;
            panel1.Enabled = true;
            panel1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case GameMode.Player2Player:
                    if (string.IsNullOrEmpty(textBox1.Text))
                        return;
                    if (string.IsNullOrEmpty(textBox2.Text))
                        return;
                    player1 = new Player() { Name = textBox1.Text };
                    player2 = new Player() { Name = textBox2.Text };
                    break;
                case GameMode.Player2Computer:
                    if (string.IsNullOrEmpty(textBox1.Text))
                        return;
                    player1 = new Player() { Name = textBox1.Text };
                    player2 = new Computer() {};
                    break;
            }
            panel3.Visible = true;
            panel3.Enabled = true;
            panel2.Enabled = false;
            OnCurrentPlayer += Form1_OnCurrentPlayer;
            currentPlayer = player1;
            state = new int?[3, 3];
            m11.Enabled = true;
            m11.Text = "";
            m12.Enabled = true;
            m12.Text = "";
            m13.Enabled = true;
            m13.Text = "";
            m21.Enabled = true;
            m21.Text = "";
            m22.Enabled = true;
            m22.Text = "";
            m23.Enabled = true;
            m23.Text = "";
            m31.Enabled = true;
            m31.Text = "";
            m32.Enabled = true;
            m32.Text = "";
            m33.Enabled = true;
            m33.Text = "";
            label4.Text = "";
        }

        //Afiseaza al cui e randul
        private void Form1_OnCurrentPlayer(Player obj)
        {
            playerLabel.Text = obj.Name;
            playerLabel.Text += "'s turn";
        }

        //Functia pentru schimbarea valorii din buton
        private void RefreshButton(Button btn, int? val)
        {
            if (btn == null)
            {
                throw new Exception("Wrong!");
            }
            if (val.HasValue)
            {
                btn.Enabled = false;
                btn.Text = val.Value == 1 ? "X" : "O";
            }
            else
            {
                btn.Enabled = true;
                btn.Text = "";
            }
        }

        //Functie care afiseaza schimbarile facute in butoane
        private void RefreshCanvas()
        {
            RefreshButton(m11, state[m11.X, m11.Y]);
            RefreshButton(m12, state[m12.X, m12.Y]);
            RefreshButton(m13, state[m13.X, m13.Y]);
            RefreshButton(m21, state[m21.X, m21.Y]);
            RefreshButton(m22, state[m22.X, m22.Y]);
            RefreshButton(m23, state[m23.X, m23.Y]);
            RefreshButton(m31, state[m31.X, m31.Y]);
            RefreshButton(m32, state[m32.X, m32.Y]);
            RefreshButton(m33, state[m33.X, m33.Y]);
        }

        //Functie suplimentara pentru eventul CLICK de pe un buton de joc
        private void nClick(object sender, EventArgs e)
        {
            var btn = (NewButton)sender;
            if(_mode==0)
            {
                var val = currentPlayer == player1 ? 1 : 0;
                state[btn.X, btn.Y] = val;
                RefreshCanvas();
                currentPlayer = currentPlayer == player1 ? player2 : player1;
            }
            else
            {
                var val = currentPlayer == player1 ? 1 : 0;
                state[btn.X, btn.Y] = val;
                RefreshCanvas();
                currentPlayer = currentPlayer == player1 ? player2 : player1;
                Form1_Check(currentPlayer);
                int endGame = 1;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (state[i, j] != 0 && state[i, j] != 1)
                            endGame = 0;
                    }
                }
                string text = "Game won by " + player1.Name + ". Congratulations!";
                if (endGame == 1 || label4.Text == text)
                    goto End;

                //Aici muta calculatorul
                int hasMoved = 0;
                //Elementele de pe diagonala DP si DS
                var rnd = new Random();
                if ((rnd.Next(0, 1000000)) % 7 + 1 > 6 && (((state[0, 0] == state[2, 2] && (state[0, 0] == 1 || state[0, 0] == 0)) && state[1, 1] != 0 && state[1, 1] != 1) ||
                    (state[0, 2] == state[2, 0] && (state[0, 2] == 1 || state[0, 2] == 0)) && state[1, 1] != 0 && state[1, 1] != 1))
                {
                    state[1, 1] = 0;
                    hasMoved = 1;
                }
                else if((rnd.Next(0, 1000000)) % 7 + 1 > 6 && state[0, 0] == state[1, 1] && (state[0, 0] == 1 || state[0, 0] == 0) && state[2, 2] != 0 && state[2, 2] != 1)
                {
                    state[2, 2] = 0;
                    hasMoved = 1;
                }
                else if((rnd.Next(0, 1000000)) % 7 + 1 > 6 && state[1, 1] == state[2, 2] && (state[1, 1] == 1 || state[1, 1] == 0) && state[0, 0] != 0 && state[0, 0] != 1)
                {
                    state[0, 0] = 0;
                    hasMoved = 1;
                }
                else if((rnd.Next(0, 1000000)) % 7 + 1 > 6 && state[0, 2] == state[1, 1] && (state[1, 1] == 1 || state[1, 1] == 0) && state[2, 0] != 0 && state[2, 0] != 1)
                {
                    state[2, 0] = 0;
                    hasMoved = 1;
                }
                else if((rnd.Next(0, 1000000)) % 7 + 1 > 6 && state[1, 1] == state[2, 0] && (state[1, 1] == 1 || state[1, 1] == 0) && state[0, 2] != 0 && state[0, 2] != 1)
                {
                    state[0, 2] = 0;
                    hasMoved = 1;
                }
                else{
                    while (true)
                    {
                        //Elementele de pe aceeasi linie 1cu2 si 2cu3
                        for(int k = 0; k < 3; k++)
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                if ((rnd.Next(0, 1000000)) % 7 + 1 > 6 && state[k, i] == state[k, i + 1] && (state[k, i] == 1 || state[k, i] == 0) && state[k, i == 0 ? 2 : 0] != 0 && state[k, i == 0 ? 2 : 0] != 1)
                                {
                                    state[k, i==0? 2 : 0] = 0;
                                    hasMoved = 1;
                                    break;
                                }
                            }
                            if (hasMoved == 1)
                                break;
                        }
                        if (hasMoved == 1)
                            break;

                        //Elementele de pe aceeasi linie 1cu3
                        for (int i = 0; i < 3; i++)
                        {
                            if ((rnd.Next(0, 1000000)) % 7 + 1 > 6 && state[i, 0] == state[i, 2] && (state[i, 0] == 1 || state[i, 0] == 0) && state[i, i] != 0 && state[i, i] != 1)
                            {
                                state[i, i] = 0;
                                hasMoved = 1;
                                break;
                            }
                        }
                        if (hasMoved == 1)
                            break;

                        //Elementele de pe aceeasi coloana 1cu2 si 2cu3
                        for (int k = 0; k < 2; k++)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if ((rnd.Next(0, 1000000)) % 7 + 1 > 6 && state[k, i] == state[k+1, i] && (state[k, i] == 1 || state[k, i] == 0) && state[k == 0 ? 2 : 0, i] != 0 && state[k == 0 ? 2 : 0, i] != 1)
                                {
                                    state[k==0? 2 : 0, i] = 0;
                                    hasMoved = 1;
                                    break;
                                }
                            }
                            if (hasMoved == 1)
                                break;
                        }
                        if (hasMoved == 1)
                            break;

                        //Elementele de pe aceeasi coloana 1cu3
                        for (int i = 0; i < 3; i++)
                        {
                            if ((rnd.Next(0, 1000000)) % 7 + 1 > 6 && state[0, i] == state[2, i] && (state[0, i] == 1 || state[2, i] == 0) && state[1, i] != 0 && state[1, i] != 1)
                            {
                                state[1, i] = 0;
                                hasMoved = 1;
                                break;
                            }
                        }
                        break;
                    }
                }
                //Daca nu a gasit loc atunci
                if (hasMoved == 0)
                {
                    while (true)
                    {
                        int x = (rnd.Next(0,100000))%3, y = (rnd.Next(0, 100000))%3;
                        if (state[x,y]!=0 && state[x, y] != 1)
                        {
                            state[x, y] = 0;
                            hasMoved = 1;
                        }
                        if (hasMoved == 1)
                            break;
                    }
                }
                RefreshCanvas();
                currentPlayer = currentPlayer == player1 ? player2 : player1;
            }
            Form1_Check(currentPlayer);
            End:
            int xxx = 8;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
