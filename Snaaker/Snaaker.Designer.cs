namespace Snaaker
{
    partial class Snaaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snaaker));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.topStrip = new System.Windows.Forms.ToolStrip();
            this.startGameButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rulesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.snaakerLabel = new System.Windows.Forms.ToolStripLabel();
            this.subTitleLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fixedLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.scoreLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.topStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.gameOverLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pictureBoxCanvas);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 400);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 436);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.topStrip);
            this.toolStripContainer1.TopToolStripPanel.MaximumSize = new System.Drawing.Size(0, 36);
            this.toolStripContainer1.TopToolStripPanel.MinimumSize = new System.Drawing.Size(0, 36);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.SaddleBrown;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(327, 189);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(162, 31);
            this.gameOverLabel.TabIndex = 1;
            this.gameOverLabel.Text = "Game Over";
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCanvas.BackgroundImage")));
            this.pictureBoxCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCanvas.InitialImage = null;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCanvas.MaximumSize = new System.Drawing.Size(800, 400);
            this.pictureBoxCanvas.MinimumSize = new System.Drawing.Size(800, 400);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(800, 400);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            // 
            // topStrip
            // 
            this.topStrip.AutoSize = false;
            this.topStrip.BackColor = System.Drawing.Color.SaddleBrown;
            this.topStrip.CanOverflow = false;
            this.topStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.topStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.topStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.topStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.topStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameButton,
            this.toolStripSeparator1,
            this.rulesButton,
            this.toolStripSeparator2,
            this.snaakerLabel,
            this.subTitleLabel,
            this.toolStripSeparator3,
            this.fixedLabel1,
            this.scoreLabel,
            this.toolStripSeparator4,
            this.exitButton});
            this.topStrip.Location = new System.Drawing.Point(0, 0);
            this.topStrip.MaximumSize = new System.Drawing.Size(800, 36);
            this.topStrip.MinimumSize = new System.Drawing.Size(800, 36);
            this.topStrip.Name = "topStrip";
            this.topStrip.Size = new System.Drawing.Size(800, 36);
            this.topStrip.Stretch = true;
            this.topStrip.TabIndex = 0;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Transparent;
            this.startGameButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.startGameButton.Image = ((System.Drawing.Image)(resources.GetObject("startGameButton.Image")));
            this.startGameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(97, 33);
            this.startGameButton.Text = "Play Game";
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // rulesButton
            // 
            this.rulesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rulesButton.Image = ((System.Drawing.Image)(resources.GetObject("rulesButton.Image")));
            this.rulesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(36, 33);
            this.rulesButton.Text = "toolStripButton1";
            this.rulesButton.ToolTipText = "View The Game Rules";
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // snaakerLabel
            // 
            this.snaakerLabel.BackColor = System.Drawing.Color.Transparent;
            this.snaakerLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.snaakerLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.snaakerLabel.Font = new System.Drawing.Font("Candara", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snaakerLabel.Image = ((System.Drawing.Image)(resources.GetObject("snaakerLabel.Image")));
            this.snaakerLabel.Name = "snaakerLabel";
            this.snaakerLabel.Size = new System.Drawing.Size(161, 33);
            this.snaakerLabel.Text = "Snaaker 147 ";
            this.snaakerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTitleLabel.Font = new System.Drawing.Font("Candara", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(201, 33);
            this.subTitleLabel.Text = "The ultimate game of Snakes and Balls";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // fixedLabel1
            // 
            this.fixedLabel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.fixedLabel1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixedLabel1.Name = "fixedLabel1";
            this.fixedLabel1.Size = new System.Drawing.Size(89, 33);
            this.fixedLabel1.Text = "Current Break:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.scoreLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(26, 33);
            this.scoreLabel.Text = "0";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 33);
            this.exitButton.Text = "Exit Game";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Snaaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 436);
            this.Name = "Snaaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snaaker";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Snaaker_KeyUp);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.topStrip.ResumeLayout(false);
            this.topStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.ToolStrip topStrip;
        private System.Windows.Forms.ToolStripLabel fixedLabel1;
        private System.Windows.Forms.ToolStripLabel scoreLabel;
        private System.Windows.Forms.ToolStripButton startGameButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel snaakerLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.ToolStripLabel subTitleLabel;
        private System.Windows.Forms.ToolStripButton rulesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

