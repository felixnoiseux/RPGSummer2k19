namespace RPG.Projets.Jeu
{
    partial class RPGGame
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
            this.canvas = new System.Windows.Forms.Panel();
            this.Load = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnGround = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.OliveDrab;
            this.canvas.Location = new System.Drawing.Point(101, 12);
            this.canvas.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1778, 1600);
            this.canvas.TabIndex = 1;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(12, 12);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(73, 60);
            this.Load.TabIndex = 2;
            this.Load.Text = "Afficher Map";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(10, 78);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 60);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(10, 144);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 60);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "<-";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnGround
            // 
            this.btnGround.Location = new System.Drawing.Point(10, 267);
            this.btnGround.Name = "btnGround";
            this.btnGround.Size = new System.Drawing.Size(75, 60);
            this.btnGround.TabIndex = 4;
            this.btnGround.Text = "v";
            this.btnGround.UseVisualStyleBackColor = true;
            this.btnGround.Click += new System.EventHandler(this.btnGround_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(10, 210);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(75, 60);
            this.btnTop.TabIndex = 5;
            this.btnTop.Text = "^";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // RPGGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPG.Properties.Resources._8_bit_video_game_backgrounds_309571;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 520);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnGround);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.canvas);
            this.KeyPreview = true;
            this.Name = "RPGGame";
            this.Text = "RPG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RPGGame_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnGround;
        private System.Windows.Forms.Button btnTop;
    }
}