
namespace CircleDrawingAlgorithm
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.centerXText = new System.Windows.Forms.TextBox();
            this.centerYText = new System.Windows.Forms.TextBox();
            this.radiusText = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.drawingPanel.Location = new System.Drawing.Point(417, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(371, 328);
            this.drawingPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Circle Center Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Center X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Center Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Radius:";
            // 
            // centerXText
            // 
            this.centerXText.Location = new System.Drawing.Point(140, 42);
            this.centerXText.Name = "centerXText";
            this.centerXText.Size = new System.Drawing.Size(100, 23);
            this.centerXText.TabIndex = 5;
            // 
            // centerYText
            // 
            this.centerYText.Location = new System.Drawing.Point(140, 78);
            this.centerYText.Name = "centerYText";
            this.centerYText.Size = new System.Drawing.Size(100, 23);
            this.centerYText.TabIndex = 6;
            // 
            // radiusText
            // 
            this.radiusText.Location = new System.Drawing.Point(86, 148);
            this.radiusText.Name = "radiusText";
            this.radiusText.Size = new System.Drawing.Size(154, 23);
            this.radiusText.TabIndex = 7;
            // 
            // drawBtn
            // 
            this.drawBtn.BackColor = System.Drawing.Color.Olive;
            this.drawBtn.Location = new System.Drawing.Point(45, 286);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(213, 39);
            this.drawBtn.TabIndex = 8;
            this.drawBtn.Text = "Draw Circle";
            this.drawBtn.UseVisualStyleBackColor = false;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.radiusText);
            this.Controls.Add(this.centerYText);
            this.Controls.Add(this.centerXText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawingPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox centerXText;
        private System.Windows.Forms.TextBox centerYText;
        private System.Windows.Forms.TextBox radiusText;
        private System.Windows.Forms.Button drawBtn;
    }
}

