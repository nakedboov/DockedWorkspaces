#region Using Directives

using System;
using System.Drawing;
using System.Runtime.InteropServices;

#endregion Using Directives


namespace SampleWorkspacesApp.WorkSpaces.WinAPI
{
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct Rect
    {
        #region Fields

        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        #endregion Fields


        #region Properties

        public int Height { get { return Bottom - Top; } }
        public Point Location { get { return new Point(Left, Top); } }
        public Size Size { get { return new Size(Width, Height); } }
        public int Width { get { return Right - Left; } }

        #endregion Properties


        #region Methods

        public static Rect FromRectangle(Rectangle rectangle)
        {
            return new Rect(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Bottom);
        }


        public override int GetHashCode()
        {
            return Left ^ ((Top << 13) | (Top >> 0x13))
              ^ ((Width << 0x1a) | (Width >> 6))
              ^ ((Height << 7) | (Height >> 0x19));
        }


        // Handy method for converting to a System.Drawing.Rectangle
        public Rectangle ToRectangle()
        {
            return Rectangle.FromLTRB(Left, Top, Right, Bottom);
        }

        #endregion Methods


        #region Operators

        public static implicit operator Rect(Rectangle rect)
        {
            return FromRectangle(rect);
        }


        public static implicit operator Rectangle(Rect rect)
        {
            return rect.ToRectangle();
        }

        #endregion Operators


        #region Constructors

        public Rect(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        #endregion Constructors
    } 
}
