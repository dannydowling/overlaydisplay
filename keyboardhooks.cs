using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsHooks
{
    public class KeyboardHooks
    {
        // Define the delegate for the hook procedure.
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        // Import the necessary Windows API functions.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        // Define the hook type and ID.
        private const int WH_KEYBOARD_LL = 13;

        // Store the hook handle for later unhooking.
        private static IntPtr _hookID = IntPtr.Zero;

        public KeyboardHookExample()
        {
            // Install the keyboard hook.
            _hookID = SetHook(KeyboardHookCallback);

            // Run your application logic here.

            // Unhook the keyboard hook when done.
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            // Handle the keyboard event here.
            // The lParam parameter contains information about the event.

            // Call the next hook in the chain.
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        // Other necessary methods and definitions can go here.
    }

}