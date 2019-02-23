namespace Dependency_Injection_Sample
{
    public class DisplayMessage
    {
        public IDisplay Displayer { get; set; }

        public DisplayMessage() { }

        public DisplayMessage(IDisplay displayer)
        {
            this.Displayer = displayer;
        }
        
        public void Show(string message)
        {
            if (Displayer != null)
            {
                Displayer.Show(message);
            }

        }
    }
}
