namespace WindowsHooks
{
    internal class Keycodes
    {
        public ushort convertKeycode(string key)
        {
            ushort returnInfo = new ushort();

            switch (key)
            {
                case "VK_LBUTTON": // left mouse button
                    returnInfo = 0x01;
                    break;

                case "VK_RBUTTON": // right mouse button
                    returnInfo = 0x02;
                    break;

                case "VK_CANCEL": // control break processing
                    returnInfo = 0x03;
                    break;

                case "VK_MBUTTON": // middle mouse button
                    returnInfo = 0x04;
                    break;

                case "VK_XBUTTON1": // x1 mouse button
                    returnInfo = 0x05;
                    break;

                case "VK_XBUTTON2": // x2 mouse button
                    returnInfo = 0x06;
                    break;

                case "VK_BACK": // backspace key
                    returnInfo = 0x08;
                    break;

                case "VK_TAB": // Tab key
                    returnInfo = 0x09;
                    break;

                case "VK_CLEAR": // Clear Key
                    returnInfo = 0x0C;
                    break;

                case "VK_RETURN": // Enter Key
                    returnInfo = 0x0D;
                    break;

                case "VK_SHIFT": // Shift Key
                    returnInfo = 0x10;
                    break;

                case "VK_CONTROL": // ctrl key
                    returnInfo = 0x11;
                    break;

                case "VK_MENU": // Alt key
                    returnInfo = 0x12;
                    break;

                case "VK_PAUSE": // pause key
                    returnInfo = 0x13;
                    break;

                case "VK_CAPITAL": // caps lock key
                    returnInfo = 0x14;
                    break;

                case "VK_KANA": // IME Kana Mode
                    returnInfo = 0x15;
                    break;

                case "VK_HANGUL": // IME Hangul Mode
                    returnInfo = 0x15;
                    break;

                case "VK_IME_ON": // IME On
                    returnInfo = 0x16;
                    break;

                case "VK_JUNJA": // IME Junja Mode
                    returnInfo = 0x17;
                    break;

                case "VK_FINAL": // IME Final Mode
                    returnInfo = 0x18;
                    break;

                case "VK_HANJA": // IME Hanja Mode
                    returnInfo = 0x19;
                    break;

                case "VK_KANJI": // IME Kanji Mode
                    returnInfo = 0x19;
                    break;

                case "VK_IME_OFF": // IME off
                    returnInfo = 0x1A;
                    break;

                case "VK_ESCAPE": // ESC Key
                    returnInfo = 0x1B;
                    break;

                case "VK_CONVERT": // IME Convert
                    returnInfo = 0x1C;
                    break;

                case "VK_NONCONVERT": // IME nonconvert
                    returnInfo = 0x1D;
                    break;

                case "VK_ACCEPT": // IME accept
                    returnInfo = 0x1E;
                    break;

                case "VK_MODECHANGE": // IME Mode Change Request
                    returnInfo = 0x1F;
                    break;

                case "VK_SPACE": // spacebar
                    returnInfo = 0x20;
                    break;

                case "VK_PRIOR": // page up key
                    returnInfo = 0x21;
                    break;

                case "VK_NEXT": // page down key
                    returnInfo = 0x22;
                    break;

                case "VK_END": // end key
                    returnInfo = 0x23;
                    break;

                case "VK_HOME": // home key
                    returnInfo = 0x24;
                    break;

                case "VK_LEFT": // left arrow
                    returnInfo = 0x25;
                    break;

                case "VK_UP": // up arrow
                    returnInfo = 0x26;
                    break;

                case "VK_RIGHT": // right arrow
                    returnInfo = 0x27;
                    break;

                case "VK_DOWN": // down arrow
                    returnInfo = 0x28;
                    break;

                case "VK_SELECT": // select key
                    returnInfo = 0x29;
                    break;

                case "VK_PRINT": // print key
                    returnInfo = 0x2A;
                    break;

                case "VK_EXECUTE": // execute key
                    returnInfo = 0x2B;
                    break;

                case "VK_SNAPSHOT": // print screen key
                    returnInfo = 0x2C;
                    break;

                case "VK_INSERT": // ins key
                    returnInfo = 0x2D;
                    break;

                case "VK_DELETE": // del key
                    returnInfo = 0x2E;
                    break;

                case "VK_HELP": // help key
                    returnInfo = 0x2F;
                    break;

                case "0": // 0 key
                    returnInfo = 0x30;
                    break;

                case "1": // 1 key
                    returnInfo = 0x31;
                    break;

                case "2": // 2 key
                    returnInfo = 0x32;
                    break;

                case "3": // 3 key
                    returnInfo = 0x33;
                    break;

                case "4": // 4 key
                    returnInfo = 0x34;
                    break;

                case "5": // 5 key
                    returnInfo = 0x35;
                    break;

                case "6": // 6 key
                    returnInfo = 0x36;
                    break;

                case "7": // 7 key
                    returnInfo = 0x37;
                    break;

                case "8": // 8 key
                    returnInfo = 0x38;
                    break;

                case "9": // 9 key
                    returnInfo = 0x39;
                    break;

                case "A": // A key
                    returnInfo = 0x41;
                    break;

                case "B": // B key
                    returnInfo = 0x42;
                    break;

                case "C": // C key
                    returnInfo = 0x43;
                    break;

                case "D": // D key
                    returnInfo = 0x44;
                    break;

                case "E": // E key
                    returnInfo = 0x45;
                    break;

                case "F": // F key
                    returnInfo = 0x46;
                    break;

                case "G": // G key
                    returnInfo = 0x47;
                    break;

                case "H": // H key
                    returnInfo = 0x48;
                    break;

                case "I": // I key
                    returnInfo = 0x49;
                    break;

                case "J": // J key
                    returnInfo = 0x4A;
                    break;

                case "K": // K key
                    returnInfo = 0x4B;
                    break;

                case "L": // L key
                    returnInfo = 0x4C;
                    break;

                case "M": // M key
                    returnInfo = 0x4D;
                    break;

                case "N": // N key
                    returnInfo = 0x4E;
                    break;

                case "O": // O key
                    returnInfo = 0x4F;
                    break;

                case "P": // P key
                    returnInfo = 0x50;
                    break;

                case "Q": // Q key
                    returnInfo = 0x51;
                    break;

                case "R": // R key
                    returnInfo = 0x52;
                    break;

                case "S": // S key
                    returnInfo = 0x53;
                    break;

                case "T": // T key
                    returnInfo = 0x54;
                    break;

                case "U": // U key
                    returnInfo = 0x55;
                    break;

                case "V": // V key
                    returnInfo = 0x56;
                    break;

                case "W": // W key
                    returnInfo = 0x57;
                    break;

                case "X": // X key
                    returnInfo = 0x58;
                    break;

                case "Y": // Y key
                    returnInfo = 0x59;
                    break;

                case "Z": // Z key
                    returnInfo = 0x5A;
                    break;

                case "VK_LWIN": // left windows key
                    returnInfo = 0x5B;
                    break;

                case "VK_RWIN": // right windows key
                    returnInfo = 0x5C;
                    break;

                case "VK_APPS": // applications key
                    returnInfo = 0x5D;
                    break;

                case "VK_SLEEP": // sleep key
                    returnInfo = 0x5F;
                    break;

                case "VK_NUMPAD0": // numeric keypad 0 key
                    returnInfo = 0x60;
                    break;

                case "VK_NUMPAD1": // numeric keypad 1 key
                    returnInfo = 0x61;
                    break;

                case "VK_NUMPAD2": // numeric keypad 2 key
                    returnInfo = 0x62;
                    break;

                case "VK_NUMPAD3": // numeric keypad 3 key
                    returnInfo = 0x63;
                    break;

                case "VK_NUMPAD4": // numeric keypad 4 key
                    returnInfo = 0x64;
                    break;

                case "VK_NUMPAD5": // numeric keypad 5 key
                    returnInfo = 0x65;
                    break;

                case "VK_NUMPAD6": // numeric keypad 6 key
                    returnInfo = 0x66;
                    break;

                case "VK_NUMPAD7": // numeric keypad 7 key
                    returnInfo = 0x67;
                    break;

                case "VK_NUMPAD8": // numeric keypad 8 key
                    returnInfo = 0x68;
                    break;

                case "VK_NUMPAD9": // numeric keypad 9 key
                    returnInfo = 0x69;
                    break;

                case "VK_MULTIPLY": // multiply key
                    returnInfo = 0x6A;
                    break;

                case "VK_ADD": // add key
                    returnInfo = 0x6B;
                    break;

                case "VK_SEPARATOR": // separator key
                    returnInfo = 0x6C;
                    break;

                case "VK_SUBTRACT": // subtact key
                    returnInfo = 0x6D;
                    break;

                case "VK_DECIMAL": // decimal key
                    returnInfo = 0x6E;
                    break;

                case "VK_DIVIDE": // divide key
                    returnInfo = 0x6F;
                    break;

                case "VK_F1": // F1 key
                    returnInfo = 0x70;
                    break;

                case "VK_F2": // F2 key
                    returnInfo = 0x71;
                    break;

                case "VK_F3": // F3 key
                    returnInfo = 0x72;
                    break;

                case "VK_F4": // F4 key
                    returnInfo = 0x73;
                    break;

                case "VK_F5": // F5 key
                    returnInfo = 0x74;
                    break;

                case "VK_F6": // F6 key
                    returnInfo = 0x75;
                    break;

                case "VK_F7": // F7 key
                    returnInfo = 0x76;
                    break;

                case "VK_F8": // F8 key
                    returnInfo = 0x77;
                    break;

                case "VK_F9": // F9 key
                    returnInfo = 0x78;
                    break;

                case "VK_F10": // F10 key
                    returnInfo = 0x79;
                    break;

                case "VK_F11": // F11 key
                    returnInfo = 0x7A;
                    break;

                case "VK_F12": // F12 key
                    returnInfo = 0x7B;
                    break;

                case "VK_F13": // F13 key
                    returnInfo = 0x7C;
                    break;

                case "VK_F14": // F14 key
                    returnInfo = 0x7D;
                    break;

                case "VK_F15": // F15 key
                    returnInfo = 0x7E;
                    break;

                case "VK_F16": // F16 key
                    returnInfo = 0x7F;
                    break;

                case "VK_F17": // F17 key
                    returnInfo = 0x80;
                    break;

                case "VK_F18": // F18 key
                    returnInfo = 0x81;
                    break;

                case "VK_F19": // F19 key
                    returnInfo = 0x82;
                    break;

                case "VK_F20": // F20 key
                    returnInfo = 0x83;
                    break;

                case "VK_F21": // F21 key
                    returnInfo = 0x84;
                    break;

                case "VK_F22": // F22 key
                    returnInfo = 0x85;
                    break;

                case "VK_F23": // F23 key
                    returnInfo = 0x86;
                    break;

                case "VK_F24": // F24 key
                    returnInfo = 0x87;
                    break;

                case "VK_NUMLOCK": // num lock key
                    returnInfo = 0x90;
                    break;

                case "VK_SCROLL": // scroll lock key
                    returnInfo = 0x91;
                    break;

                // 0x92-96	OEM specific

                case "VK_LSHIFT": // left shift key
                    returnInfo = 0xA0;
                    break;

                case "VK_RSHIFT": // right shift key
                    returnInfo = 0xA1;
                    break;

                case "VK_LCONTROL": // left ctrl key
                    returnInfo = 0xA2;
                    break;

                case "VK_RCONTROL": // right ctrl key
                    returnInfo = 0xA3;
                    break;

                case "VK_LMENU": // left alt key
                    returnInfo = 0xA4;
                    break;

                case "VK_RMENU": // right alt key
                    returnInfo = 0xA5;
                    break;

                case "VK_BROWSER_BACK": // browser back key
                    returnInfo = 0xA6;
                    break;

                case "VK_BROWSER_FORWARD": // browser forward key
                    returnInfo = 0xA7;
                    break;

                case "VK_BROWSER_REFRESH": // browser refresh key
                    returnInfo = 0xA8;
                    break;

                case "VK_BROWSER_STOP": // browser stop key
                    returnInfo = 0xA9;
                    break;

                case "VK_BROWSER_SEARCH": // browser search key
                    returnInfo = 0xAA;
                    break;

                case "VK_BROWSER_FAVORITES": // browser favorites key
                    returnInfo = 0xAB;
                    break;

                case "VK_BROWSER_HOME": // browser start and home key
                    returnInfo = 0xAC;
                    break;

                case "VK_VOLUME_MUTE": // volume mute key
                    returnInfo = 0xAD;
                    break;

                case "VK_VOLUME_DOWN": // volume down key
                    returnInfo = 0xAE;
                    break;

                case "VK_VOLUME_UP": // volume up key
                    returnInfo = 0xAF;
                    break;

                case "VK_MEDIA_NEXT_TRACK": // next track key
                    returnInfo = 0xB0;
                    break;

                case "VK_MEDIA_PREV_TRACK": // prev track key
                    returnInfo = 0xB1;
                    break;

                case "VK_MEDIA_STOP": // stop media key
                    returnInfo = 0xB2;
                    break;

                case "VK_MEDIA_PLAY_PAUSE": // play pause key
                    returnInfo = 0xB0;
                    break;

                case "VK_LAUNCH_MAIL": // start mail key
                    returnInfo = 0xB4;
                    break;

                case "VK_LAUNCH_MEDIA_SELECT": // select media key
                    returnInfo = 0xB5;
                    break;

                case "VK_LAUNCH_APP1": // start application 1 key
                    returnInfo = 0xB6;
                    break;

                case "VK_LAUNCH_APP2": // start application 2 key
                    returnInfo = 0xB7;
                    break;

                case "VK_OEM_1": // ; or other characters in other languages
                    returnInfo = 0xBA;
                    break;

                case "VK_OEM_PLUS": // + key for any country/region
                    returnInfo = 0xBB;
                    break;

                case "VK_OEM_COMMA": // , key for any country/region
                    returnInfo = 0xBC;
                    break;

                case "VK_OEM_MINUS": // - key for any country/region
                    returnInfo = 0xBD;
                    break;

                case "VK_OEM_PERIOD": // . key for any country/region
                    returnInfo = 0xBE;
                    break;

                case "VK_OEM_2": // ? or other characters in other languages
                    returnInfo = 0xBF;
                    break;

                case "VK_OEM_3": // ~ or other characters in other languages
                    returnInfo = 0xC0;
                    break;


                case "VK_OEM_4": // [ or other characters in other languages
                    returnInfo = 0xDB;
                    break;

                case "VK_OEM_5": // | or other characters in other languages
                    returnInfo = 0xDC;
                    break;

                case "VK_OEM_6": // ] or other characters in other languages
                    returnInfo = 0xDD;
                    break;

                case "VK_OEM_7": // " or other characters in other languages
                    returnInfo = 0xDE;
                    break;

                case "VK_OEM_8": // specific to the keyboard
                    returnInfo = 0xDF;
                    break;

                case "VK_OEM_102": // <> or |
                    returnInfo = 0xE2;
                    break;

                case "VK_PROCESSKEY": // IME Process Key
                    returnInfo = 0xE5;
                    break;

                case "VK_PACKET": // pass unicode as if keystrokes Key
                    returnInfo = 0xE7;
                    break;

                case "VK_ATTN": // attn key
                    returnInfo = 0xF6;
                    break;

                case "VK_CRSEL": // crsel
                    returnInfo = 0xF7;
                    break;

                case "VK_EXSEL": // exsel
                    returnInfo = 0xF8;
                    break;

                case "VK_EREOF": // erase end of file key
                    returnInfo = 0xF9;
                    break;

                case "VK_PLAY": // play key
                    returnInfo = 0xFA;
                    break;

                case "VK_ZOOM": // zoom key
                    returnInfo = 0xFB;
                    break;

                case "VK_NONAME": // reserved
                    returnInfo = 0xFC;
                    break;

                case "VK_PA1": // PA1 key
                    returnInfo = 0xFD;
                    break;

                case "VK_OEM_CLEAR": // clear key
                    returnInfo = 0xFE;
                    break;

            }

            return returnInfo;
        }
    }
}

