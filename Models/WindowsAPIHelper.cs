using System.Runtime.InteropServices;

namespace Genshin_Lyre_Midi_Tool.Models
{
    public static class WindowsAPIHelper
    {
        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
    }
}
