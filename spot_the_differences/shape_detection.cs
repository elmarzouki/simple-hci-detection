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

namespace spot_the_differences
{
    public partial class shape_detection : Form
    {
        bool capture_In_Progress = true;
        Capture capture_cam = null;
        Image<Bgr, byte> original_Image = null;
        Image<Bgr, byte> smoothed_Image, detected_Image;
        Image<Gray, byte> gray_Image, cannay_Image;
        
        public shape_detection()
        {
            InitializeComponent();
        }
        private void shape_detection_Load(object sender, EventArgs e)
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
        private void capture_radioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (capture_radioButton.Checked)
            {
                try
                {
                    capture_cam = new Capture();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Camera not capture anything");
                }
                capture_In_Progress = true;
                Application.Idle += processing;

            }
        }

        private void processing(object sender, EventArgs args)
        {

            if (capture_radioButton.Checked) { original_Image = capture_cam.QueryFrame(); }

            smoothed_Image = original_Image.PyrDown().PyrUp();
            smoothed_Image._SmoothGaussian(3);


            Gray gray_Cannay_threshold = new Gray(160);
            Gray gray_Circle_Cannay_threshold = new Gray(100);
            Gray gray_threshold_Linking = new Gray(80);

            gray_Image = original_Image.Convert<Gray, byte>();
            cannay_Image = gray_Image.Canny(gray_Cannay_threshold, gray_threshold_Linking);

            detected_Image = original_Image.CopyBlank();

            double db_Accum_res = 2.0;
            double min_distance_between_circles = gray_Image.Height / 4;
            int min_radius = 10;
            int max_radius = 4000;
            CircleF[] circles = gray_Image.HoughCircles(gray_Cannay_threshold, gray_Circle_Cannay_threshold, db_Accum_res, min_distance_between_circles, min_radius, max_radius)[0];

            foreach (CircleF circle in circles)
            {
                detected_Image.Draw(circle, new Bgr(Color.Red), 2);
            }

            double db_line_res = 1.0;
            double db_line_angle_res = 4.0 * (Math.PI / 180.0);
            int line_threshold = 20;
            double min_line_width = 30.0;
            double max_line_height = 10.0;

            LineSegment2D[] lines = cannay_Image.HoughLinesBinary(db_line_res, db_line_angle_res, line_threshold, min_line_width, max_line_height)[0];

            foreach (LineSegment2D line in lines)
            {
                detected_Image.Draw(line, new Bgr(Color.Green), 2);
            }

            Contour<Point> contours = cannay_Image.FindContours();
            List<Triangle2DF> triangles = new List<Triangle2DF>();
            List<MCvBox2D> rectangles = new List<MCvBox2D>();
            List<Contour<Point>> polygon = new List<Contour<Point>>();

            while (contours != null)
            {
                Contour<Point> contour = contours.ApproxPoly(10.0);
                if (contour.Area > 250.0)
                {
                    if (contour.Total == 3)
                    {
                        Point[] points = contour.ToArray();
                        triangles.Add(new Triangle2DF(points[0], points[1], points[2]));
                    }
                    else if (contour.Total >= 4 && contour.Total <= 6)
                    {
                        Point[] points = contour.ToArray();
                        bool isRect = true;
                        if (contour.Total == 4)
                        {
                            LineSegment2D[] edges = PointCollection.PolyLine(points, true);
                            for (int i = 0; i < edges.Length; i++)
                            {
                                double angle = Math.Abs(edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                if (angle < 80 || angle > 100)
                                    isRect = false;
                            }
                        }
                        else
                            isRect = false;
                        if (isRect){
                            rectangles.Add(contour.GetMinAreaRect());
                            
                        }

                        else
                        {
                            polygon.Add(contour);
                            Next_button.Visible = true;
                        }
                            
                    }
                }
                contours = contours.HNext;
                
            }
            foreach (Triangle2DF triangle in triangles)
            {
                detected_Image.Draw(triangle, new Bgr(Color.Yellow), 2);

            }
            foreach (MCvBox2D rect in rectangles)
            {
                detected_Image.Draw(rect, new Bgr(Color.White), 2);

            }
            foreach (Contour<Point> poly in polygon)
            {
                detected_Image.Draw(poly, new Bgr(Color.Red), 2);

            }

            original_imageBox.Image = original_Image;
            detected_imageBox.Image = detected_Image;
            
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            
            spotTheDifferences spotTheDifferencesForm = new spotTheDifferences();
            this.Visible = false;
            spotTheDifferencesForm.Visible = true;
        }

        
    }
}
