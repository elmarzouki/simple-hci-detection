namespace spot_the_differences
{
    partial class spotTheDifferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spotTheDifferences));
            this.right_imageBox = new Emgu.CV.UI.ImageBox();
            this.left_imageBox = new Emgu.CV.UI.ImageBox();
            this.detected_label = new System.Windows.Forms.Label();
            this.difference_imageBox = new Emgu.CV.UI.ImageBox();
            this.Exit_button = new System.Windows.Forms.Button();
            this.congratulations_label = new System.Windows.Forms.Label();
            this.New_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.right_imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference_imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // right_imageBox
            // 
            this.right_imageBox.Location = new System.Drawing.Point(691, 155);
            this.right_imageBox.Name = "right_imageBox";
            this.right_imageBox.Size = new System.Drawing.Size(345, 445);
            this.right_imageBox.TabIndex = 10;
            this.right_imageBox.TabStop = false;
            // 
            // left_imageBox
            // 
            this.left_imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.left_imageBox.Location = new System.Drawing.Point(332, 155);
            this.left_imageBox.Name = "left_imageBox";
            this.left_imageBox.Size = new System.Drawing.Size(345, 445);
            this.left_imageBox.TabIndex = 9;
            this.left_imageBox.TabStop = false;
            this.left_imageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_imageBox_MouseDown);
            // 
            // detected_label
            // 
            this.detected_label.AutoSize = true;
            this.detected_label.BackColor = System.Drawing.Color.Transparent;
            this.detected_label.Font = new System.Drawing.Font("BN Deep Blue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detected_label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.detected_label.Location = new System.Drawing.Point(584, 99);
            this.detected_label.Name = "detected_label";
            this.detected_label.Size = new System.Drawing.Size(199, 39);
            this.detected_label.TabIndex = 11;
            this.detected_label.Text = "detected 0 / 0";
            // 
            // difference_imageBox
            // 
            this.difference_imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.difference_imageBox.Location = new System.Drawing.Point(2, 155);
            this.difference_imageBox.Name = "difference_imageBox";
            this.difference_imageBox.Size = new System.Drawing.Size(345, 445);
            this.difference_imageBox.TabIndex = 12;
            this.difference_imageBox.TabStop = false;
            this.difference_imageBox.Visible = false;
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.AliceBlue;
            this.Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("BN Deep Blue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(1118, 331);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(101, 87);
            this.Exit_button.TabIndex = 14;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Visible = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // congratulations_label
            // 
            this.congratulations_label.AutoSize = true;
            this.congratulations_label.BackColor = System.Drawing.Color.Transparent;
            this.congratulations_label.Font = new System.Drawing.Font("BN Deep Blue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratulations_label.ForeColor = System.Drawing.Color.AliceBlue;
            this.congratulations_label.Location = new System.Drawing.Point(540, 39);
            this.congratulations_label.Name = "congratulations_label";
            this.congratulations_label.Size = new System.Drawing.Size(277, 50);
            this.congratulations_label.TabIndex = 15;
            this.congratulations_label.Text = "congratulations";
            this.congratulations_label.Visible = false;
            // 
            // New_button
            // 
            this.New_button.BackColor = System.Drawing.Color.AliceBlue;
            this.New_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.New_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_button.Font = new System.Drawing.Font("BN Deep Blue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_button.Location = new System.Drawing.Point(155, 331);
            this.New_button.Name = "New_button";
            this.New_button.Size = new System.Drawing.Size(101, 87);
            this.New_button.TabIndex = 16;
            this.New_button.Text = "New";
            this.New_button.UseVisualStyleBackColor = false;
            this.New_button.Visible = false;
            this.New_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // spotTheDifferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.New_button);
            this.Controls.Add(this.congratulations_label);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.difference_imageBox);
            this.Controls.Add(this.detected_label);
            this.Controls.Add(this.right_imageBox);
            this.Controls.Add(this.left_imageBox);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "spotTheDifferences";
            this.Text = "spot the differences";
            this.Load += new System.EventHandler(this.spotTheDifferences_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.right_imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference_imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox right_imageBox;
        private Emgu.CV.UI.ImageBox left_imageBox;
        private System.Windows.Forms.Label detected_label;
        private Emgu.CV.UI.ImageBox difference_imageBox;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label congratulations_label;
        private System.Windows.Forms.Button New_button;
    }
}