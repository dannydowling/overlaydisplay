using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsHooks
{
    public class MouseHooks
    {
        // Define the delegate for the hook procedure.
        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        // Import the necessary Windows API functions.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookMouseHook(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        // Define the hook type and ID.
        private const int WH_MOUSE_LL = 14;

        // Define mouse event types.
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;
        private const int WM_RBUTTONDOWN = 0x0204;
        private const int WM_RBUTTONUP = 0x0205;
        private const int WM_MBUTTONDOWN = 0x0207;
        private const int WM_MBUTTONUP = 0x0208;

        // Store the hook handle for later unhooking.
        private static IntPtr _hookID = IntPtr.Zero;

        public MouseHookExample()
        {
            // Install the mouse hook.
            _hookID = SetHook(MouseHookCallback);

            // Run your application logic here.

            // Unhook the mouse hook when done.
            UnhookMouseHook(_hookID);
        }

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            // Check if the hook should process the message.
            if (nCode >= 0)
            {
                // Extract the mouse event information from the lParam parameter.
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));

                // Check the message type.
                switch ((int)wParam)
                {
                    case WM_MOUSEMOVE:
                        // Mouse moved.
                        Console.WriteLine("Mouse moved: X={0}, Y={1}", hookStruct.pt.x, hookStruct.pt.y);
                        break;
                    case WM_LBUTTONDOWN:
                        // Left mouse button down.
                        Console.WriteLine("Left mouse button down");
                        break;
                    case WM_LBUTTONUP:
                        // Left mouse button up.
                        Console.WriteLine("Left mouse button up");
                        break;
                        // Add cases for other mouse events as needed.
                }
            }

            // Call the next hook in the chain.
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        // Define the structure for mouse event information.
        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        // Other necessary methods and definitions can go here.
    }
}
