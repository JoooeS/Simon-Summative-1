namespace Summative_1
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMessage.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.LightGray;
            this.labelMessage.Location = new System.Drawing.Point(4, 4);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(593, 74);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "This is where to put: COMPUTER TURN or PLAYER TURN";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelG
            // 
            this.labelG.BackColor = System.Drawing.Color.Green;
            this.labelG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelG.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelG.Location = new System.Drawing.Point(310, 90);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(100, 100);
            this.labelG.TabIndex = 5;
            this.labelG.Click += new System.EventHandler(this.labelG_Click);
            // 
            // labelB
            // 
            this.labelB.BackColor = System.Drawing.Color.Blue;
            this.labelB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelB.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelB.Location = new System.Drawing.Point(310, 210);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(100, 100);
            this.labelB.TabIndex = 6;
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // labelR
            // 
            this.labelR.BackColor = System.Drawing.Color.Red;
            this.labelR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelR.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelR.Location = new System.Drawing.Point(190, 210);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(100, 100);
            this.labelR.TabIndex = 7;
            this.labelR.Click += new System.EventHandler(this.labelR_Click);
            // 
            // labelY
            // 
            this.labelY.BackColor = System.Drawing.Color.Yellow;
            this.labelY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelY.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelY.Location = new System.Drawing.Point(190, 90);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(100, 100);
            this.labelY.TabIndex = 8;
            this.labelY.Click += new System.EventHandler(this.labelY_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Summative_1.Properties.Resources.SpaceScreenBKG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelMessage);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelY;
    }
}
