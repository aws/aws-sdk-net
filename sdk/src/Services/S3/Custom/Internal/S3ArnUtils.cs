using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Internal
{
    /// <summary>
    /// Shared helper methods for S3 ARNs
    /// </summary>
    internal static class S3ArnUtils
    {
        internal static bool IsS3AccessPointsArn(string bucket)
        {
            Arn arn;
            if (Arn.TryParse(bucket, out arn))
            {
                string accessPointString;
                return arn.TryParseAccessPoint(out accessPointString);
            }
            return false;
        }

        internal static bool IsS3OutpostsArn(string bucket)
        {
            Arn arn;
            return Arn.TryParse(bucket, out arn) && arn.IsOutpostArn();
        }
    }
}
