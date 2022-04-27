namespace ASCII_Art_Engine
{
    public interface IAnimation
    {
        int frameIndex { get; }
        int totalframes { get; }

        string CurrentFrame();
        string NextFrame();
        string PreviousFrame();
        void ResetAnimation();
    }
}