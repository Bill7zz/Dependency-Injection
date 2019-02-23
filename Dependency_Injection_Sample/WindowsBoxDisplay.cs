using System.Windows.Forms;

namespace Dependency_Injection_Sample
{
    public class WindowsBoxDisplay : IDisplay
    {
        public void Show(string message)
        {
            MessageBox.Show(message, "Message Box");
        }
    }
}
