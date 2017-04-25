namespace XMLWeather
{
    partial class MainScreen
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
            this.dayOutput = new System.Windows.Forms.Label();
            this.currentDateOutput = new System.Windows.Forms.Label();
            this.currentConditionPicture = new System.Windows.Forms.PictureBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.currentConditionText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentConditionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dayOutput
            // 
            this.dayOutput.AutoSize = true;
            this.dayOutput.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOutput.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.dayOutput.Location = new System.Drawing.Point(3, 18);
            this.dayOutput.Name = "dayOutput";
            this.dayOutput.Size = new System.Drawing.Size(74, 23);
            this.dayOutput.TabIndex = 0;
            this.dayOutput.Text = "Someday";
            // 
            // currentDateOutput
            // 
            this.currentDateOutput.AutoSize = true;
            this.currentDateOutput.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateOutput.ForeColor = System.Drawing.Color.Black;
            this.currentDateOutput.Location = new System.Drawing.Point(4, 44);
            this.currentDateOutput.Name = "currentDateOutput";
            this.currentDateOutput.Size = new System.Drawing.Size(84, 18);
            this.currentDateOutput.TabIndex = 1;
            this.currentDateOutput.Text = "dd/mm/yyyy";
            // 
            // currentConditionPicture
            // 
            this.currentConditionPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.currentConditionPicture.Location = new System.Drawing.Point(50, 105);
            this.currentConditionPicture.Name = "currentConditionPicture";
            this.currentConditionPicture.Size = new System.Drawing.Size(150, 92);
            this.currentConditionPicture.TabIndex = 2;
            this.currentConditionPicture.TabStop = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(63, 69);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(125, 33);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Stratford";
            // 
            // currentConditionText
            // 
            this.currentConditionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentConditionText.ForeColor = System.Drawing.Color.DimGray;
            this.currentConditionText.Location = new System.Drawing.Point(3, 200);
            this.currentConditionText.Name = "currentConditionText";
            this.currentConditionText.Size = new System.Drawing.Size(244, 23);
            this.currentConditionText.TabIndex = 4;
            this.currentConditionText.Text = "label1";
            this.currentConditionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.currentConditionText);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.currentConditionPicture);
            this.Controls.Add(this.currentDateOutput);
            this.Controls.Add(this.dayOutput);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(250, 400);
            ((System.ComponentModel.ISupportInitialize)(this.currentConditionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOutput;
        private System.Windows.Forms.Label currentDateOutput;
        private System.Windows.Forms.PictureBox currentConditionPicture;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label currentConditionText;
    }
}
