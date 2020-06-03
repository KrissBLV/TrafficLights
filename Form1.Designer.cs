namespace TrafficLights
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
            this.redBox = new System.Windows.Forms.PictureBox();
            this.yellowLight = new System.Windows.Forms.PictureBox();
            this.greenLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).BeginInit();
            this.SuspendLayout();
            // 
            // redBox
            // 
            this.redBox.Location = new System.Drawing.Point(48, 12);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(181, 175);
            this.redBox.TabIndex = 0;
            this.redBox.TabStop = false;
            // 
            // yellowLight
            // 
            this.yellowLight.Location = new System.Drawing.Point(48, 193);
            this.yellowLight.Name = "yellowLight";
            this.yellowLight.Size = new System.Drawing.Size(181, 175);
            this.yellowLight.TabIndex = 1;
            this.yellowLight.TabStop = false;
            // 
            // greenLight
            // 
            this.greenLight.Location = new System.Drawing.Point(48, 374);
            this.greenLight.Name = "greenLight";
            this.greenLight.Size = new System.Drawing.Size(181, 175);
            this.greenLight.TabIndex = 2;
            this.greenLight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 569);
            this.Controls.Add(this.greenLight);
            this.Controls.Add(this.yellowLight);
            this.Controls.Add(this.redBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redBox;
        private System.Windows.Forms.PictureBox yellowLight;
        private System.Windows.Forms.PictureBox greenLight;
    }
}

