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
            this.SuspendLayout();
            // 
            // dayOutput
            // 
            this.dayOutput.AutoSize = true;
            this.dayOutput.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOutput.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.dayOutput.Location = new System.Drawing.Point(3, 47);
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
            this.currentDateOutput.Location = new System.Drawing.Point(4, 73);
            this.currentDateOutput.Name = "currentDateOutput";
            this.currentDateOutput.Size = new System.Drawing.Size(84, 18);
            this.currentDateOutput.TabIndex = 1;
            this.currentDateOutput.Text = "dd/mm/yyyy";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currentDateOutput);
            this.Controls.Add(this.dayOutput);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOutput;
        private System.Windows.Forms.Label currentDateOutput;
    }
}
