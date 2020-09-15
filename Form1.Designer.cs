namespace Homework2_Coinflip
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
            this.Flip = new System.Windows.Forms.Button();
            this.Tails = new System.Windows.Forms.PictureBox();
            this.Heads = new System.Windows.Forms.PictureBox();
            this.Outcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heads)).BeginInit();
            this.SuspendLayout();
            // 
            // Flip
            // 
            this.Flip.Location = new System.Drawing.Point(166, 263);
            this.Flip.Name = "Flip";
            this.Flip.Size = new System.Drawing.Size(75, 23);
            this.Flip.TabIndex = 0;
            this.Flip.Text = "flip";
            this.Flip.UseVisualStyleBackColor = true;
            this.Flip.Click += new System.EventHandler(this.Flip_Click);
            // 
            // Tails
            // 
            this.Tails.Image = global::Homework2_Coinflip.Properties.Resources.Tails2;
            this.Tails.Location = new System.Drawing.Point(324, 119);
            this.Tails.Name = "Tails";
            this.Tails.Size = new System.Drawing.Size(510, 494);
            this.Tails.TabIndex = 1;
            this.Tails.TabStop = false;
            this.Tails.Click += new System.EventHandler(this.Tails_Click);
            // 
            // Heads
            // 
            this.Heads.Image = global::Homework2_Coinflip.Properties.Resources.Heads2;
            this.Heads.Location = new System.Drawing.Point(324, 119);
            this.Heads.Name = "Heads";
            this.Heads.Size = new System.Drawing.Size(510, 494);
            this.Heads.TabIndex = 2;
            this.Heads.TabStop = false;
            this.Heads.Visible = false;
            this.Heads.Click += new System.EventHandler(this.Heads_Click);
            // 
            // Outcome
            // 
            this.Outcome.AutoSize = true;
            this.Outcome.Location = new System.Drawing.Point(171, 316);
            this.Outcome.Name = "Outcome";
            this.Outcome.Size = new System.Drawing.Size(16, 13);
            this.Outcome.TabIndex = 3;
            this.Outcome.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 672);
            this.Controls.Add(this.Outcome);
            this.Controls.Add(this.Heads);
            this.Controls.Add(this.Tails);
            this.Controls.Add(this.Flip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Flip;
        private System.Windows.Forms.PictureBox Tails;
        private System.Windows.Forms.PictureBox Heads;
        private System.Windows.Forms.Label Outcome;
    }
}

