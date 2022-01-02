namespace Areas
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
            this.Dice = new System.Windows.Forms.Button();
            this.D1 = new System.Windows.Forms.Label();
            this.D2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NP1 = new System.Windows.Forms.Label();
            this.NP2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dice
            // 
            this.Dice.BackgroundImage = global::Areas.Properties.Resources.Dice;
            this.Dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dice.Location = new System.Drawing.Point(12, 573);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(178, 179);
            this.Dice.TabIndex = 1;
            this.Dice.UseVisualStyleBackColor = true;
            this.Dice.Click += new System.EventHandler(this.Dice_Click);
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.SystemColors.Info;
            this.D1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D1.Location = new System.Drawing.Point(12, 490);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(80, 80);
            this.D1.TabIndex = 2;
            this.D1.Text = "D1";
            this.D1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.SystemColors.Info;
            this.D2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D2.Location = new System.Drawing.Point(110, 490);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(80, 80);
            this.D2.TabIndex = 3;
            this.D2.Text = "D2";
            this.D2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "First player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second player";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 29);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 29);
            this.textBox2.TabIndex = 7;
            // 
            // NP1
            // 
            this.NP1.AutoSize = true;
            this.NP1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NP1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NP1.Location = new System.Drawing.Point(168, 27);
            this.NP1.Name = "NP1";
            this.NP1.Size = new System.Drawing.Size(22, 25);
            this.NP1.TabIndex = 8;
            this.NP1.Text = "0";
            // 
            // NP2
            // 
            this.NP2.AutoSize = true;
            this.NP2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NP2.ForeColor = System.Drawing.Color.Firebrick;
            this.NP2.Location = new System.Drawing.Point(168, 109);
            this.NP2.Name = "NP2";
            this.NP2.Size = new System.Drawing.Size(22, 25);
            this.NP2.TabIndex = 9;
            this.NP2.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(196, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 800);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Areas.Properties.Resources.paper_space1;
            this.ClientSize = new System.Drawing.Size(804, 822);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NP2);
            this.Controls.Add(this.NP1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.Dice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Dice;
        private Label D1;
        private Label D2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label NP1;
        private Label NP2;
        private PictureBox pictureBox1;
    }
}