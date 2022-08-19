namespace Areas1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.D1 = new System.Windows.Forms.Label();
            this.D2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NP1 = new System.Windows.Forms.Label();
            this.NP2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dice
            // 
            this.Dice.BackColor = System.Drawing.SystemColors.Control;
            this.Dice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dice.BackgroundImage")));
            this.Dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dice.Location = new System.Drawing.Point(12, 734);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(80, 80);
            this.Dice.TabIndex = 0;
            this.Dice.UseVisualStyleBackColor = false;
            this.Dice.Click += new System.EventHandler(this.Dice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(198, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 805);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.Color.SteelBlue;
            this.D1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.D1.ForeColor = System.Drawing.Color.IndianRed;
            this.D1.Location = new System.Drawing.Point(98, 734);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(40, 80);
            this.D1.TabIndex = 2;
            this.D1.Text = "D1";
            this.D1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.Color.IndianRed;
            this.D2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.D2.ForeColor = System.Drawing.Color.SteelBlue;
            this.D2.Location = new System.Drawing.Point(144, 734);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(40, 80);
            this.D2.TabIndex = 3;
            this.D2.Text = "D2";
            this.D2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "First player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Second player";
            // 
            // NP1
            // 
            this.NP1.AutoSize = true;
            this.NP1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NP1.ForeColor = System.Drawing.Color.SteelBlue;
            this.NP1.Location = new System.Drawing.Point(165, 43);
            this.NP1.Name = "NP1";
            this.NP1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NP1.Size = new System.Drawing.Size(19, 21);
            this.NP1.TabIndex = 6;
            this.NP1.Text = "0";
            this.NP1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NP2
            // 
            this.NP2.AutoSize = true;
            this.NP2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NP2.ForeColor = System.Drawing.Color.IndianRed;
            this.NP2.Location = new System.Drawing.Point(165, 125);
            this.NP2.Name = "NP2";
            this.NP2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NP2.Size = new System.Drawing.Size(19, 21);
            this.NP2.TabIndex = 7;
            this.NP2.Text = "0";
            this.NP2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 23);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 23);
            this.textBox2.TabIndex = 9;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 211);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Очистить поле";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 821);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NP2);
            this.Controls.Add(this.NP1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Dice;
        private PictureBox pictureBox1;
        private Label D1;
        private Label D2;
        private Label label3;
        private Label label4;
        private Label NP1;
        private Label NP2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button clear;
    }
}