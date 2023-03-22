namespace Paletka
{
    partial class FormArkanoid
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
            components = new System.ComponentModel.Container();
            pictureBoxBoard = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoard).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBoard
            // 
            pictureBoxBoard.Dock = DockStyle.Fill;
            pictureBoxBoard.Location = new Point(0, 0);
            pictureBoxBoard.Name = "pictureBoxBoard";
            pictureBoxBoard.Size = new Size(800, 450);
            pictureBoxBoard.TabIndex = 0;
            pictureBoxBoard.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FormArkanoid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxBoard);
            Name = "FormArkanoid";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += FormArkanoid_KeyDown;
            KeyUp += FormArkanoid_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxBoard;
        private System.Windows.Forms.Timer timer1;
    }
}