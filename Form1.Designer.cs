namespace obrazek___branche
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            loadButton = new Button();
            rb90 = new RadioButton();
            rb180 = new RadioButton();
            rb270 = new RadioButton();
            rotateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(163, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(600, 400);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox1_Click;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.Gray;
            loadButton.Location = new Point(37, 381);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(100, 30);
            loadButton.TabIndex = 1;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += load_Click;
            // 
            // rb90
            // 
            rb90.AutoSize = true;
            rb90.BackColor = Color.Red;
            rb90.ForeColor = Color.White;
            rb90.Location = new Point(37, 20);
            rb90.Name = "rb90";
            rb90.Size = new Size(45, 19);
            rb90.TabIndex = 2;
            rb90.TabStop = true;
            rb90.Text = "90°";
            rb90.UseVisualStyleBackColor = false;
            // 
            // rb180
            // 
            rb180.AutoSize = true;
            rb180.BackColor = Color.Red;
            rb180.ForeColor = Color.White;
            rb180.Location = new Point(37, 45);
            rb180.Name = "rb180";
            rb180.Size = new Size(51, 19);
            rb180.TabIndex = 3;
            rb180.TabStop = true;
            rb180.Text = "180°";
            rb180.UseVisualStyleBackColor = false;
            // 
            // rb270
            // 
            rb270.AutoSize = true;
            rb270.BackColor = Color.Red;
            rb270.ForeColor = Color.White;
            rb270.Location = new Point(37, 70);
            rb270.Name = "rb270";
            rb270.Size = new Size(51, 19);
            rb270.TabIndex = 4;
            rb270.TabStop = true;
            rb270.Text = "270°";
            rb270.UseVisualStyleBackColor = false;
            // 
            // rotateButton
            // 
            rotateButton.BackColor = Color.Red;
            rotateButton.ForeColor = Color.White;
            rotateButton.Location = new Point(37, 100);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(100, 30);
            rotateButton.TabIndex = 5;
            rotateButton.Text = "Rotate";
            rotateButton.UseVisualStyleBackColor = false;
            rotateButton.Click += rotate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rotateButton);
            Controls.Add(rb270);
            Controls.Add(rb180);
            Controls.Add(rb90);
            Controls.Add(loadButton);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Image Viewer";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.RadioButton rb90;
        private System.Windows.Forms.RadioButton rb180;
        private System.Windows.Forms.RadioButton rb270;
        private System.Windows.Forms.Button rotateButton;
    }
}
