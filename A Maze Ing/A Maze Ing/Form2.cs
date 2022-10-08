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
    public partial class Form2 : Form
    {
        int[,] maze = new int[32, 32];

        Graphics g;

        public Form2()
        {
            InitializeComponent();
        }

        void Loading()
        {
            g = this.CreateGraphics();
            Pen pen = new Pen(Color.Gray, 2);
            for(int i = 0; i < 32; i++) { maze[i, 0] = 1; maze[0, i] = 1; maze[31, i] = 1;maze[i, 31] = 1; }
            maze[3, 31] = 0; maze[28, 0] = 0; 

            for(int i = 0; i < 32; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if (maze[i, j] == 1)
                        g.FillRectangle(new SolidBrush(Color.Maroon), i * 19, j * 19, 19, 19);
                    g.DrawRectangle(pen, i * 19, j * 19, 19, 19);
                }
                    
            }

            


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / 19;
            int y = e.Y / 19;
            if (x<= 0 || x >= 31 || y <=0 || y >= 31) return;
            if(maze[x,y] == 0)
            {
                maze[x, y] = 1;
                g.FillRectangle(new SolidBrush(Color.Maroon), x * 19, y * 19, 19, 19);
                g.DrawRectangle(new Pen(Color.Gray,2), x * 19, y * 19, 19, 19);
            }
            else
            {
                maze[x, y] = 0;
                g.FillRectangle(new SolidBrush(Color.White), x * 19, y * 19, 19, 19);
                g.DrawRectangle(new Pen(Color.Gray, 2), x * 19, y * 19, 19, 19);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < 31; i++)
                for(int j = 1; j < 31; j++)
                {
                    maze[i, j] = 0;
                    g.FillRectangle(new SolidBrush(Color.White), i * 19, j * 19, 19, 19);
                    g.DrawRectangle(new Pen(Color.Gray, 2), i * 19, j * 19, 19, 19);
                }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string filepath = Directory.GetCurrentDirectory() + "\\Mazes\\5.txt";
            
            

            string[] lines = new string[32];
            for(int i = 0; i < 32; i++)
            {
                string line = "";
                for (int j = 0; j < 32; j++)
                    line = line + maze[i, j].ToString();
                lines[i] = line;
            }
            File.WriteAllLines(filepath, lines);
            MessageBox.Show("Succesfuly Saved!");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
