//Classe servant a tout ce qui est concernant la map.


//Exemple de fichier .txt de map

//GameboardWidth 60
//GameboardHeight 60
//
//111111111111111111111111111111111111
//10000001110000000000000000011111
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Projets.Jeu
{
    class MapFunction
    {
        public int[,] RecevoirMap(string PATH)
        {
            int[,] array = new int[60, 60];
            string[] lines = File.ReadAllLines(PATH);

            int y = 0;
            foreach (string line in lines)
            {
                for(int x = 0; x < line.Length; x++)
                {
                    array[x, y] = int.Parse(line);
                }
                y++;
            }

            return array;
        }
    }
}
