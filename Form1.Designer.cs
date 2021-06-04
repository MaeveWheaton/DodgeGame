
namespace DodgeGame
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Location = new System.Drawing.Point(-1, 140);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(606, 78);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "titleLabel";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTitleLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.subTitleLabel.Location = new System.Drawing.Point(-1, 198);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(606, 78);
            this.subTitleLabel.TabIndex = 1;
            this.subTitleLabel.Text = "subTitleLabel";
            this.subTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
    }
}

