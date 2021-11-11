
namespace MousePos
{
    partial class MousePos
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
            this.xLab = new System.Windows.Forms.Label();
            this.yLab = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // xLab
            // 
            this.xLab.AutoSize = true;
            this.xLab.Location = new System.Drawing.Point(13, 13);
            this.xLab.Name = "xLab";
            this.xLab.Size = new System.Drawing.Size(57, 13);
            this.xLab.TabIndex = 0;
            this.xLab.Text = "X Position:";
            // 
            // yLab
            // 
            this.yLab.AutoSize = true;
            this.yLab.Location = new System.Drawing.Point(13, 30);
            this.yLab.Name = "yLab";
            this.yLab.Size = new System.Drawing.Size(57, 13);
            this.yLab.TabIndex = 1;
            this.yLab.Text = "Y Position:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // MousePos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 51);
            this.Controls.Add(this.yLab);
            this.Controls.Add(this.xLab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MousePos";
            this.ShowIcon = false;
            this.Text = "MousePos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MousePos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xLab;
        private System.Windows.Forms.Label yLab;
        private System.Windows.Forms.Timer timer;
    }
}

