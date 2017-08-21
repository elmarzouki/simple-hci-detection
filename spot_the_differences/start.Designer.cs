namespace spot_the_differences
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.welcome_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("DexGothicD", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.welcome_label.Location = new System.Drawing.Point(471, 234);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(420, 104);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "welcome";
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Font = new System.Drawing.Font("BN Deep Blue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(534, 405);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(282, 73);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.welcome_label);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "start";
            this.Text = "spot the differences";
            this.Load += new System.EventHandler(this.start_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button start_button;

    }
}

