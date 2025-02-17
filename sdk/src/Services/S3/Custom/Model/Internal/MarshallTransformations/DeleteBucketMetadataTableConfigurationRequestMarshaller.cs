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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Util;
using Amazon.Util;
using System.Text;
using System.Xml;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class DeleteBucketMetadataTableConfigurationRequestMarshaller : IMarshaller<IRequest, DeleteBucketMetadataTableConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBucketMetadataTableConfigurationRequest)input);
        }

        public IRequest Marshall(DeleteBucketMetadataTableConfigurationRequest createBucketMetadataTableConfigurationRequest)
        {

            IRequest request = new DefaultRequest(createBucketMetadataTableConfigurationRequest, "AmazonS3");

            request.HttpMethod = "DELETE";

            if (createBucketMetadataTableConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(createBucketMetadataTableConfigurationRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(createBucketMetadataTableConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "DeleteBucketMetadataTableConfigurationRequest.BucketName");


            request.ResourcePath = "/";
            request.AddSubResource("metadataTable");
            request.UseQueryString = true;

            return request;

        }

        private static DeleteBucketMetadataTableConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static DeleteBucketMetadataTableConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeleteBucketMetadataTableConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
