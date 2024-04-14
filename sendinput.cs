using System;
using System.Runtime.InteropServices;

namespace WindowsHooks
{
    public class InputSimulator
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT
        {
            public uint type;
            public InputUnion U;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {
            [FieldOffset(0)]
            public MOUSEINPUT mi;
            [FieldOffset(0)]
            public KEYBDINPUT ki;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        public const uint INPUT_KEYBOARD = 1;
        public const uint KEYEVENTF_KEYDOWN = 0x0000;
        public const uint KEYEVENTF_KEYUP = 0x0002;

       // public const ushort VK_A = 0x41; // Virtual key code for 'A'

        public void KeyboardInput(ushort keycode)
        {
            SendKeyPress(keycode);
            SendKeyRelease(keycode);
        }
        public static void SendKeyPress(ushort keyCode)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0] = new INPUT();
            inputs[0].type = INPUT_KEYBOARD;
            inputs[0].U.ki = new KEYBDINPUT();
            inputs[0].U.ki.wVk = keyCode;

            SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        public static void SendKeyRelease(ushort keyCode)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0] = new INPUT();
            inputs[0].type = INPUT_KEYBOARD;
            inputs[0].U.ki = new KEYBDINPUT();
            inputs[0].U.ki.wVk = keyCode;
            inputs[0].U.ki.dwFlags = KEYEVENTF_KEYUP;

            SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
    }
}