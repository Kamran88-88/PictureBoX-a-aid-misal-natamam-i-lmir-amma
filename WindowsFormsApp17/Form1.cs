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

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //PictureBox[,] pictureBox = new PictureBox[3,3];

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo[] pictures = new FileInfo[0];
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                pictures=directoryInfo.GetFiles();
                //pictures[0].FullName
            }


            for (int i = 0; i < 6; i++)
            {
             //   for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
               // {

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = pictures[i].FullName;
             //   }
                
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        pictureBox[i,j] = new PictureBox();
            //        pictureBox[i,j].Dock = DockStyle.Fill;
            //        tableLayoutPanel1.Controls.Add(pictureBox[i,j], i, j);
            //    }
            //}




        }
    }
}
