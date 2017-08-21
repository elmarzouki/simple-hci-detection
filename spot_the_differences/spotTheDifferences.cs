/*
 * about:
 * This code was written by Mostafa El-Marzouki @iSuperMostafa
 * Occupation: Faculty of computer science and information Helwan university.
 * Related course: Human Computer Interaction
 * ------------------------------------------------------------
 * summery:
 * Simple Application Contains Face Detection , Shape Detection and Difference Detection game
 */
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
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;
using System.Threading;

namespace spot_the_differences
{
    public partial class spotTheDifferences : Form
    {
        Image<Bgr, byte> left_image, right_image, /*cpd_left_image, cpd_right_image,*/ difference_image/*, cpd_difference_image*/;
        double ContourThresh = 0.003;
        static int differences_number = 0, /*clicks_number = 0, */differences_found = 0;
        List<Rectangle> CriticalAreas = new List<Rectangle>();

        public spotTheDifferences()
        {
            InitializeComponent();
            left_imageBox.FunctionalMode = ImageBox.FunctionalModeOption.RightClickMenu;
            right_imageBox.FunctionalMode = ImageBox.FunctionalModeOption.RightClickMenu;
            /*NOTE: put the full path of your image*/
            left_image = new Image<Bgr, byte>(new Bitmap(@"E:\FCIH\3rd\2nd\HCI\task\spot_the_differences\spot_the_differences\\images\left.png")).Resize(345, 445, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            right_image = new Image<Bgr, byte>(new Bitmap(@"E:\FCIH\3rd\2nd\HCI\task\spot_the_differences\spot_the_differences\\images\right.png")).Resize(345, 445, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            left_imageBox.Image = left_image;
            right_imageBox.Image = right_image;
            //cpd_left_image = left_image;
            //cpd_right_image = right_image;
            detect();
        }

        public void detect()
        {
            difference_image = left_image.AbsDiff(right_image);
            difference_image = difference_image.ThresholdBinary(new Bgr(160, 160, 160), new Bgr(255, 255, 255));
            difference_imageBox.Image = difference_image;
            using (MemStorage storage = new MemStorage())
                for (Contour<Point> contours = difference_image.Convert<Gray, Byte>().FindContours(
                        Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                        Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST,
                        storage);
                    contours != null;
                    contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);
                    if (currentContour.Area > ContourThresh)
                    {
                        CriticalAreas.Add(currentContour.BoundingRectangle);
                        differences_number++;
                    }
                }
            detected_label.Text = "detected "+differences_found.ToString() + " / " + differences_number.ToString();
            
        }


        private void spotTheDifferences_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        

        private void left_imageBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left /*&& clicks_number < differences_number*/)
            {
                if (checkClick(new Point(e.X, e.Y)))
                {
                    int posX = e.X - 15, posY = e.Y - 15;
                    Image actual_left_image = (Image)left_imageBox.Image.Bitmap;
                    Graphics graphics_left = Graphics.FromImage(actual_left_image);
                    Pen left_painter = new Pen(Color.Green, 4);
                    graphics_left.DrawRectangle(left_painter, posX, posY, 30, 30);
                    graphics_left.Save();
                    left_imageBox.Image = new Image<Bgr, byte>(new Bitmap(actual_left_image));

                    Image actual_right_image = (Image)right_imageBox.Image.Bitmap;
                    Graphics graphics_right = Graphics.FromImage(actual_right_image);
                    Pen right_painter = new Pen(Color.Green, 4);
                    graphics_right.DrawRectangle(right_painter, posX, posY, 30, 30);
                    graphics_right.Save();
                    right_imageBox.Image = new Image<Bgr, byte>(new Bitmap(actual_right_image));

                    if (differences_number == differences_found)
                    {
                        Exit_button.Visible = true;
                        New_button.Visible = true;
                        congratulations_label.Visible = true;
                    }

                }
            }
            
        }
        public bool checkClick(Point point)
        {
            foreach (var rectangle in CriticalAreas)
            {
                if (rectangle.Contains(point))
                {
                    differences_found++;
                    detected_label.Text = "detected " + differences_found.ToString() + " / " + differences_number.ToString();
                    
                    CriticalAreas.Remove(rectangle);
                    return true;
                }
            }
            return false;
        }

        private void New_button_Click(object sender, EventArgs e)
        {
            
            differences_number = 0;
            differences_found = 0;
            spotTheDifferences New_Game = new spotTheDifferences();
            this.Visible = false;
            New_Game.Visible = true;

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
