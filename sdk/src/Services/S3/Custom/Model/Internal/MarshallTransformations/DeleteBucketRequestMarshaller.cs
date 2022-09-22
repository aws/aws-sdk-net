/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Delete Bucket Request Marshaller
    /// </summary>       
    public class DeleteBucketRequestMarshaller : IMarshaller<IRequest, DeleteBucketRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((DeleteBucketRequest)input);
		}

        public IRequest Marshall(DeleteBucketRequest deleteBucketRequest)
        {
            IRequest request = new DefaultRequest(deleteBucketRequest, "AmazonS3");

            request.HttpMethod = "DELETE";

            if (deleteBucketRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(deleteBucketRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(deleteBucketRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "DeleteBucketRequest.BucketName");

            request.ResourcePath = "/";

            if (deleteBucketRequest.BucketRegion != null)
            {
// Disable error preventing using explicit RegionEndpoints in the SDK since the code is mapping S3Regions to RegionEndpoints with a fallback default.
#pragma warning disable CR1004
                RegionEndpoint regionEndpoint;
                if(deleteBucketRequest.BucketRegion == S3Region.US)
                {
                    regionEndpoint = RegionEndpoint.USEast1;
                }
                else if (deleteBucketRequest.BucketRegion == S3Region.EU)
                {
                    regionEndpoint = RegionEndpoint.EUWest1;
                }
                else
                {
                    regionEndpoint = RegionEndpoint.GetBySystemName(deleteBucketRequest.BucketRegion.Value);
                }
#pragma warning restore CR1004
                request.AlternateEndpoint = regionEndpoint;
            }
                
            request.UseQueryString = true;
            
            return request;
        }

	    private static DeleteBucketRequestMarshaller _instance;

	    public static DeleteBucketRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new DeleteBucketRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
