namespace Winforms_UI
{
    partial class SettingsForm
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
            this.BackgroundColorComboBox = new System.Windows.Forms.ComboBox();
            this.ForegroundColorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackgroundColorComboBox
            // 
            this.BackgroundColorComboBox.FormattingEnabled = true;
            this.BackgroundColorComboBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Cyan",
            "Dark Blue",
            "Dark Cyan\t",
            "Dark Gray",
            "Dark Green",
            "Dark Magenta\t",
            "Dark Red",
            "Dark Yellow",
            "Gray",
            "Green\t",
            "Magenta\t",
            "Red\t",
            "White\t",
            "Yellow\t"});
            this.BackgroundColorComboBox.Location = new System.Drawing.Point(206, 84);
            this.BackgroundColorComboBox.Name = "BackgroundColorComboBox";
            this.BackgroundColorComboBox.Size = new System.Drawing.Size(219, 33);
            this.BackgroundColorComboBox.TabIndex = 0;
            // 
            // ForegroundColorComboBox
            // 
            this.ForegroundColorComboBox.FormattingEnabled = true;
            this.ForegroundColorComboBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Cyan",
            "Dark Blue",
            "Dark Cyan\t",
            "Dark Gray",
            "Dark Green",
            "Dark Magenta\t",
            "Dark Red",
            "Dark Yellow",
            "Gray",
            "Green\t",
            "Magenta\t",
            "Red\t",
            "White\t",
            "Yellow\t"});
            this.ForegroundColorComboBox.Location = new System.Drawing.Point(206, 125);
            this.ForegroundColorComboBox.Name = "ForegroundColorComboBox";
            this.ForegroundColorComboBox.Size = new System.Drawing.Size(219, 33);
            this.ForegroundColorComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Background Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Foreground Color";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(344, 341);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(112, 34);
            this.SaveSettingsButton.TabIndex = 4;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ForegroundColorComboBox);
            this.Controls.Add(this.BackgroundColorComboBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox BackgroundColorComboBox;
        private ComboBox ForegroundColorComboBox;
        private Label label1;
        private Label label2;
        private Button SaveSettingsButton;
    }
}