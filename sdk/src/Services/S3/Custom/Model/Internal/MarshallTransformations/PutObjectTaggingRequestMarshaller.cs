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
using System.Globalization;
using System.Text;
using Amazon.Util;
using Amazon.S3.Util;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Delete Object Tagging Request Marshaller
    /// </summary>       
    public class PutObjectTaggingRequestMarshaller : IMarshaller<IRequest, PutObjectTaggingRequest>, IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall PutObjectTaggingRequest into an http request.
        /// </summary>
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutObjectTaggingRequest)input);
        }

        /// <summary>
        /// Marshall PutObjectTaggingRequest into an http request.
        /// </summary>
        public IRequest Marshall(PutObjectTaggingRequest putObjectTaggingRequest)
        {
            IRequest request = new DefaultRequest(putObjectTaggingRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putObjectTaggingRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(putObjectTaggingRequest.ChecksumAlgorithm));
            if (putObjectTaggingRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putObjectTaggingRequest.ExpectedBucketOwner));
            if (putObjectTaggingRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(putObjectTaggingRequest.RequestPayer));

            if (string.IsNullOrEmpty(putObjectTaggingRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutObjectTaggingRequest.BucketName");
            if (string.IsNullOrEmpty(putObjectTaggingRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "PutObjectTaggingRequest.Key");

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}", 
                                                 S3Transforms.ToStringValue(putObjectTaggingRequest.Key));
            request.AddSubResource("tagging");

            if (putObjectTaggingRequest.IsSetVersionId())
                request.AddSubResource("versionId", putObjectTaggingRequest.VersionId);

            try
            {
                var content = AmazonS3Util.SerializeTaggingToXml(putObjectTaggingRequest.Tagging);
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetRequestChecksum(request, putObjectTaggingRequest.ChecksumAlgorithm);
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marhsall request to XML", e);
            }

            return request;
        }

        private static PutObjectTaggingRequestMarshaller _instance;

        public static PutObjectTaggingRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutObjectTaggingRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
    
