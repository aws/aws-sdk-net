using System;
using System.Globalization;

namespace ThirdParty.iOS4Unity
{
    [Serializable]
    public struct CGPoint
    {
        public static readonly CGPoint Empty;

        public float X;
        public float Y;

        public bool IsEmpty
        {
            get
            {
                return (double)X == 0 && (double)Y == 0;
            }
        }

        public CGPoint(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static CGPoint Add(CGPoint pt, CGSize sz)
        {
            return new CGPoint(pt.X + sz.Width, pt.Y + sz.Height);
        }

        public static CGPoint Subtract(CGPoint pt, CGSize sz)
        {
            return new CGPoint(pt.X - sz.Width, pt.Y - sz.Height);
        }

        public override bool Equals(object obj)
        {
            return obj is CGPoint && this == (CGPoint)obj;
        }

        public override int GetHashCode()
        {
            return (int)X ^ (int)Y;
        }

        public override string ToString()
        {
            return string.Format("{{X={0}, Y={1}}}", X.ToString(CultureInfo.CurrentCulture), Y.ToString(CultureInfo.CurrentCulture));
        }

        public static CGPoint operator +(CGPoint pt, CGSize sz)
        {
            return new CGPoint(pt.X + sz.Width, pt.Y + sz.Height);
        }

        public static bool operator ==(CGPoint left, CGPoint right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        public static bool operator !=(CGPoint left, CGPoint right)
        {
            return left.X != right.X || left.Y != right.Y;
        }

        public static CGPoint operator -(CGPoint pt, CGSize sz)
        {
            return new CGPoint(pt.X - sz.Width, pt.Y - sz.Height);
        }
    }
}