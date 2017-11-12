namespace TextAdventure
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
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Location = new System.Drawing.Point(12, 9);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(35, 13);
            this.lblStatusBar.TabIndex = 0;
            this.lblStatusBar.Text = "label1";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(12, 40);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(400, 192);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "label1";
            // 
            // btnChoice1
            // 
            this.btnChoice1.Location = new System.Drawing.Point(12, 235);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(400, 23);
            this.btnChoice1.TabIndex = 2;
            this.btnChoice1.Text = "button1";
            this.btnChoice1.UseVisualStyleBackColor = true;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.Location = new System.Drawing.Point(12, 264);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(400, 23);
            this.btnChoice2.TabIndex = 3;
            this.btnChoice2.Text = "button2";
            this.btnChoice2.UseVisualStyleBackColor = true;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.Location = new System.Drawing.Point(12, 293);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(400, 23);
            this.btnChoice3.TabIndex = 4;
            this.btnChoice3.Text = "button3";
            this.btnChoice3.UseVisualStyleBackColor = true;
            this.btnChoice3.Click += new System.EventHandler(this.btnChoice3_Click);
            // 
            // btnChoice4
            // 
            this.btnChoice4.Location = new System.Drawing.Point(12, 322);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Size = new System.Drawing.Size(400, 23);
            this.btnChoice4.TabIndex = 5;
            this.btnChoice4.Text = "button4";
            this.btnChoice4.UseVisualStyleBackColor = true;
            this.btnChoice4.Click += new System.EventHandler(this.btnChoice4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 371);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblStatusBar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusBar;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Button btnChoice4;
    }
}

