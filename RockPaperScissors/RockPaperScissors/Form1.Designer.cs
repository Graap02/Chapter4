namespace RockPaperScissors
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.txtDecision = new System.Windows.Forms.Label();
            this.txtTies = new System.Windows.Forms.Label();
            this.txtLosses = new System.Windows.Forms.Label();
            this.txtWins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock";
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.Location = new System.Drawing.Point(31, 140);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 74);
            this.btnRock.TabIndex = 1;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paper";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scissors";
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.Location = new System.Drawing.Point(126, 140);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 74);
            this.btnPaper.TabIndex = 5;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissors.BackgroundImage")));
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissors.Location = new System.Drawing.Point(220, 140);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 74);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // txtDecision
            // 
            this.txtDecision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDecision.Location = new System.Drawing.Point(31, 268);
            this.txtDecision.Name = "txtDecision";
            this.txtDecision.Size = new System.Drawing.Size(179, 148);
            this.txtDecision.TabIndex = 7;
            // 
            // txtTies
            // 
            this.txtTies.AutoSize = true;
            this.txtTies.Location = new System.Drawing.Point(238, 337);
            this.txtTies.Name = "txtTies";
            this.txtTies.Size = new System.Drawing.Size(30, 13);
            this.txtTies.TabIndex = 8;
            this.txtTies.Text = "Ties:";
            // 
            // txtLosses
            // 
            this.txtLosses.AutoSize = true;
            this.txtLosses.Location = new System.Drawing.Point(238, 403);
            this.txtLosses.Name = "txtLosses";
            this.txtLosses.Size = new System.Drawing.Size(43, 13);
            this.txtLosses.TabIndex = 9;
            this.txtLosses.Text = "Losses:";
            // 
            // txtWins
            // 
            this.txtWins.AutoSize = true;
            this.txtWins.Location = new System.Drawing.Point(238, 269);
            this.txtWins.Name = "txtWins";
            this.txtWins.Size = new System.Drawing.Size(34, 13);
            this.txtWins.TabIndex = 10;
            this.txtWins.Text = "Wins:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 492);
            this.Controls.Add(this.txtWins);
            this.Controls.Add(this.txtLosses);
            this.Controls.Add(this.txtTies);
            this.Controls.Add(this.txtDecision);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label txtDecision;
        private System.Windows.Forms.Label txtTies;
        private System.Windows.Forms.Label txtLosses;
        private System.Windows.Forms.Label txtWins;
    }
}

