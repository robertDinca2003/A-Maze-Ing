namespace A_Maze_Ing
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGame = new System.Windows.Forms.Panel();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.lblGameName = new System.Windows.Forms.Label();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Moccasin;
            this.panelGame.Controls.Add(this.btn_return);
            this.panelGame.Controls.Add(this.btn_exit);
            this.panelGame.Controls.Add(this.btn_play);
            this.panelGame.Controls.Add(this.lblGameName);
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1061, 1030);
            this.panelGame.TabIndex = 0;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Maroon;
            this.btn_return.Enabled = false;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.Color.Moccasin;
            this.btn_return.Location = new System.Drawing.Point(12, 12);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(349, 105);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Visible = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Maroon;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Moccasin;
            this.btn_exit.Location = new System.Drawing.Point(332, 555);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(349, 105);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Maroon;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.Moccasin;
            this.btn_play.Location = new System.Drawing.Point(332, 389);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(349, 105);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play Game";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.Maroon;
            this.lblGameName.Location = new System.Drawing.Point(238, 144);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(538, 108);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "A Maze Ing";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 1024);
            this.Controls.Add(this.panelGame);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1080, 1080);
            this.MinimumSize = new System.Drawing.Size(1080, 1080);
            this.Name = "Game";
            this.Text = "A Maze Ing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Button btn_return;
    }
}

