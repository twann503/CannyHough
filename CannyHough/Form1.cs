using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.IO;

namespace CannyHough {
    public partial class Form1 : Form {

        private Mat img;

        public Form1() {
            InitializeComponent();
       
        }


        private void load_source_Click(object sender, EventArgs e) {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes) {
                source_txtbox.Text = openFileDialog1.FileName;
            }
        }


        private void button1_Click(object sender, EventArgs e) {
            houghs(img, "test");
        }


        private void button2_Click(object sender, EventArgs e) {
            img = new Mat(source_txtbox.Text, LoadImageType.Grayscale);
            CvInvoke.Resize(img, img, new Size(1920, 1080));
            imageBox1.Image = img;
        }


        // functions 

        private void houghs(Mat srcImg, string saveLocation) {

            Image<Gray, Byte> SmoothedImg = new Image<Gray, byte>(srcImg.Bitmap);

            SmoothedImg = SmoothedImg.SmoothGaussian(5, 5, 0, 0);

            double cannyUpper = CvInvoke.Threshold(SmoothedImg, SmoothedImg, 0, 255, ThresholdType.Otsu);
            double cannyLower = cannyUpper*.05;

            OtsuText.Text = Convert.ToString(cannyUpper);

            UMat cannyImg = new UMat();
            CvInvoke.Canny(SmoothedImg, cannyImg, cannyLower, cannyUpper);

            LineSegment2D[] lines = CvInvoke.HoughLinesP(
               cannyImg,
               1, //Distance resolution in pixel-related units
               Math.PI / 45.0, //Angle resolution measured in radians.
               20, //threshold
               30, //min Line width
               10); //gap between lines


            Mat lineImage = new Mat(img.Size, DepthType.Cv8U, 3);
            lineImage.SetTo(new MCvScalar(0));
            foreach (LineSegment2D line in lines)
                CvInvoke.Line(lineImage, line.P1, line.P2, new Bgr(Color.Green).MCvScalar, 2);

            //imageBox1.Image = lineImage;

            lineImage.Save(saveLocation);

            //Dealloc Memory
            SmoothedImg.Dispose();
            lineImage.Dispose();
            cannyImg.Dispose();

        }


        private void transformBulk() {



        }

        private void button3_Click(object sender, EventArgs e) {

            string[] pictures ;
        
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes) {
                pictures = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                foreach (string k in pictures) {

                    using (img = new Mat(k, LoadImageType. Grayscale)) {

                        //MessageBox.Show(img.Width.ToString() + " " + " " + img.Height.ToString());

                        CvInvoke.Resize(img, img, new Size(img.Width / 4, img.Height / 4));

                        //string value = k.Insert((k.Length - 3), "1");

                        houghs(img, k);

                    }
                
                }

            }

            MessageBox.Show("Bulk Transform Complete!");
        }

        private void button2_Click_1(object sender, EventArgs e) {


        }
    }
}
