using ASCII_Art_Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_UI
{
    public partial class LoadAnimationForm : Form
    {
        public IAnimation Animation { get; private set; }
        List<string> paths = new List<string>();

        public LoadAnimationForm()
        {
            InitializeComponent();
        }

        private void BrowseAnimationButton_Click(object sender, EventArgs e)
        {
            paths = new List<string>();
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Text Files|*.txt";
            ofp.Multiselect = true;

            if (ofp.ShowDialog() == DialogResult.OK)
            {
                foreach(string s in ofp.FileNames)
                {
                    paths.Add(s);
                    PathLabel.Text += s + " | ";
                }
            }
            if(paths.Count ==1)
            {
                HeightTextBox.Enabled = true;
                HeightLabel.Enabled = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(paths.Count >0)
            {
                if(paths.Count >1)
                {
                    Animation = new MultiFileAnimation(paths);
                    DialogResult = DialogResult.OK;
                }
                else if(int.TryParse(HeightTextBox.Text, out int height))
                {
                    Animation = new SingleFileAnimation(paths[0], height);
                    DialogResult = DialogResult.OK;
                }                
            }
            //maybe this method and previous method should be part of the library since a lot of logic is tied to the UI rn
            //method that takes varying # of pths and return  correct type of animation, it can be a static animation class 
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
