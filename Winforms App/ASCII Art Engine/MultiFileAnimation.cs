using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art_Engine
{
    public class MultiFileAnimation : IAnimation
    {

        List<String> frames = new List<String>();
        public int frameIndex { get; private set; } = 0;
        public int totalframes { get; private set; } = 0;
        public MultiFileAnimation(List<string> filePaths)
        {
            foreach (string path in filePaths)
            {
                ParseFrameFromFile(path);
            }
        }
        private void ParseFrameFromFile(string path)
        {
            StreamReader sr = File.OpenText(path);
            string s = "";
            while (sr.Peek() != -1)
            {
                s+= sr.ReadLine() +Environment.NewLine;
                
            }
            frames.Add(s);
            sr.Close();
        }

        public string NextFrame()
        {
            if (frameIndex == frames.Count - 1)
            {
                ResetAnimation();
                return frames[frameIndex];
            }
            else
            {
                frameIndex++;
                return frames[frameIndex];
            }
        }
        public string CurrentFrame()
        {
            return frames[frameIndex];
        }
        public string PreviousFrame()
        {
            if (frameIndex == 0)
            {
                frameIndex = frames.Count - 1;
                return frames[frameIndex];
            }
            else
            {
                frameIndex--;
                return frames[frameIndex];
            }
        }
        public void ResetAnimation()
        {
            frameIndex = 0;
        }
    }
}
