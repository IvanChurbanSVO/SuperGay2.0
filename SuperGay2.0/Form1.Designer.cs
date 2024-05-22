namespace SuperGay2._0
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
            components = new System.ComponentModel.Container();
            pictureBoxIronMine = new PictureBox();
            labelBalance = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxCoalMine = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIronMine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoalMine).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIronMine
            // 
            pictureBoxIronMine.Image = Resource1.шахта;
            pictureBoxIronMine.Location = new Point(44, 115);
            pictureBoxIronMine.Name = "pictureBoxIronMine";
            pictureBoxIronMine.Size = new Size(226, 180);
            pictureBoxIronMine.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIronMine.TabIndex = 0;
            pictureBoxIronMine.TabStop = false;
            pictureBoxIronMine.Click += pictureBoxIronMine_Click;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Roblox 2017", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalance.Location = new Point(29, 43);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(331, 36);
            labelBalance.TabIndex = 1;
            labelBalance.Text = "Balance: 100$";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBoxCoalMine
            // 
            pictureBoxCoalMine.Image = Resource1.угольная_шахта;
            pictureBoxCoalMine.Location = new Point(321, 115);
            pictureBoxCoalMine.Name = "pictureBoxCoalMine";
            pictureBoxCoalMine.Size = new Size(226, 182);
            pictureBoxCoalMine.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCoalMine.TabIndex = 2;
            pictureBoxCoalMine.TabStop = false;
            pictureBoxCoalMine.Click += pictureBoxCoalMine_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 636);
            Controls.Add(pictureBoxCoalMine);
            Controls.Add(labelBalance);
            Controls.Add(pictureBoxIronMine);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIronMine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoalMine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIronMine;
        private Label labelBalance;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBoxCoalMine;
    }
}
