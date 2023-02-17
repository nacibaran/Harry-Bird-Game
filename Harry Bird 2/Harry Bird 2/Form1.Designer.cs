namespace Harry_Bird_2
{
    partial class HarryKodder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarryKodder));
            this.label1 = new System.Windows.Forms.Label();
            this.pctrColonAlt = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pctrHarry = new System.Windows.Forms.PictureBox();
            this.pctrZemin = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pctrColonUst = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctrup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrColonAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHarry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrZemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrColonUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // pctrColonAlt
            // 
            this.pctrColonAlt.Image = ((System.Drawing.Image)(resources.GetObject("pctrColonAlt.Image")));
            this.pctrColonAlt.Location = new System.Drawing.Point(582, 282);
            this.pctrColonAlt.Name = "pctrColonAlt";
            this.pctrColonAlt.Size = new System.Drawing.Size(62, 167);
            this.pctrColonAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrColonAlt.TabIndex = 2;
            this.pctrColonAlt.TabStop = false;
            this.pctrColonAlt.Click += new System.EventHandler(this.pctrColonAlt_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(1, 466);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(954, 18);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pctrHarry
            // 
            this.pctrHarry.Image = ((System.Drawing.Image)(resources.GetObject("pctrHarry.Image")));
            this.pctrHarry.Location = new System.Drawing.Point(13, 208);
            this.pctrHarry.Name = "pctrHarry";
            this.pctrHarry.Size = new System.Drawing.Size(50, 41);
            this.pctrHarry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctrHarry.TabIndex = 5;
            this.pctrHarry.TabStop = false;
            this.pctrHarry.Click += new System.EventHandler(this.Form1_Load);
            // 
            // pctrZemin
            // 
            this.pctrZemin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pctrZemin.Location = new System.Drawing.Point(1, 449);
            this.pctrZemin.Name = "pctrZemin";
            this.pctrZemin.Size = new System.Drawing.Size(954, 18);
            this.pctrZemin.TabIndex = 6;
            this.pctrZemin.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Enabled = false;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(24, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(87, 25);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score :";
            this.lblScore.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 17;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pctrColonUst
            // 
            this.pctrColonUst.Image = ((System.Drawing.Image)(resources.GetObject("pctrColonUst.Image")));
            this.pctrColonUst.Location = new System.Drawing.Point(508, -1);
            this.pctrColonUst.Name = "pctrColonUst";
            this.pctrColonUst.Size = new System.Drawing.Size(61, 167);
            this.pctrColonUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrColonUst.TabIndex = 3;
            this.pctrColonUst.TabStop = false;
            this.pctrColonUst.Click += new System.EventHandler(this.pctrColonUst_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctrup
            // 
            this.pctrup.Location = new System.Drawing.Point(29, -14);
            this.pctrup.Name = "pctrup";
            this.pctrup.Size = new System.Drawing.Size(323, 10);
            this.pctrup.TabIndex = 9;
            this.pctrup.TabStop = false;
            // 
            // HarryKodder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(636, 482);
            this.Controls.Add(this.pctrup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pctrZemin);
            this.Controls.Add(this.pctrHarry);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pctrColonUst);
            this.Controls.Add(this.pctrColonAlt);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "HarryKodder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pctrColonAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHarry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrZemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrColonUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctrColonAlt;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pctrHarry;
        private System.Windows.Forms.PictureBox pctrZemin;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pctrColonUst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctrup;
    }
}

