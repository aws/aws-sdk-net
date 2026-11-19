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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.S3Control.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UntagResource Request Marshaller
    /// </summary>
    public partial class UntagResourceRequestMarshaller : IMarshaller<IRequest, UntagResourceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UntagResourceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UntagResourceRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetAccountId())
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }

            if (!publicRequest.IsSetResourceArn())
            {
                throw new AmazonS3ControlException("Request object does not have required field ResourceArn set");
            }
            request.AddPathResource("{ResourceArn+}", StringUtils.FromString(publicRequest.ResourceArn.TrimStart('/')));

            request.ResourcePath = "/v20180820/tags/{ResourceArn+}";

            if (publicRequest.TagKeys == null)
            {
                throw new AmazonS3ControlException("Request object does not have required field TagKeys set");
            }

            if (publicRequest.IsSetTagKeys())
            {
                request.ParameterCollection.Add("tagKeys", publicRequest.TagKeys);
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly UntagResourceRequestMarshaller _instance = new();

        internal static UntagResourceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UntagResourceRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UntagResourceRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, UntagResourceRequest publicRequest);
    }
}
