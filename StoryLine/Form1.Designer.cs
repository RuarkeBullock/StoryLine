namespace StoryLine
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
            this.topLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.option3Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topLabel.Location = new System.Drawing.Point(51, -2);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(310, 90);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Start?";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(51, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option1Label.Location = new System.Drawing.Point(119, 291);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(229, 47);
            this.option1Label.TabIndex = 3;
            this.option1Label.Text = "yes";
            this.option1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option2Label.Location = new System.Drawing.Point(119, 344);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(229, 47);
            this.option2Label.TabIndex = 4;
            this.option2Label.Text = "No";
            this.option2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(51, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option3Label.Location = new System.Drawing.Point(119, 397);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(229, 47);
            this.option3Label.TabIndex = 6;
            this.option3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(51, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Image = global::StoryLine.Properties.Resources.Screen_Shot_2018_11_24_at_5_51_21_PM_768x495;
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 207);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(405, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topLabel);
            this.Name = "Form1";
            this.Text = "DIDDIES MANSION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Label label1;
    }
}

