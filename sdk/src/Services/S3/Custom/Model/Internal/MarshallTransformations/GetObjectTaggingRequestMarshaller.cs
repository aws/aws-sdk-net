/*
 * Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetObjectTaggingRequest Marshaller
    /// </summary>       
    public class GetObjectTaggingRequestMarshaller : IMarshaller<IRequest, GetObjectTaggingRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall GetObjectTaggingRequest into an http request.
        /// </summary>
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((GetObjectTaggingRequest)input);
        }

        /// <summary>
        /// Marshall GetObjectTaggingRequest into an http request.
        /// </summary>
        public IRequest Marshall(GetObjectTaggingRequest getObjectTaggingRequest)
        {
            IRequest request = new DefaultRequest(getObjectTaggingRequest, "AmazonS3");

            request.HttpMethod = "GET";

            request.UseQueryString = true;
            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}", 
                                                 S3Transforms.ToStringValue(getObjectTaggingRequest.BucketName), 
                                                 S3Transforms.ToStringValue(getObjectTaggingRequest.Key));
            request.AddSubResource("tagging");

            if (getObjectTaggingRequest.IsSetVersionId())
                request.AddSubResource("versionId", getObjectTaggingRequest.VersionId);

            return request;
        }

        private static GetObjectTaggingRequestMarshaller _instance;

        public static GetObjectTaggingRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetObjectTaggingRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}