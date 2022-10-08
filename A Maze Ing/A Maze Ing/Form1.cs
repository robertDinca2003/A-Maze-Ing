using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace A_Maze_Ing
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        Button[] levels = new Button[6];

        Panel panelLevel = new Panel();

        Point player = new Point(3, 31);

        Graphics g;

        Form2 createlvl = new Form2();

        int[,,] mazes = new int[6,32,32];

        int currentlvl; 

        void startGame(int lvl)
        {

        }


        private void btn_play_Click(object sender, EventArgs e)
        {
            currentlvl = -1; 

            btn_exit.Visible = false;
            btn_exit.Enabled = false;

            btn_play.Visible = false;
            btn_play.Enabled = false;

            btn_return.Visible = true;
            btn_return.Enabled = true;

            for(int i = 0; i < 6; i++)
            {
                Button temp = new Button();
                panelGame.Controls.Add(temp);
                temp.Visible = true;
                temp.Height = 100;
                temp.Width = 100;
                temp.BackColor = Color.Maroon;
                temp.ForeColor = Color.Moccasin;
                temp.Text = (i + 1).ToString();
                temp.Location = new Point(100 + i%3 * 200, 200 + i/3 * 150);
                temp.Font = new Font("Arial", 26, FontStyle.Bold);
                temp.Click += new EventHandler(this.startGame);
                levels[i] = temp;
            }
            levels[5].Text = "C";

        }

        void winner()
        {
         
            lblGameName.Text = "Completed!";
        }

        void createLevel()
        {
            
            createlvl.ShowDialog();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void startGame(object sender, EventArgs e)
        {
            player.X = 3;
            player.Y = 31;

            for (int i = 0; i < 6; i++)
                if (sender.Equals(levels[i])) currentlvl = i;
            for (int i = 0; i < 6; i++)
                panelGame.Controls.Remove(levels[i]);

            if (currentlvl == 5) createLevel();

            

            panelGame.Controls.Add(panelLevel);
            panelLevel.BackColor = Color.White;
            panelLevel.Location = new Point(150, 200);
            panelLevel.Height = 64*6;
            panelLevel.Width = 64*6;

            

            g = panelLevel.CreateGraphics();

            string filepath = Directory.GetCurrentDirectory(); filepath = filepath + "\\Mazes\\"; filepath= filepath + currentlvl.ToString() + ".txt";

            string[] lines = File.ReadAllLines(filepath); 

            for(int i = 0; i < lines.Length; i++)
            {
                
                for (int j = 0 ; j < lines[i].Length; j++)
                {
                    mazes[currentlvl,i, j] = lines[i].ElementAt(j)-48;
                }
            }
                mazes[currentlvl, player.X, player.Y] = 2; 
            for(int i = 0; i < 32; i++)
                for(int j = 0; j < 32; j++)
                {
                    Rectangle rect = new Rectangle(i*12,j*12,12,12);
                    SolidBrush brush = new SolidBrush(Color.Maroon);
                    if (mazes[currentlvl, i, j] == 0) brush.Color = Color.White;
                    if (mazes[currentlvl, i, j] == 2) brush.Color = Color.Green;
                    g.FillRectangle(brush, rect);
                }

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 6; i++)
            {
                panelGame.Controls.Remove(levels[i]);
            }
            g.Clear(Color.Transparent);
            panelGame.Controls.Remove(panelLevel);

            btn_exit.Visible = true;
            btn_exit.Enabled = true;

            btn_play.Visible = true;
            btn_play.Enabled = true;

            btn_return.Visible = false;
            btn_return.Enabled = false;

            lblGameName.Text = "A Maze Ing!";
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (lblGameName.Text == "Completed!") return;
           // MessageBox.Show(player.Y.ToString());   
            if(e.KeyCode == Keys.Left)
            {
                if (player.X > 1 && mazes[currentlvl, player.X - 1, player.Y] == 0) {
                    g.FillRectangle(new SolidBrush(Color.White), player.X * 12, player.Y * 12, 12, 12);
                    player.X -= 1;
                    g.FillRectangle(new SolidBrush(Color.Green), player.X * 12, player.Y * 12, 12, 12);
                    
                } 
            }
            else if(e.KeyCode == Keys.Right)
            {
                if (player.X < 30 && mazes[currentlvl, player.X + 1, player.Y] == 0) {
                    g.FillRectangle(new SolidBrush(Color.White), player.X * 12, player.Y * 12, 12, 12);
                    player.X += 1;
                    g.FillRectangle(new SolidBrush(Color.Green), player.X * 12, player.Y * 12, 12, 12);
                }
            }
            else if(e.KeyCode == Keys.Up)
            {
                if (player.Y >0 && mazes[currentlvl, player.X, player.Y - 1] == 0)
                {
                    g.FillRectangle(new SolidBrush(Color.White), player.X * 12, player.Y * 12, 12, 12);
                    player.Y -= 1;
                    g.FillRectangle(new SolidBrush(Color.Green), player.X * 12, player.Y * 12, 12, 12);
                }
            }
            else if(e.KeyCode == Keys.Down)
            {
                if (player.Y < 30 && mazes[currentlvl, player.X, player.Y + 1] == 0)
                {
                    g.FillRectangle(new SolidBrush(Color.White), player.X * 12, player.Y * 12, 12, 12);
                    player.Y += 1;
                    g.FillRectangle(new SolidBrush(Color.Green), player.X * 12, player.Y * 12, 12, 12);
                }
            }

            if (player.Y == 0) winner();
        }
    }
}
