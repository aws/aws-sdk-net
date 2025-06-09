using Amazon.Runtime.Internal;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.S3.Internal
{
    /// <summary>
    /// Class containing custom marshall transformations for S3.
    /// Only meant for internal use.
    /// </summary>
    public static class CustomMarshallTransformations
    {
        /// <summary>
        /// Custom Marshall transformation for default bucket request. Meant for internal usage only.
        /// </summary>
        /// <param name="defaultRequest"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static DefaultRequest CustomizeDeleteBucketMarshaller(DefaultRequest defaultRequest, DeleteBucketRequest request)
        {
            if (request.BucketRegion != null)
            {
                RegionEndpoint regionEndpoint;
#pragma warning disable CR1004
                if (request.BucketRegion == S3Region.USEast1)
                {
                    regionEndpoint = RegionEndpoint.USEast1;
                }
                else if (request.BucketRegion == S3Region.EUWest1)
                {
                    regionEndpoint = RegionEndpoint.EUWest1;
                }
                else
                {
                    regionEndpoint = RegionEndpoint.GetBySystemName(request.BucketRegion.Value);
                }
#pragma warning restore CR1004
                defaultRequest.AlternateEndpoint = regionEndpoint;
            }
            return defaultRequest;
        }
    }
}
