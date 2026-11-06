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

using Amazon.CloudFront.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteVpcOrigin Request Marshaller
    /// </summary>
    public partial class DeleteVpcOriginRequestMarshaller : IMarshaller<IRequest, DeleteVpcOriginRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteVpcOriginRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteVpcOriginRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetIfMatch())
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }

            if (!publicRequest.IsSetId())
            {
                throw new AmazonCloudFrontException("Request object does not have required field Id set");
            }
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));

            request.ResourcePath = "/2020-05-31/vpc-origin/{Id}";


            PostMarshallCustomization(request, publicRequest);
            return request;
        }

        private static readonly DeleteVpcOriginRequestMarshaller _instance = new();

        internal static DeleteVpcOriginRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteVpcOriginRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, DeleteVpcOriginRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, DeleteVpcOriginRequest publicRequest);
    }
}
