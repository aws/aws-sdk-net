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

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSession Request Marshaller
    /// </summary>       
    public class CreateSessionRequestMarshaller : IMarshaller<IRequest, CreateSessionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSessionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "GET";
            request.AddSubResource("session");

            if (!publicRequest.IsSetBucketName())
            {
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            }

            if (publicRequest.IsSetSessionMode())
            {
                request.Headers["x-amz-create-session-mode"] = publicRequest.SessionMode;
            }
            
            if (publicRequest.IsSetServerSideEncryptionMethod())
            {
                request.Headers["x-amz-server-side-encryption"] = publicRequest.ServerSideEncryption;
            }

            if (publicRequest.IsSetSSEKMSKeyId())
            {
                request.Headers["x-amz-server-side-encryption-aws-kms-key-id"] = publicRequest.SSEKMSKeyId;
            }

            if (publicRequest.IsSetSSEKMSEncryptionContext())
            {
                request.Headers["x-amz-server-side-encryption-context"] = publicRequest.SSEKMSEncryptionContext;
            }

            if (publicRequest.IsSetBucketKeyEnabled())
            {
                request.Headers["x-amz-server-side-encryption-bucket-key-enabled"] = S3Transforms.ToStringValue(publicRequest.BucketKeyEnabled.Value);
            }

            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            request.ResourcePath = "/{Bucket}";

            return request;
        }
        private static CreateSessionRequestMarshaller _instance = new CreateSessionRequestMarshaller();

        internal static CreateSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSessionRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CreateSessionRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}