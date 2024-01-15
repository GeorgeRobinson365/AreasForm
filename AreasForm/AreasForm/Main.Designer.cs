namespace AreasForm
{
    partial class Main
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
            TriangleButton = new Button();
            RectangleButton = new Button();
            CircleButton = new Button();
            SuspendLayout();
            // 
            // TriangleButton
            // 
            TriangleButton.Location = new Point(80, 137);
            TriangleButton.Name = "TriangleButton";
            TriangleButton.Size = new Size(75, 23);
            TriangleButton.TabIndex = 0;
            TriangleButton.Text = "Triangle";
            TriangleButton.UseVisualStyleBackColor = true;
            TriangleButton.Click += button1_Click;
            // 
            // RectangleButton
            // 
            RectangleButton.Location = new Point(365, 137);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(75, 23);
            RectangleButton.TabIndex = 1;
            RectangleButton.Text = "Circle";
            RectangleButton.UseVisualStyleBackColor = true;
            RectangleButton.Click += button2_Click;
            // 
            // CircleButton
            // 
            CircleButton.Location = new Point(594, 137);
            CircleButton.Name = "CircleButton";
            CircleButton.Size = new Size(75, 23);
            CircleButton.TabIndex = 2;
            CircleButton.Text = "Rectangle";
            CircleButton.UseVisualStyleBackColor = true;
            CircleButton.Click += button3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CircleButton);
            Controls.Add(RectangleButton);
            Controls.Add(TriangleButton);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button TriangleButton;
        private Button RectangleButton;
        private Button CircleButton;
    }
}
