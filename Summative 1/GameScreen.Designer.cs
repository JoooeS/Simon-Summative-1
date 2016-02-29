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
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonY
            // 
            this.buttonY.BackColor = System.Drawing.Color.Yellow;
            this.buttonY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonY.Location = new System.Drawing.Point(190, 90);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(100, 100);
            this.buttonY.TabIndex = 0;
            this.buttonY.UseVisualStyleBackColor = false;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonG
            // 
            this.buttonG.BackColor = System.Drawing.Color.Lime;
            this.buttonG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonG.Location = new System.Drawing.Point(310, 90);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(100, 100);
            this.buttonG.TabIndex = 1;
            this.buttonG.UseVisualStyleBackColor = false;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.Red;
            this.buttonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonR.Location = new System.Drawing.Point(190, 210);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(100, 100);
            this.buttonR.TabIndex = 2;
            this.buttonR.UseVisualStyleBackColor = false;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Location = new System.Drawing.Point(310, 210);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(100, 100);
            this.buttonB.TabIndex = 3;
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
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
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Summative_1.Properties.Resources.SpaceScreenBKG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonY);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Label labelMessage;
    }
}
