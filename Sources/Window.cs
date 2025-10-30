using System;
using System.Runtime.InteropServices;

// TODO: p/invoke WNDCLASS into window class

//typedef struct tagWNDCLASSA {
//  UINT      style;
//  WNDPROC   lpfnWndProc;
//  int       cbClsExtra;
//  int       cbWndExtra;
//  HINSTANCE hInstance;
//  HICON     hIcon;
//  HCURSOR   hCursor;
//  HBRUSH    hbrBackground;
//  LPCSTR    lpszMenuName;
//  LPCSTR    lpszClassName;
//} WNDCLASSA, *PWNDCLASSA, *NPWNDCLASSA, *LPWNDCLASSA;
namespace Window
{
    namespace WindowsAPI
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct WNDCLASSA
        {
            UInt32 style;
            // TODO: add callback function
        }

        class Win32
        {
            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        }
    }
}