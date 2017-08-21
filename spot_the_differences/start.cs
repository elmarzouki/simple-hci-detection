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

namespace spot_the_differences
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
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

        private void start_button_Click(object sender, EventArgs e)
        {
            
            face_detection faceDetiction = new face_detection();
            this.Visible = false;
            faceDetiction.Visible = true;
            //spotTheDifferences spotTheDifferencesForm = new spotTheDifferences();
            //spotTheDifferencesForm.Visible = true;
        }

    }
}
