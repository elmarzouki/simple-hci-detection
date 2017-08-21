namespace spot_the_differences
{
    partial class shape_detection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shape_detection));
            this.Next_button = new System.Windows.Forms.Button();
            this.original_imageBox = new Emgu.CV.UI.ImageBox();
            this.detected_imageBox = new Emgu.CV.UI.ImageBox();
            this.capture_radioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.original_imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detected_imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Next_button
            // 
            this.Next_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Font = new System.Drawing.Font("BN Deep Blue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_button.Location = new System.Drawing.Point(941, 560);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(84, 41);
            this.Next_button.TabIndex = 1;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = false;
            this.Next_button.Visible = false;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // original_imageBox
            // 
            this.original_imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.original_imageBox.Location = new System.Drawing.Point(367, 157);
            this.original_imageBox.Name = "original_imageBox";
            this.original_imageBox.Size = new System.Drawing.Size(300, 300);
            this.original_imageBox.TabIndex = 2;
            this.original_imageBox.TabStop = false;
            // 
            // detected_imageBox
            // 
            this.detected_imageBox.Location = new System.Drawing.Point(689, 157);
            this.detected_imageBox.Name = "detected_imageBox";
            this.detected_imageBox.Size = new System.Drawing.Size(300, 300);
            this.detected_imageBox.TabIndex = 8;
            this.detected_imageBox.TabStop = false;
            // 
            // capture_radioButton
            // 
            this.capture_radioButton.AutoSize = true;
            this.capture_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.capture_radioButton.Font = new System.Drawing.Font("BN Deep Blue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capture_radioButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.capture_radioButton.Location = new System.Drawing.Point(440, 487);
            this.capture_radioButton.Name = "capture_radioButton";
            this.capture_radioButton.Size = new System.Drawing.Size(173, 38);
            this.capture_radioButton.TabIndex = 5;
            this.capture_radioButton.Text = "capture now";
            this.capture_radioButton.UseVisualStyleBackColor = false;
            this.capture_radioButton.CheckedChanged += new System.EventHandler(this.capture_radioButton_CheckedChanged);
            // 
            // shape_detection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.detected_imageBox);
            this.Controls.Add(this.original_imageBox);
            this.Controls.Add(this.capture_radioButton);
            this.Controls.Add(this.Next_button);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "shape_detection";
            this.Text = "shape detection";
            this.Load += new System.EventHandler(this.shape_detection_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.original_imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detected_imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next_button;
        private Emgu.CV.UI.ImageBox original_imageBox;
        private Emgu.CV.UI.ImageBox detected_imageBox;
        private System.Windows.Forms.RadioButton capture_radioButton;
    }
}