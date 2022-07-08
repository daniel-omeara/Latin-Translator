namespace Latin_Translator
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
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonMiddle = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(12, 93);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "Sinister";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonMiddle
            // 
            this.buttonMiddle.Location = new System.Drawing.Point(171, 93);
            this.buttonMiddle.Name = "buttonMiddle";
            this.buttonMiddle.Size = new System.Drawing.Size(75, 23);
            this.buttonMiddle.TabIndex = 1;
            this.buttonMiddle.Text = "Medium";
            this.buttonMiddle.UseVisualStyleBackColor = true;
            this.buttonMiddle.Click += new System.EventHandler(this.buttonMiddle_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(340, 93);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = "Dexter";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(12, 9);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(403, 15);
            this.labelInstruction.TabIndex = 3;
            this.labelInstruction.Text = "Click on one of the latin buttons below to find out what they say in english.";
            // 
            // labelTranslation
            // 
            this.labelTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTranslation.Location = new System.Drawing.Point(12, 46);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(403, 23);
            this.labelTranslation.TabIndex = 4;
            this.labelTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 128);
            this.Controls.Add(this.labelTranslation);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonMiddle);
            this.Controls.Add(this.buttonLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLeft;
        private Button buttonMiddle;
        private Button buttonRight;
        private Label labelInstruction;
        private Label labelTranslation;
    }
}