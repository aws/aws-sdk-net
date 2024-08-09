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
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Object Acl Request Marshaller
    /// </summary>       
    public class GetACLRequestMarshaller : IMarshaller<IRequest, GetACLRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((GetACLRequest)input);
		}

        public IRequest Marshall(GetACLRequest getObjectAclRequest)
        {
            IRequest request = new DefaultRequest(getObjectAclRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (getObjectAclRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(getObjectAclRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(getObjectAclRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetACLRequest.BucketName");
            //Not checking if Key is null or empty because GetAcl allows to query for both a Bucket or an Object.
            request.AddPathResource("{Key+}", S3Transforms.ToStringValue(getObjectAclRequest.Key));
            request.ResourcePath = "/{Key+}";

            request.AddSubResource("acl");
            if (getObjectAclRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(getObjectAclRequest.VersionId));
            request.UseQueryString = true;
            
            return request;
        }

        private static GetACLRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static GetACLRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetACLRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
    
