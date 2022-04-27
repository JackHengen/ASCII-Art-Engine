using ASCII_Art_Engine;
using System.Diagnostics;

namespace Winforms_UI
{
    public partial class Form1 : Form
    {
        IAnimation anim;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void NextFrameButton_Click(object sender, EventArgs e)
        {
            if(anim != null)
                ASCIIArtDisplayTextBox.Text = anim.NextFrame();
        }

        private void PreviousFrameButton_Click(object sender, EventArgs e)
        {
            if(anim != null)
                ASCIIArtDisplayTextBox.Text = anim.PreviousFrame();
        }
        private void LoopButton_Click(object sender, EventArgs e)
        {
            if(anim !=null)
            {

            }
            //refactor Animation class so fps can be set in editor instead of from constructor
            //learn to better time check
        }
        private void LoadASCIIArtButton_Click(object sender, EventArgs e)
        {
            LoadAnimationForm loadAnimation = new LoadAnimationForm();
            loadAnimation.ShowDialog();
            
            if(loadAnimation.DialogResult == DialogResult.OK)
            {
                anim = loadAnimation.Animation;
                ASCIIArtDisplayTextBox.Text = anim.CurrentFrame();
            }

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf= new SettingsForm();
            sf.ShowDialog();
        }
    }
}