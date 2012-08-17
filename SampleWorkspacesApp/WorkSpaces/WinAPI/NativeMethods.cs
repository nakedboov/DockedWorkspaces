#region Using Directives

using System;
using System.Runtime.InteropServices;

#endregion Using Directives


namespace SampleWorkspacesApp.WorkSpaces.WinAPI
{
    internal static class NativeMethods
    {
        #region Constants

        private const string
            DllNameUser32 = "user32.dll";

        #endregion Constants

        #region Functions

        [DllImport(DllNameUser32)]
        public static extern bool GetWindowRect(
            IntPtr hWnd,
            out Rect lpRect);

        [DllImport(DllNameUser32)]
        public static extern bool GetClientRect(
            IntPtr hWnd,
            out Rect lpRect);

        #endregion Functions
    }
}
