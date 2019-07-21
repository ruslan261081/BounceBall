namespace BounceBallProject
{
    partial class BounceBall
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
            this.Jumpbtn = new System.Windows.Forms.Button();
            this.AddBallbtrn = new System.Windows.Forms.Button();
            this.RemoveBallbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Jumpbtn
            // 
            this.Jumpbtn.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jumpbtn.Location = new System.Drawing.Point(-2, -1);
            this.Jumpbtn.Name = "Jumpbtn";
            this.Jumpbtn.Size = new System.Drawing.Size(196, 52);
            this.Jumpbtn.TabIndex = 0;
            this.Jumpbtn.Text = "Jump";
            this.Jumpbtn.UseVisualStyleBackColor = true;
            this.Jumpbtn.Click += new System.EventHandler(this.Jumpbtn_Click);
            // 
            // AddBallbtrn
            // 
            this.AddBallbtrn.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBallbtrn.Location = new System.Drawing.Point(186, -1);
            this.AddBallbtrn.Name = "AddBallbtrn";
            this.AddBallbtrn.Size = new System.Drawing.Size(226, 52);
            this.AddBallbtrn.TabIndex = 1;
            this.AddBallbtrn.Text = "AddNewBall";
            this.AddBallbtrn.UseVisualStyleBackColor = true;
            this.AddBallbtrn.Click += new System.EventHandler(this.AddBallbtrn_Click);
            // 
            // RemoveBallbtn
            // 
            this.RemoveBallbtn.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBallbtn.Location = new System.Drawing.Point(406, -1);
            this.RemoveBallbtn.Name = "RemoveBallbtn";
            this.RemoveBallbtn.Size = new System.Drawing.Size(208, 52);
            this.RemoveBallbtn.TabIndex = 2;
            this.RemoveBallbtn.Text = "RemoveBall";
            this.RemoveBallbtn.UseVisualStyleBackColor = true;
            this.RemoveBallbtn.Click += new System.EventHandler(this.RemoveBallbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BounceBallProject.Properties.Resources.untitled_png12;
            this.pictureBox2.Location = new System.Drawing.Point(381, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 182);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BounceBallProject.Properties.Resources.orig1;
            this.pictureBox1.Image = global::BounceBallProject.Properties.Resources.untitled;
            this.pictureBox1.Location = new System.Drawing.Point(42, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BounceBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RemoveBallbtn);
            this.Controls.Add(this.AddBallbtrn);
            this.Controls.Add(this.Jumpbtn);
            this.Name = "BounceBall";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BounceBall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Jumpbtn;
        private System.Windows.Forms.Button AddBallbtrn;
        private System.Windows.Forms.Button RemoveBallbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

