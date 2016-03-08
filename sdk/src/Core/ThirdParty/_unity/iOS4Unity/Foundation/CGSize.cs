using System;
using System.Globalization;

namespace ThirdParty.iOS4Unity
{
    [Serializable]
    public struct CGSize
    {
        public static readonly CGSize Empty;

        public float Width;
        public float Height;

        public bool IsEmpty
        {
            get
            {
                return (double)Width == 0 && (double)Height == 0;
            }
        }

        public CGSize(CGPoint pt)
        {
            Width = pt.X;
            Height = pt.Y;
        }

        public CGSize(CGSize size)
        {
            Width = size.Width;
            Height = size.Height;
        }

        public CGSize(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public static CGSize Add(CGSize sz1, CGSize sz2)
        {
            return new CGSize(sz1.Width + sz2.Width, sz1.Height + sz2.Height);
        }

        public static CGSize Subtract(CGSize sz1, CGSize sz2)
        {
            return new CGSize(sz1.Width - sz2.Width, sz1.Height - sz2.Height);
        }

        public override bool Equals(object obj)
        {
            return obj is CGSize && this == (CGSize)obj;
        }

        public override int GetHashCode()
        {
            return (int)Width ^ (int)Height;
        }

        public CGPoint ToCGPoint()
        {
            return new CGPoint(Width, Height);
        }

        public override string ToString()
        {
            return string.Format("{{Width={0}, Height={1}}}", Width.ToString(CultureInfo.CurrentCulture), Height.ToString(CultureInfo.CurrentCulture));
        }

        public static CGSize operator +(CGSize sz1, CGSize sz2)
        {
            return new CGSize(sz1.Width + sz2.Width, sz1.Height + sz2.Height);
        }

        public static bool operator ==(CGSize sz1, CGSize sz2)
        {
            return sz1.Width == sz2.Width && sz1.Height == sz2.Height;
        }

        public static explicit operator CGPoint(CGSize size)
        {
            return new CGPoint(size.Width, size.Height);
        }

        public static bool operator !=(CGSize sz1, CGSize sz2)
        {
            return sz1.Width != sz2.Width || sz1.Height != sz2.Height;
        }

        public static CGSize operator -(CGSize sz1, CGSize sz2)
        {
            return new CGSize(sz1.Width - sz2.Width, sz1.Height - sz2.Height);
        }
    }
}