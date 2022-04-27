namespace Winforms_UI
{
    partial class LoadAnimationForm
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
            this.BrowseAnimationButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrowseAnimationButton
            // 
            this.BrowseAnimationButton.Location = new System.Drawing.Point(317, 63);
            this.BrowseAnimationButton.Name = "BrowseAnimationButton";
            this.BrowseAnimationButton.Size = new System.Drawing.Size(166, 34);
            this.BrowseAnimationButton.TabIndex = 0;
            this.BrowseAnimationButton.Text = "Browse Animation";
            this.BrowseAnimationButton.UseVisualStyleBackColor = true;
            this.BrowseAnimationButton.Click += new System.EventHandler(this.BrowseAnimationButton_Click);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Enabled = false;
            this.HeightTextBox.Location = new System.Drawing.Point(366, 151);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(117, 31);
            this.HeightTextBox.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(403, 269);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(112, 34);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Enabled = false;
            this.HeightLabel.Location = new System.Drawing.Point(237, 157);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(123, 25);
            this.HeightLabel.TabIndex = 5;
            this.HeightLabel.Text = "Frame Height:";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(237, 108);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(73, 25);
            this.PathLabel.TabIndex = 7;
            this.PathLabel.Text = "Path(s): ";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(285, 269);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(112, 34);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoadAnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.BrowseAnimationButton);
            this.Name = "LoadAnimationForm";
            this.Text = "LoadAnimation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BrowseAnimationButton;
        private TextBox HeightTextBox;
        private Button SubmitButton;
        private Label HeightLabel;
        private Label PathLabel;
        private Button CancelButton;
    }
}