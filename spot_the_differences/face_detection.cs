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
using Emgu.CV.UI;
using Emgu.Util;

namespace spot_the_differences
{
    public partial class face_detection : Form
    {
        private Capture capture_cam = null;
        bool capture_in_progress = false;
        private HaarCascade frontal_face_detector = null;
        MCvAvgComp[] detected_faces = null;
        Image<Bgr, byte> original_img;
        Image<Gray, byte> original_gray;
        double scale = 1.1;
        int min_neighbor = 2;
        int win_size = 25;

        public face_detection()
        {
            InitializeComponent();
            frontal_face_detector = new HaarCascade(@"haarcascade_frontalface_default.xml");
        }

        private void face_detection_Load(object sender, EventArgs e)
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
                capture_in_progress = true;
                capture_cam = new Capture();
            }
            original_img = null;
            original_gray = null;
            Application.Idle += processing;
        }

        private void processing(object obj, EventArgs e)
        {

            if (capture_radioButton.Checked)
            {
                original_img = capture_cam.QueryFrame();
            }
            original_gray = original_img.Convert<Gray, byte>();
            detected_faces = frontal_face_detector.Detect(original_gray, scale, min_neighbor, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(win_size, win_size), new Size(win_size, win_size));
            if (detected_faces.Length > 0)
            {
                foreach (MCvAvgComp face in detected_faces)
                {
                    original_img.Draw(face.rect, new Bgr(Color.Red), 3);
                    Next_button.Visible = true;
                }
            }
            face_detection_imageBox.Image = original_img.Resize(face_detection_imageBox.Width, face_detection_imageBox.Height, INTER.CV_INTER_LINEAR);
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            shape_detection shapeDetiction = new shape_detection();
            shapeDetiction.Visible = true;
        }

        

    }
}
