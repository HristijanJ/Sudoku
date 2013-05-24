﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// List of possible schemes for the Squiggly Sudoku
        /// </summary>
        public List<int[,]> Schemes = new List<int[,]>();
        /// <summary>
        /// List of color to differentiate the different regions in Squiggly Sudoku
        /// </summary>
        public List<Color> colors = new List<Color>();

        /// <summary>
        /// Fill the Schemes and colors lists.
        /// </summary>
        public void schemeBuilder()
        {
            int[][] scheme = new int[6][];
            scheme[0] = new int[]  {1,1,1,2,2,2,2,3,3,
                                    1,1,4,4,4,2,2,3,3,
                                    1,1,4,5,5,2,3,3,3,
                                    1,1,4,5,2,2,6,3,3,
                                    4,4,4,5,5,5,6,6,6,
                                    7,7,4,8,8,5,6,0,0,
                                    7,7,7,8,5,5,6,0,0,
                                    7,7,8,8,6,6,6,0,0,
                                    7,7,8,8,8,8,0,0,0};
            scheme[1] = new int[] {1,1,2,2,2,3,3,3,4,
                                   1,1,2,2,2,3,3,3,4,
                                   1,1,2,2,2,3,3,4,4,
                                   5,1,1,1,6,6,3,4,4,
                                   5,5,6,6,6,6,6,4,4,
                                   5,5,7,6,6,0,0,0,4,
                                   5,5,7,7,8,8,8,0,0,
                                   5,7,7,7,8,8,8,0,0,
                                   5,7,7,7,8,8,8,0,0};
            scheme[2] = new int[] {1,1,1,2,2,2,3,3,3,
                                   1,1,1,2,2,2,4,3,3,
                                   1,5,5,2,6,2,4,3,3,
                                   1,1,5,2,6,6,4,3,3,
                                   5,5,5,6,6,6,4,4,4,
                                   7,7,5,6,6,8,4,0,0,
                                   7,7,5,8,6,8,4,4,0,
                                   7,7,5,8,8,8,0,0,0,
                                   7,7,7,8,8,8,0,0,0};
            scheme[3] = new int[] {1,1,1,2,2,2,2,3,3,
                                   1,1,4,2,2,2,2,3,3,
                                   5,1,4,2,4,4,4,4,3,
                                   5,1,4,4,4,6,6,6,3,
                                   5,1,1,6,6,6,8,8,3,
                                   5,6,6,6,7,7,7,8,3,
                                   5,7,7,7,7,0,7,8,3,
                                   5,5,0,0,0,0,7,8,8,
                                   5,5,0,0,0,0,8,8,8};
            scheme[4] = new int[] {1,1,2,2,2,2,2,2,2,
                                   1,1,1,1,3,2,2,3,4,
                                   1,5,5,1,3,3,3,3,4,
                                   1,5,6,6,3,3,3,4,4,
                                   5,5,6,6,6,6,6,4,4,
                                   5,5,7,7,7,6,6,4,8,
                                   5,7,7,7,7,8,4,4,8,
                                   5,7,0,0,7,8,8,8,8,
                                   0,0,0,0,0,0,0,8,8};


            for (int s = 0; s < 5; s++)
            {
                int[,] Puzzle = new int[9, 9];

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Puzzle[i, j] = scheme[s][i * 9 + j];
                    }
                }
                Schemes.Add(Puzzle);
            }

            colors.Add(Color.AliceBlue);
            colors.Add(Color.Lavender);
            colors.Add(Color.MistyRose);
            colors.Add(Color.LightCoral);
            colors.Add(Color.LightYellow);
            colors.Add(Color.LightSkyBlue);
            colors.Add(Color.LightSlateGray);
            colors.Add(Color.LightSalmon);
            colors.Add(Color.Ivory);
            ColorMap = new Color[9, 9];

        }
    }

}