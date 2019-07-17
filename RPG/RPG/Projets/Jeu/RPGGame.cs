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

namespace RPG.Projets.Jeu
{
    public partial class RPGGame : Form
    {
        Player hero = new Player(1, 1, 25, 25, 1);

        static int gameBoardWidth = 60;
        static int gameBoardHeight = 60;
        static string mapPath = "C:\\Users\\Felix\\Desktop\\maptest.txt";
        Tile[,] aTile = new Tile[gameBoardWidth, gameBoardHeight];
        int[,] mapArray = new int[gameBoardWidth, gameBoardHeight];

        public RPGGame()
        {
            InitializeComponent();
        }
        public RPGGame(Hero _hero)
        {
            InitializeComponent();
            if(_hero != null)
            {
                hero.hp = _hero.PtsVie;
                hero.str = _hero.PtsForce;
                hero.lvl = _hero.PtsShield;
            }

            KeyDown += new KeyEventHandler(RPGGame_KeyDown);
        }
        private void drawGameBoard()
        {
            drawAllsquares();
            drawTreeBoarder();
            LoadMap();
            drawTree();
            drawWall();
            drawHero();
        }
        private void drawAllsquares()
        {
            int x = 0;
            int y = 0;

            for (x = 0; x < gameBoardWidth; x++)
            {
                for (y = 0; y < gameBoardHeight; y++)
                {
                    int tilePixLeft = 25 * x;
                    int tilePixTop = 25 * y;

                    aTile[x, y] = new Tile(x, y, false, tilePixLeft, tilePixTop);
                }
            }
        }
        private void drawTreeBoarder()
        {

            Graphics gObject = canvas.CreateGraphics();
            Brush green = new SolidBrush(Color.Green);
            Brush brown = new SolidBrush(Color.Brown);

            int x = 0;
            int y = 0;
            bool solid = true;

            for (x = 0; x < gameBoardWidth; x++)
            {
                int tilePixLeft = 25 * x;
                int tilePixTop = 25 * y;
                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);
                gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
            }

            x = 0;
            for (y = 0; y < gameBoardHeight; y++)
            {
                int tilePixLeft = 25 * x;
                int tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);

                gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
            }

            y = gameBoardHeight - 1; // can replace this with gameBoardHeight - 1 if not building on windows 10 computer
            for (x = 0; x < gameBoardWidth; x++)
            {
                int tilePixLeft = 25 * x;
                int tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);

                gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
            }

            x = gameBoardWidth - 1; // can replace this with gameBoardWidth - 1;
            for (y = 0; y < gameBoardHeight; y++)
            {
                int tilePixLeft = 25 * x;
                int tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);

                gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
            }
        }

        private void LoadMap()
        {

            int y = 0;
            using (StreamReader reader = new StreamReader(mapPath))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        y--;
                        break;
                    }

                    if (y == 60)
                    {
                        break;
                    }
                    for (int i = 0; i < 60; i++)
                    {
                        mapArray[i, y] = int.Parse(line[i].ToString());
                    }
                    y++;

                }
            }
        }
        private void drawTree()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush green = new SolidBrush(Color.Green);
            Brush brown = new SolidBrush(Color.Brown);


            int x = 0;
            int y = 0;
            bool solid = true;

            for (y = 0; y < gameBoardHeight; y++)
            {
                for (x = 0; x < gameBoardWidth; x++)
                {
                    if (mapArray[x, y] == 1)
                    {
                        int tilePixLeft = 25 * x;
                        int tilePixTop = 25 * y;
                        aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);
                        gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                        gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
                    }

                }
            }
        }
        private void drawWall()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Brush gray = new SolidBrush(Color.Gray);

            int tilePixLeft;
            int tilePixTop;
            bool solid = true;

            int x;
            int y = 25;
            for (y = 0; y < gameBoardHeight; y++)
            {
                for (x = 0; x < gameBoardWidth; x++)
                {
                    if (mapArray[x, y] == 2)
                    {
                        tilePixLeft = 25 * x;
                        tilePixTop = 25 * y;

                        aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);
                        gObject.FillRectangle(black, tilePixLeft, tilePixTop, 25, 25);
                        gObject.FillRectangle(gray, tilePixLeft + 5, tilePixTop + 5, 15, 15);
                    }
                }
            }
        }
        private void drawHero()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Brush gray = new SolidBrush(Color.Gray);
            Brush yellow = new SolidBrush(Color.Yellow);


            hero.left = hero.tileX * 25;
            hero.top = hero.tileY * 25;

            gObject.FillRectangle(black, hero.left + 10, hero.top + 5, 5, 18);
            gObject.FillRectangle(yellow, hero.left + 11, hero.top + 2, 3, 19);   // sword
            gObject.FillRectangle(black, hero.left + 20, hero.top + 7, 3, 14);
            gObject.FillRectangle(black, hero.left + 8, hero.top + 3, 7, 7);
            gObject.FillRectangle(black, hero.left + 11, hero.top + 15, 7, 3);
            gObject.FillRectangle(yellow, hero.left + 9, hero.top + 4, 2, 2);     // eyes
            gObject.FillRectangle(yellow, hero.left + 13, hero.top + 4, 2, 2);     //
            gObject.FillRectangle(yellow, hero.left + 17, hero.top + 14, 4, 4);    // hands
        }

        /// <summary>
        /// Permet de cleaner le square de l'ancien x du bonhomme avant quil avance.
        /// </summary>
        private void cleanSquare()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush Olive = new SolidBrush(Color.OliveDrab);
            gObject.FillRectangle(Olive, hero.left, hero.top, 25, 25);
        }

        private void MoveLeft()
        {
            int x = hero.tileX + -1;
            int y = hero.tileY;
            if (aTile[x, y].solid == false)
            {
                cleanSquare();
                hero.tileX = hero.tileX + -1;
                hero.left = x * 25;
                drawHero();
            }
        }
        private void MoveRight()
        {
            int x = hero.tileX + 1;
            int y = hero.tileY;
            if (aTile[x, y].solid == false)
            {
                cleanSquare();
                hero.tileX = hero.tileX + 1;
                hero.left = x * 25;
                drawHero();
            }
        }
        private void MoveTop()
        {
            int x = hero.tileX;
            int y = hero.tileY - 1;
            if (aTile[x, y].solid == false)
            {
                cleanSquare();
                hero.tileY = hero.tileY - 1;
                hero.top = y * 25;
                drawHero();
            }
        }
        private void MoveBottom()
        {
            int x = hero.tileX;
            int y = hero.tileY + 1;
            if (aTile[x, y].solid == false)
            {
                cleanSquare();
                hero.tileY = hero.tileY + 1;
                hero.top = y * 25;
                drawHero();
            }
        }
        private void Load_Click(object sender, EventArgs e)
        {
            drawGameBoard();
        }

        bool isKeyPress = false;
        private void RPGGame_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (!isKeyPress)
            {
                isKeyPress = true;

                if (e.KeyCode == Keys.D)
                { MoveRight(); }
                else if (e.KeyCode == Keys.A)
                { MoveLeft(); }
                else if (e.KeyCode == Keys.W)
                { MoveTop(); }
                else if (e.KeyCode == Keys.S)
                { MoveBottom(); }
            }
            else
            {
                isKeyPress = false;
            }
          

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveRight();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveLeft();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            MoveTop();
        }

        private void btnGround_Click(object sender, EventArgs e)
        {
            MoveBottom();
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            Point point = canvas.PointToClient(Cursor.Position);
         //   MessageBox.Show(point.ToString());

            Graphics gObject = canvas.CreateGraphics();
            Brush Olive = new SolidBrush(Color.OliveDrab);
            point.X -= (point.X % 10);
            point.Y -= (point.Y % 10);
            gObject.FillRectangle(Olive, point.X, point.Y, 25, 25);
        }
    }
}
