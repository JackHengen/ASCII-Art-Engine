namespace Winforms_UI
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
            this.NextFrameButton = new System.Windows.Forms.Button();
            this.PreviousFrameButton = new System.Windows.Forms.Button();
            this.LoopButton = new System.Windows.Forms.Button();
            this.LoadASCIIArtButton = new System.Windows.Forms.Button();
            this.ASCIIArtDisplayTextBox = new System.Windows.Forms.TextBox();
            this.FPSTextBox = new System.Windows.Forms.TextBox();
            this.FPSLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextFrameButton
            // 
            this.NextFrameButton.Location = new System.Drawing.Point(216, 345);
            this.NextFrameButton.Name = "NextFrameButton";
            this.NextFrameButton.Size = new System.Drawing.Size(112, 34);
            this.NextFrameButton.TabIndex = 0;
            this.NextFrameButton.Text = "Next";
            this.NextFrameButton.UseVisualStyleBackColor = true;
            this.NextFrameButton.Click += new System.EventHandler(this.NextFrameButton_Click);
            // 
            // PreviousFrameButton
            // 
            this.PreviousFrameButton.Location = new System.Drawing.Point(98, 345);
            this.PreviousFrameButton.Name = "PreviousFrameButton";
            this.PreviousFrameButton.Size = new System.Drawing.Size(112, 34);
            this.PreviousFrameButton.TabIndex = 1;
            this.PreviousFrameButton.Text = "Previous";
            this.PreviousFrameButton.UseVisualStyleBackColor = true;
            this.PreviousFrameButton.Click += new System.EventHandler(this.PreviousFrameButton_Click);
            // 
            // LoopButton
            // 
            this.LoopButton.Location = new System.Drawing.Point(216, 382);
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.Size = new System.Drawing.Size(112, 34);
            this.LoopButton.TabIndex = 3;
            this.LoopButton.Text = "Loop";
            this.LoopButton.UseVisualStyleBackColor = true;
            this.LoopButton.Click += new System.EventHandler(this.LoopButton_Click);
            // 
            // LoadASCIIArtButton
            // 
            this.LoadASCIIArtButton.Location = new System.Drawing.Point(556, 345);
            this.LoadASCIIArtButton.Name = "LoadASCIIArtButton";
            this.LoadASCIIArtButton.Size = new System.Drawing.Size(112, 34);
            this.LoadASCIIArtButton.TabIndex = 5;
            this.LoadASCIIArtButton.Text = "Load";
            this.LoadASCIIArtButton.UseVisualStyleBackColor = true;
            this.LoadASCIIArtButton.Click += new System.EventHandler(this.LoadASCIIArtButton_Click);
            // 
            // ASCIIArtDisplayTextBox
            // 
            this.ASCIIArtDisplayTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ASCIIArtDisplayTextBox.Location = new System.Drawing.Point(98, 31);
            this.ASCIIArtDisplayTextBox.Multiline = true;
            this.ASCIIArtDisplayTextBox.Name = "ASCIIArtDisplayTextBox";
            this.ASCIIArtDisplayTextBox.Size = new System.Drawing.Size(570, 279);
            this.ASCIIArtDisplayTextBox.TabIndex = 6;
            this.ASCIIArtDisplayTextBox.Text = "No Design Loaded";
            // 
            // FPSTextBox
            // 
            this.FPSTextBox.Location = new System.Drawing.Point(145, 385);
            this.FPSTextBox.Name = "FPSTextBox";
            this.FPSTextBox.Size = new System.Drawing.Size(65, 31);
            this.FPSTextBox.TabIndex = 7;
            // 
            // FPSLabel
            // 
            this.FPSLabel.AutoSize = true;
            this.FPSLabel.Location = new System.Drawing.Point(98, 382);
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(50, 25);
            this.FPSLabel.TabIndex = 8;
            this.FPSLabel.Text = "FPS: ";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(556, 385);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(112, 34);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.FPSLabel);
            this.Controls.Add(this.FPSTextBox);
            this.Controls.Add(this.ASCIIArtDisplayTextBox);
            this.Controls.Add(this.LoadASCIIArtButton);
            this.Controls.Add(this.LoopButton);
            this.Controls.Add(this.PreviousFrameButton);
            this.Controls.Add(this.NextFrameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NextFrameButton;
        private Button PreviousFrameButton;
        private Button LoopButton;
        private Button LoadASCIIArtButton;
        private TextBox ASCIIArtDisplayTextBox;
        private TextBox FPSTextBox;
        private Label FPSLabel;
        private Button SettingsButton;
    }
}