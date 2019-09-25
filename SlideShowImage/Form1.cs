using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShowImage
{
    public partial class Form1 : Form
    {
        private string pathFordelImage = @"E:\Net Framework\Learn\SlideShowImage\SlideShowImage\bin\Debug\image";
        private int imageNumber = 1;

        public Form1()
        {
            InitializeComponent();
            loadImageFirst();
        }

        #region Methods
        // LẤY SỐ LƯỢNG ẢNH TRONG FORDEL
        private int getNumberImageInFordel(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] file = dir.GetFiles();
            return file.Length;
        }

        // HIỂN THỊ ẢNH ĐẦU TIÊN KHI KHỞI ĐỘNG
        private void loadImageFirst()
        {
            picMain.Image = new Bitmap(@"image\" + imageNumber + ".jpg");
            picImage1.Image = new Bitmap(@"image\" + imageNumber + ".jpg");
            picImage2.Image = new Bitmap(@"image\" + (imageNumber + 1) + ".jpg");
            picImage3.Image = new Bitmap(@"image\" + (imageNumber + 2) + ".jpg");
            picImage4.Image = new Bitmap(@"image\" + (imageNumber + 3) + ".jpg");
        }

        // QUA PHẢI
        private void showNextImage(int imgTotal) {
            if (imageNumber == imgTotal)
                imageNumber = 0;
            picMain.Image = new Bitmap(@"image\" + (imageNumber + 1) + ".jpg");
            imageNumber += 1;
        }

        //QUA TRÁI
        private void showBackImage(int imgTotal)
        {
            if (imageNumber == 1)
                imageNumber = imgTotal + 1;
            picMain.Image = new Bitmap(@"image\" + (imageNumber - 1) + ".jpg");
            imageNumber -= 1;
        }

        // HIỂN THỊ SUB IMAGE
        private void showSubImage(int imgNumber) {
            int imgTotal = getNumberImageInFordel(pathFordelImage);

            if (imageNumber == imgTotal - 2)
            {
                picImage1.Image = new Bitmap(@"image\" + imageNumber + ".jpg");
                picImage2.Image = new Bitmap(@"image\" + (imageNumber + 1) + ".jpg");
                picImage3.Image = new Bitmap(@"image\" + (imageNumber + 2) + ".jpg");
                picImage4.Image = new Bitmap(@"image\" + (imageNumber - imgTotal + 3) + ".jpg");
            }
            else if (imageNumber == imgTotal - 1) {
                picImage1.Image = new Bitmap(@"image\" + imageNumber + ".jpg");
                picImage2.Image = new Bitmap(@"image\" + (imageNumber + 1) + ".jpg");
                picImage3.Image = new Bitmap(@"image\" + (imageNumber - imgTotal + 2) + ".jpg");
                picImage4.Image = new Bitmap(@"image\" + (imageNumber - imgTotal + 3) + ".jpg");
            }else if(imageNumber == imgTotal){
                picImage1.Image = new Bitmap(@"image\" + imageNumber + ".jpg");
                picImage2.Image = new Bitmap(@"image\" + (imageNumber - imgTotal + 1) + ".jpg");
                picImage3.Image = new Bitmap(@"image\" + (imageNumber - imgTotal + 2) + ".jpg");
                picImage4.Image = new Bitmap(@"image\" + (imageNumber - imgTotal + 3) + ".jpg");
            }
            else
            {
                picImage1.Image = new Bitmap(@"image\" + imageNumber + ".jpg");
                picImage2.Image = new Bitmap(@"image\" + (imageNumber + 1) + ".jpg");
                picImage3.Image = new Bitmap(@"image\" + (imageNumber + 2) + ".jpg");
                picImage4.Image = new Bitmap(@"image\" + (imageNumber + 3) + ".jpg");
            }
        }

        #endregion

        #region event
        private void txtRight_Click(object sender, EventArgs e)
        {
            showNextImage(getNumberImageInFordel(pathFordelImage));
            showSubImage(imageNumber);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            showBackImage(getNumberImageInFordel(pathFordelImage));
            showSubImage(imageNumber);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showNextImage(getNumberImageInFordel(pathFordelImage));
            showSubImage(imageNumber);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {   
                e.Cancel = true;
            }
        }

        private void autoChuyểnẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        #endregion

        private void dừngChuyểnẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
