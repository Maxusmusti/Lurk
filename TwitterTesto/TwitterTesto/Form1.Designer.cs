﻿namespace TwitterTesto
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
            this.testLabel = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.Location = new System.Drawing.Point(111, 196);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(204, 73);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "label1";
            this.testLabel.Click += new System.EventHandler(this.testLabel_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(506, 401);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(143, 84);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "REFRESH FEED";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 576);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.testLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button refresh;
    }
}

