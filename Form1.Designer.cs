namespace Launcher
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
            this.VersionText = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VersionText
            // 
            this.VersionText.AutoSize = true;
            this.VersionText.Location = new System.Drawing.Point(744, 425);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(0, 20);
            this.VersionText.TabIndex = 0;
            this.VersionText.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(305, 373);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(188, 65);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "button1";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.VersionText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VersionText;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button button1;
    }
}

