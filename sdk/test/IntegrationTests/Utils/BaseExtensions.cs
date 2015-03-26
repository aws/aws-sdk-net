using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    public static class StringExtensions
    {
        public static string FormatInvariant(this string format, params object[] args)
        {
            if (string.IsNullOrEmpty(format))
                return format;
            return string.Format(CultureInfo.InvariantCulture, format, args);
        }
    }

    public static class TimeSpanExtensions
    {
        public static TimeSpan GetAbsolute(this TimeSpan self)
        {
            if (self.Ticks < 0)
                return self.Negate();
            return self;
        }

        internal static TimeSpan timeSpanEpsilon = TimeSpan.FromSeconds(10);
        public static bool ApproximatelyEqual(this TimeSpan a, TimeSpan b)
        {
            return ((a - b).GetAbsolute() < timeSpanEpsilon);
        }

        public static TimeSpan Scale(this TimeSpan self, double scale)
        {
            return new TimeSpan((long)(self.Ticks * scale));
        }
        public static TimeSpan Scale(this TimeSpan self, long scale)
        {
            return new TimeSpan(self.Ticks * scale);
        }
    }

    public static class DateTimeExtensions
    {
        public static bool ApproximatelyEqual(this DateTime a, DateTime b)
        {
            return ((a - b).GetAbsolute() < TimeSpanExtensions.timeSpanEpsilon);
        }
    }

    public static class ObjectExtensions
    {
        public static bool IsNull(this object self)
        {
            return (self == null);
        }
    }
}
