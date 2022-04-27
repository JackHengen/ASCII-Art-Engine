using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art_Engine
{
    public class SingleFileAnimation : IAnimation
    {
        int height;
        string path;

        List<String> frames = new List<String>();
        public int frameIndex { get; private set; } = 0;
        public int totalframes { get; private set; } = 0;
        public SingleFileAnimation(string path, int height)
        {
            this.height = height;
            this.path = path;
            ParseAnimationFromFile();

        }
        private void ParseAnimationFromFile()
        {
            StreamReader sr = File.OpenText(path);
            while (sr.Peek() != -1)
            {
                string nextFrame = "";
                for (int i = 0; i < height; i++)
                {
                    if (sr.Peek() != -1)
                    {
                        nextFrame += sr.ReadLine();
                        nextFrame += Environment.NewLine;
                    }
                }
                frames.Add(nextFrame);
            }
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

