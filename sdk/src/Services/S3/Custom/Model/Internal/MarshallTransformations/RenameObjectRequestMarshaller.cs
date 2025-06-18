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
using Amazon.Util;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RenameObject Request Marshaller
    /// </summary>
    [SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters")]
    public class RenameObjectRequestMarshaller : IMarshaller<IRequest, RenameObjectRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RenameObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="renameObjectRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RenameObjectRequest renameObjectRequest)
        {
            if (renameObjectRequest == null)
                throw new ArgumentNullException(nameof(renameObjectRequest));
                
            var request = new DefaultRequest(renameObjectRequest, "AmazonS3");
            request.HttpMethod = "PUT";
            string uriResourcePath = "/{Key+}";
            request.AddSubResource("renameObject");

            if (renameObjectRequest.IsSetClientToken())
            {
                request.Headers.Add(HeaderKeys.XAmzClientTokenHeader, S3Transforms.ToStringValue(renameObjectRequest.ClientToken));
            }
            else
            {
                request.Headers.Add(HeaderKeys.XAmzClientTokenHeader, Guid.NewGuid().ToString());
            }

            if (renameObjectRequest.IsSetDestinationIfMatch())
            {
                request.Headers.Add(HeaderKeys.IfMatchHeader, S3Transforms.ToStringValue(renameObjectRequest.DestinationIfMatch));
            }

            if (renameObjectRequest.IsSetDestinationIfModifiedSince())
            {
                request.Headers.Add(HeaderKeys.IfModifiedSinceHeader, StringUtils.FromDateTimeToRFC822(renameObjectRequest.DestinationIfModifiedSince));
            }

            if (renameObjectRequest.IsSetDestinationIfNoneMatch())
            {
                request.Headers.Add(HeaderKeys.IfNoneMatchHeader, S3Transforms.ToStringValue(renameObjectRequest.DestinationIfNoneMatch));
            }

            if (renameObjectRequest.IsSetDestinationIfUnmodifiedSince())
            {
                request.Headers.Add(HeaderKeys.IfUnmodifiedSinceHeader, StringUtils.FromDateTimeToRFC822(renameObjectRequest.DestinationIfUnmodifiedSince));
            }

            if (renameObjectRequest.IsSetRenameSource())
            {
                request.Headers.Add(HeaderKeys.XAmzRenameSourceHeader, S3Transforms.ToStringValue(renameObjectRequest.RenameSource));
            }

            if (renameObjectRequest.IsSetSourceIfMatch())
            {
                request.Headers.Add(HeaderKeys.XAmzRenameSourceIfMatchHeader, S3Transforms.ToStringValue(renameObjectRequest.SourceIfMatch));
            }

            if (renameObjectRequest.IsSetSourceIfModifiedSince())
            {
                request.Headers.Add(HeaderKeys.XAmzRenameSourceIfModifiedSinceHeader, StringUtils.FromDateTimeToRFC822(renameObjectRequest.SourceIfModifiedSince));
            }

            if (renameObjectRequest.IsSetSourceIfNoneMatch())
            {
                request.Headers.Add(HeaderKeys.XAmzRenameSourceIfNoneMatchHeader, S3Transforms.ToStringValue(renameObjectRequest.SourceIfNoneMatch));
            }

            if (renameObjectRequest.IsSetSourceIfUnmodifiedSince())
            {
                request.Headers.Add(HeaderKeys.XAmzRenameSourceIfUnmodifiedSinceHeader, StringUtils.FromDateTimeToRFC822(renameObjectRequest.SourceIfUnmodifiedSince));
            }

            if (!renameObjectRequest.IsSetBucketName())
                throw new ArgumentException("BucketName is a required property and must be set before making this call.", nameof(renameObjectRequest));
            if (!renameObjectRequest.IsSetKey())
                throw new ArgumentException("Key is a required property and must be set before making this call.", nameof(renameObjectRequest));
            if (!renameObjectRequest.IsSetRenameSource())
                throw new ArgumentException("RenameSource is a required property and must be set before making this call.", nameof(renameObjectRequest));

            uriResourcePath = uriResourcePath.Replace("{Key+}", StringUtils.FromString(renameObjectRequest.Key));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }

        private static RenameObjectRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static RenameObjectRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RenameObjectRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}