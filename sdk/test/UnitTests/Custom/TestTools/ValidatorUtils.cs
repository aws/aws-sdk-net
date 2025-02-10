using Amazon.Util;
using ServiceClientGenerator;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.UnitTests.TestTools
{
    public static class ValidatorUtils
    {
        public static string GetTestDate(Member member, Shape shape)
        {
            if (member.IsTimeStamp)
            {
                return GetTestDate(member.TimestampFormat);
            }
            else if ((member.IsList || member.IsMap) && shape.IsTimeStamp)
            {
                // Member is of type list or map, and the shape is a date time
                return GetTestDate(shape.GetTimestampFormat(member.MarshallLocation));
            }
            else
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Cannot generate test DateTime for member {0}, shape {1}",
                    member.ModeledName, shape.Name));
            }
        }

        public static string GetTestDate(TimestampFormat timestampFormat)
        {
            switch (timestampFormat)
            {
                case TimestampFormat.ISO8601:
                    return Constants.DEFAULT_DATE.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture);
                case TimestampFormat.RFC822:
                    return Constants.DEFAULT_DATE.ToString(AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture);
                case TimestampFormat.UnixTimestamp:
                    return GetTestEpochTime().TotalSeconds.ToString(CultureInfo.InvariantCulture);
                default:
                    throw new InvalidOperationException("Encountered unsupported TimestampFormat: " + timestampFormat);
            }            
        }

        public static TimeSpan GetTestEpochTime()
        {
            long ticks = Constants.DEFAULT_DATE.Ticks - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
            return TimeSpan.FromTicks(ticks);
        }
    }
}
