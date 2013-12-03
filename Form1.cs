using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GKLab3
{
    public partial class Form1 : Form
    {
        //public const string PATH = @"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg";

        public Form1()
        {
            InitializeComponent();

            //Bitmap bmp = new Bitmap(PATH);
            //pictureBoxOrigin.Image = bmp;

            //Bitmap bitmap = new Bitmap(bmp);
            //pictureBoxReducted.Image = bitmap;
        }

        private void buttonReduct_Click(object sender, EventArgs e)
        {
            Bitmap reductedBmp = ReduceColors((Bitmap)pictureBoxOrigin.Image);
            pictureBoxReducted.Image = reductedBmp;
        }

        private Bitmap ReduceColors(Bitmap bitmap)
        {
            Bitmap bmp = new Bitmap(bitmap);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color currPixel = bmp.GetPixel(x, y);
                    HSLColor currHSLPixel = HSLColor.FromArgbColor(currPixel);
                    currHSLPixel.Reduce(checkBoxH.Checked, checkBoxS.Checked, checkBoxL.Checked);
                    bmp.SetPixel(x, y, currHSLPixel.getRGBColor());
                }
            }

            return bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openImageDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";

            if (openImageDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBoxOrigin.Image = Image.FromFile(openImageDialog.FileName);
            }
        }


    }
}
