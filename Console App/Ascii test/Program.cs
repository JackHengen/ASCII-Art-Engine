
/*To DO
 * Add a way to specify fps, and height from a file
 * maybe a line of * or # represent the end of frames and a tag [ASCII ART] at the beggining makes it import using these conditions
 */
Animation blink = new Animation(@"C:\Users\jackh\Desktop\Art\ASCII\Blinking Face.txt", 11, 3);
while(true)
{
    blink.DrawNextFrame();
}

//Add in looping
public class Animation
{
    string path;
    int height;
    int fps;
    DateTime nextFrameAllowed;
    StreamReader sr;
    public Animation(string path, int height, int fps)
    {
        this.fps = fps;
        this.height = height;
        this.path = path;
        this.sr =File.OpenText(path);
        nextFrameAllowed = DateTime.Now;
    }
    public void DrawNextFrame()
    {
        if(sr.Peek()==-1)
        {
            sr=File.OpenText(path);
        }
        if (DateTime.Now > nextFrameAllowed)
        {
            Console.Clear();
            for (int i = 0; i < height; i++)
            {
                if (sr.Peek() != -1)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            nextFrameAllowed = DateTime.Now.AddTicks(10000000/fps);
        }
    }
    public void Animate()
    {
        sr.Close();
        sr=File.OpenText(path);
        while(sr.Peek()!=-1)
        {
            if(DateTime.Now > nextFrameAllowed)
            {
                Console.Clear();
                for (int i = 0; i < height; i++)
                {
                    if (sr.Peek() != -1)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
                nextFrameAllowed = DateTime.Now.AddTicks(10000000 / fps);
            }
        }
    }
    public void LoopAnimation()
    {
        while (true)
        {
            if (sr.Peek() != -1)
            {
                DrawNextFrame();
            }
            else
            {
                sr.Close();
                sr = File.OpenText(path);
            }
        }
    }
}
//public class ASCIIAnimation
//{

//}
//public interface IAnimation
//{
//    void DrawFrame();
//}
public class ASCIILoader
{
    //OpenFileDialog fdlg = new OpenFileDialog();
}
