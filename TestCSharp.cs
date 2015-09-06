using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections;

namespace TestCSharp
{
    #region Constants
    public enum GetWindowConstants
    {
        GW_HWNDFIRST = 0,
        GW_HWNDLAST = 1,
        GW_HWNDNEXT = 2,
        GW_HWNDPREV = 3
    }

    public enum GWLOffsets : int
    {
        /*
         * Window field offsets for GetWindowLong()
         */
        GWL_WNDPROC = (-4),
        GWL_HINSTANCE = (-6),
        GWL_HWNDPARENT = (-8),
        GWL_STYLE = (-16),
        GWL_EXSTYLE = (-20),
        GWL_USERDATA = (-21),
        GWL_ID = (-12)
    }
    #endregion

    #region Structs
    [StructLayout(LayoutKind.Sequential)]
    public struct WindowInfo
    {
        public int cbSize;
        public Rectangle rcWindow;
        public Rectangle rcClient;
        public WindowStyles dwStyle;
        public ExWindowStyles dwExStyle;
        public uint cxWindowBorders;
        public uint cyWindowBorders;
        public short atomWindowType;
        public ushort wCreatorVersion;
    }
    #endregion

    #region Flags
    [Flags]
    public enum WindowStyles : uint
    {
        /*
         * Window Styles
         */
        WS_OVERLAPPED = 0x00000000,
        WS_POPUP = 0x80000000,
        WS_CHILD = 0x40000000,
        WS_MINIMIZE = 0x20000000,
        WS_VISIBLE = 0x10000000,
        WS_DISABLED = 0x08000000,
        WS_CLIPSIBLINGS = 0x04000000,
        WS_CLIPCHILDREN = 0x02000000,
        WS_MAXIMIZE = 0x01000000,
        WS_CAPTION = 0x00C00000, /* WS_BORDER | WS_DLGFRAME  */
        WS_BORDER = 0x00800000,
        WS_DLGFRAME = 0x00400000,
        WS_VSCROLL = 0x00200000,
        WS_HSCROLL = 0x00100000,
        WS_SYSMENU = 0x00080000,
        WS_THICKFRAME = 0x00040000,
        WS_GROUP = 0x00020000,
        WS_TABSTOP = 0x00010000,
        WS_MINIMIZEBOX = 0x00020000,
        WS_MAXIMIZEBOX = 0x00010000,
        WS_TILED = WS_OVERLAPPED,
        WS_ICONIC = WS_MINIMIZE,
        WS_SIZEBOX = WS_THICKFRAME,
        WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION |
                                    WS_SYSMENU | WS_THICKFRAME |
                                    WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
        WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,
        WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU),
        WS_CHILDWINDOW = (WS_CHILD)
    }

    [Flags]
    public enum ExWindowStyles : uint
    {
        WS_EX_DLGMODALFRAME = 0x00000001,
        WS_EX_NOPARENTNOTIFY = 0x00000004,
        WS_EX_TOPMOST = 0x00000008,
        WS_EX_ACCEPTFILES = 0x00000010,
        WS_EX_TRANSPARENT = 0x00000020,
        WS_EX_MDICHILD = 0x00000040,
        WS_EX_TOOLWINDOW = 0x00000080,
        WS_EX_WINDOWEDGE = 0x00000100,
        WS_EX_CLIENTEDGE = 0x00000200,
        WS_EX_CONTEXTHELP = 0x00000400,
        WS_EX_RIGHT = 0x00001000,
        WS_EX_LEFT = 0x00000000,
        WS_EX_RTLREADING = 0x00002000,
        WS_EX_LTRREADING = 0x00000000,
        WS_EX_LEFTSCROLLBAR = 0x00004000,
        WS_EX_RIGHTSCROLLBAR = 0x00000000,
        WS_EX_CONTROLPARENT = 0x00010000,
        WS_EX_STATICEDGE = 0x00020000,
        WS_EX_APPWINDOW = 0x00040000,
        WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE),
        WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST),
        WS_EX_LAYERED = 0x00080000,
        WS_EX_NOINHERITLAYOUT = 0x00100000,
        WS_EX_LAYOUTRTL = 0x00400000,
        WS_EX_COMPOSITED = 0x02000000,
        WS_EX_NOACTIVATE = 0x08000000
    }
    #endregion

    /// <summary>
    /// Summary description for FindWindow.
    /// </summary>
    public class FindWindowLib
    {
        #region Win32 imports
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetTopWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindowEx(IntPtr hParent, IntPtr hChildAfter,
            string className, string windowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetWindow(IntPtr hWnd, GetWindowConstants uCmd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool GetWindowInfo(IntPtr hWnd, ref WindowInfo wInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, GWLOffsets nIndex);

        #endregion

        #region Constant declarations
        private const string shell_traywnd = "Shell_TrayWnd";
        private const string traynotifywnd = "TrayNotifyWnd";
        private const string syspager = "SysPager";
        private const string trayClass = "ToolbarWindow32";
        private const string trayName = "Notification Area";
        private const string progman = "Progman";
        private const string shelldll = "SHELLDLL_DefView";
        private const string syslistview = "SysListView32";
        #endregion

        /// <summary>
        /// DesktopWindow retrieves the handle to the desktop.
        /// </summary>
        public static IntPtr DesktopWindow
        {
            get { return GetDesktopWindow(); }
        }

        /// <summary>
        /// FindNotificationWindow recurses through parent/child windows
        /// to find the tray notification window.
        /// </summary>
        /// <returns>A handle to the tray notification window</returns>
        public static IntPtr FindNotificationWindow()
        {
            // start from the desktop and work down
            return FindTrayByParent(DesktopWindow, IntPtr.Zero, shell_traywnd, string.Empty);
        }

        /// <summary>
        /// IsTopWindow will scan through all the windows, determining if they are
        /// applications or not, and if the window passed in is top level, it will
        /// return true. If it isn't, it returns false.
        /// </summary>
        /// <param name="hWnd">IntPtr - the handle to the window to find</param>
        /// <returns>True if the window is top level, false if not.</returns>
        public static bool IsTopWindow(IntPtr hWnd)
        {
            IntPtr top = GetTopWindow(DesktopWindow);
            ExWindowStyles dwExStyle;
            WindowStyles dwStyle;

            if (top.Equals(hWnd))
                return true; // probably won't happen as top is the Desktop.
            else
            {
                // search through the windows, determine what they are
                IntPtr _next = GetWindow(top, GetWindowConstants.GW_HWNDNEXT);
                while (!(_next.Equals(hWnd)))
                {
                    dwExStyle = (ExWindowStyles)GetWindowLong(_next, GWLOffsets.GWL_EXSTYLE);
                    dwStyle = (WindowStyles)GetWindowLong(_next, GWLOffsets.GWL_STYLE);

                    // test to see if the current handle is 
                    // non-activatable or a toolwindow - neither of
                    // which we want.
                    if ((dwExStyle & (ExWindowStyles.WS_EX_NOACTIVATE)) ==
                        (ExWindowStyles.WS_EX_NOACTIVATE) ||
                        (dwExStyle & (ExWindowStyles.WS_EX_TOOLWINDOW)) ==
                        (ExWindowStyles.WS_EX_TOOLWINDOW))
                    {
                        _next = GetWindow(_next, GetWindowConstants.GW_HWNDNEXT);
                    }
                    else
                    {
                        // if the window isn't a toolwindow, or non-activatable,
                        // check to see if the window is an actual app, and visible
                        if (((dwExStyle & (ExWindowStyles.WS_EX_WINDOWEDGE)) ==
                            (ExWindowStyles.WS_EX_WINDOWEDGE) ||
                            (dwStyle & (WindowStyles.WS_OVERLAPPED)) ==
                            (WindowStyles.WS_OVERLAPPED) ||
                            (dwExStyle & (ExWindowStyles.WS_EX_APPWINDOW)) ==
                            (ExWindowStyles.WS_EX_APPWINDOW)) &&
                            (dwStyle & (WindowStyles.WS_VISIBLE)) ==
                            (WindowStyles.WS_VISIBLE))
                        {
                            // if we get here, the passed in window isn't top level
                            return false;
                        }
                        else
                        {
                            // get the next window
                            _next = GetWindow(_next, GetWindowConstants.GW_HWNDNEXT);
                        }
                    }

                }
            }
            // whadda ya know? it's the top level app window.
            return true;
        }

        // not tested -- should return an array of handles to application
        // windows in that show up in the taskbar, in z-order (top-level
        // window is index 0 of the array
        public IntPtr[] GetAppWindowListInZOrder()
        {
            ArrayList windows = new ArrayList();
            IntPtr top = DesktopWindow;
            ExWindowStyles dwExStyle;
            WindowStyles dwStyle;
            // search through the windows, determine what they are
            IntPtr _next = GetWindow(top, GetWindowConstants.GW_HWNDNEXT);
            while (_next != IntPtr.Zero)
            {
                dwExStyle = (ExWindowStyles)GetWindowLong(_next, GWLOffsets.GWL_EXSTYLE);
                dwStyle = (WindowStyles)GetWindowLong(_next, GWLOffsets.GWL_STYLE);

                if ((dwExStyle & (ExWindowStyles.WS_EX_NOACTIVATE)) ==
                    (ExWindowStyles.WS_EX_NOACTIVATE) ||
                    (dwExStyle & (ExWindowStyles.WS_EX_TOOLWINDOW)) ==
                    (ExWindowStyles.WS_EX_TOOLWINDOW))
                {
                    _next = GetWindow(_next, GetWindowConstants.GW_HWNDNEXT);
                }
                else
                {
                    if (((dwExStyle & (ExWindowStyles.WS_EX_WINDOWEDGE)) ==
                        (ExWindowStyles.WS_EX_WINDOWEDGE) ||
                        (dwStyle & (WindowStyles.WS_OVERLAPPED)) ==
                        (WindowStyles.WS_OVERLAPPED) ||
                        (dwExStyle & (ExWindowStyles.WS_EX_APPWINDOW)) ==
                        (ExWindowStyles.WS_EX_APPWINDOW)) &&
                        (dwStyle & (WindowStyles.WS_VISIBLE)) ==
                        (WindowStyles.WS_VISIBLE))
                    {
                        windows.Add(_next);
                    }
                    else
                    {
                        _next = GetWindow(_next, GetWindowConstants.GW_HWNDNEXT);
                    }
                }
            }
            IntPtr[] ret = new IntPtr[windows.Count];
            windows.CopyTo(ret);
            return ret;
        }

        #region Private methods
        private static IntPtr GetDesktopView()
        {
            return GetDesktopView(DesktopWindow, progman);
        }

        private static IntPtr GetDesktopView(IntPtr hParent, string className)
        {
            IntPtr _tmp = FindWindowEx(hParent, IntPtr.Zero, className, string.Empty);
            switch (className)
            {
                case progman:
                    return GetDesktopView(_tmp, shelldll);
                case shelldll:
                    return GetDesktopView(_tmp, syslistview);
            }
            return _tmp;
        }

        private static IntPtr FindTrayByParent(IntPtr hParent, IntPtr hChildAfter,
            string className, string windowName)
        {
            IntPtr _tmp;
            _tmp = FindWindowEx(hParent, hChildAfter, className, windowName);
            switch (className)
            {
                case shell_traywnd:
                    return FindTrayByParent(_tmp, IntPtr.Zero, traynotifywnd, string.Empty);
                case traynotifywnd:
                    return FindTrayByParent(_tmp, IntPtr.Zero, syspager, string.Empty);
                case syspager:
                    return FindTrayByParent(_tmp, IntPtr.Zero, trayClass, trayName);
            }
            return _tmp;
        }
        #endregion
    }
}
